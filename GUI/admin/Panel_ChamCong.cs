using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.BUS._ado;
using CompanyHRManagement.DAL._ado;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_ChamCong : UserControl
    {
        String err = null;

        AttendanceBUS dbAttendance = new AttendanceBUS();
        DataTable dtAttendance = new DataTable();
        LeavesBUS dbLeave = new LeavesBUS();

        private bool isEdit = false;


        public Panel_ChamCong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgv_Attendance.DataSource = dbAttendance.GetAttendanceEF();
                dtAttendance = dbAttendance.GetAttendanceEF();
                dgv_Leaves.DataSource = dbLeave.GetLeaveEF();

                dgv_Attendance.AutoResizeColumns();

                dgv_Attendance.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgv_Attendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                //dgv_Leaves.AutoResizeColumns();
                dgv_Leaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_Leaves.ScrollBars = ScrollBars.Both;

                dgv_Leaves.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgv_Leaves.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                this.txtID.ResetText();
                this.txtTenNV.ResetText(); ;
                this.txtStartDate.ResetText();
                this.txtEndDate.ResetText();
                this.txtReason.ResetText();

                this.btnPheDuyet.Enabled = false;
                this.btnTuChoi.Enabled = false;
                //this.panel1.Enabled = false;

                dgv_Attendance.ReadOnly = !isEdit;
                dgv_Leaves.ReadOnly = true;
                //btnChinhSua.Enabled = isEdit;
                btnLuu.Enabled = isEdit;
                btnXoa.Enabled = isEdit;

                dgv_Leaves_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Attendance hay Leave. Lỗi rồi!!!");
            }
        }
        void CalculateAndDisplaySummary()
        {
            if (cbSelectDate.SelectedItem == null) return;

            if (DateTime.TryParse(cbSelectDate.SelectedItem.ToString(), out DateTime selectedDate))
            {
                var (employeeCount, avgHours, totalOT) = dbAttendance.CalculateSummary(selectedDate);

                txtTongNV.Text = employeeCount.ToString("0");
                txtNCtb.Text = avgHours.ToString("0.0");
                txtOT.Text = totalOT.ToString("0.0");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày hợp lệ!");
            }
        }
        void LoadDate()
        {
            var workDates = dbAttendance.GetWorkDates();

            cbSelectDate.Items.Clear();
            DateFilter.Items.Clear();

            foreach (var date in workDates)
            {
                var dateString = date.ToString("yyyy-MM-dd");
                cbSelectDate.Items.Add(dateString);
                DateFilter.Items.Add(dateString);
            }

            if (cbSelectDate.Items.Count > 0)
                cbSelectDate.SelectedIndex = 0;
        }
        private void FilterAttendanceData()
        {
            if (dbAttendance == null) return;

            var filteredView = dtAttendance.DefaultView;
            string filter = "";

            // Employee ID filter
            if (!string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                if (int.TryParse(txtEmployeeID.Text.Trim(), out int empID))
                {
                    filter += $"[Mã nhân viên] = {empID}";
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ!");
                    return;
                }
            }

            if (DateFilter.SelectedItem != null)
            {
                if (DateTime.TryParse(DateFilter.SelectedItem.ToString(), out DateTime date))
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"CONVERT([Ngày làm], 'System.DateTime') = #{date:MM/dd/yyyy}#";
                }
            }

            // Name search filter
            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                string nameFilter = txtTimKiem.Text.Trim();
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"[Tên Nhân viên] LIKE '%{nameFilter.Replace("'", "''")}%'";
            }

            filteredView.RowFilter = filter;
            dgv_Attendance.DataSource = filteredView;
        }

        private void dgv_Leaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Leaves.CurrentCell.RowIndex;

            txtID.Text = dgv_Leaves.Rows[r].Cells[0].Value?.ToString();
            txtTenNV.Text = dgv_Leaves.Rows[r].Cells[2].Value?.ToString();
            txtStartDate.Text = dgv_Leaves.Rows[r].Cells[3].Value?.ToString();
            txtEndDate.Text = dgv_Leaves.Rows[r].Cells[4].Value?.ToString();
            txtReason.Text = dgv_Leaves.Rows[r].Cells[5].Value?.ToString();

            btnPheDuyet.Enabled = true;
            btnTuChoi.Enabled = true;
        }

        private void Panel_ChamCong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDate();
            CalculateAndDisplaySummary();
        }

        private void cbSelectDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAndDisplaySummary();
        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            if (dgv_Leaves.CurrentRow == null) return;

            int leaveID = Convert.ToInt32(txtID.Text);
            int employeeID = Convert.ToInt32(dgv_Leaves.CurrentRow.Cells["EmployeeID"].Value);

            if (dbLeave.UpdateLeaveStatus(leaveID, "Chấp nhận"))
            {
                SendNotificationToEmployee(
                    senderId: 12, // ID của quản lý đang đăng nhập
                    receiverId: employeeID,
                    messageContent: "Đơn nghỉ phép của bạn đã được phê duyệt"
                );

                MessageBox.Show("Đã phê duyệt đơn nghỉ phép!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi phê duyệt đơn!");
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgv_Leaves.CurrentRow == null) return;

            int leaveID = Convert.ToInt32(txtID.Text);
            int employeeID = Convert.ToInt32(dgv_Leaves.CurrentRow.Cells["EmployeeID"].Value);

            if (dbLeave.UpdateLeaveStatus(leaveID, "Từ chối"))
            {
                SendNotificationToEmployee(
                    senderId: 12, // ID của quản lý đang đăng nhập
                    receiverId: employeeID,
                    messageContent: "Đơn nghỉ phép của bạn đã bị từ chối"
                );

                MessageBox.Show("Đã từ chối đơn nghỉ phép!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi từ chối đơn!");
            }
        }
        private void SendNotificationToEmployee(int senderId, int receiverId, string messageContent)
        {
            try
            {
                var message = new MessageBUS();
                string formattedContent = $"[HỆ THỐNG] {messageContent} - {DateTime.Now:dd/MM/yyyy HH:mm}";

                bool success = message.GuiTin(
                    senderId: senderId,
                    receiverId: receiverId,
                    content: formattedContent,
                    ref err
                );

                if (!success)
                {
                    Console.WriteLine("Không thể gửi thông báo qua hệ thống tin nhắn");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi thông báo: {ex.Message}");
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;

            // Update button states
            btnChinhSua.Text = isEdit ? "Dừng chỉnh sửa" : "Chỉnh sửa";
            btnLuu.Enabled = isEdit;
            btnXoa.Enabled = isEdit;

            dgv_Attendance.ReadOnly = !isEdit;

            if (!isEdit)
            {
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Attendance.EndEdit();

                // Get changes from the DataTable
                DataTable changes = dtAttendance.GetChanges(DataRowState.Modified);

                if (changes != null && changes.Rows.Count > 0)
                {
                    string err = string.Empty;
                    if (dbAttendance.UpdateAttendance(changes, ref err))
                    {
                        MessageBox.Show("Lưu dữ liệu thành công!");
                        dtAttendance.AcceptChanges();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi lưu dữ liệu: {err}");
                        dtAttendance.RejectChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào để lưu!");
                }
                // Exit edit mode
                isEdit = false;
                btnChinhSua.Text = "Chỉnh sửa";
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                dgv_Attendance.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_Attendance.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần xóa!");
                return;
            }

            int attendanceID = Convert.ToInt32(dgv_Attendance.CurrentRow.Cells["AttendanceID"].Value);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbAttendance.DeleteAttendance(ref err, attendanceID))
                {
                    MessageBox.Show("Xóa bản ghi thành công!");
                    LoadData(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa bản ghi!");
                }
            }
        }

        private void btnXoaNP_Click(object sender, EventArgs e)
        {
            if (dgv_Leaves.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn nghỉ phép cần xóa!");
                return;
            }

            int leaveID = Convert.ToInt32(txtID.Text);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đơn nghỉ phép này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dbLeave.DeleteLeave(ref err, leaveID))
                    {
                        MessageBox.Show("Xóa đơn nghỉ phép thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn nghỉ phép không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa đơn nghỉ phép: {ex.Message}");
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterAttendanceData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
