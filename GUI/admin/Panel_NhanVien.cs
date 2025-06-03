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
using CompanyHRManagement.DAL;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_NhanVien : UserControl
    {
        DataTable dtNV = null;
        String err = null;

        EmployeeBUS dbEm = new EmployeeBUS();

        public Panel_NhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtNV = dbEm.GetEmployees();
                dgvNhanVien.DataSource = dtNV;
                dgvNhanVien.AutoResizeColumns();

                dgvNhanVien.ReadOnly = true;

                dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                var distinctDepartments = dtNV.AsEnumerable()
                    .Select(r => r.Field<string>("Tên PB"))
                    .Where(x => x != null)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
                cbPhong.Items.Clear();
                cbPhong.Items.Add("");
                cbPhong.Items.AddRange(distinctDepartments.ToArray());

                var distinctPositions = dtNV.AsEnumerable()
                    .Select(r => r.Field<string>("Tên Chức vụ"))
                    .Where(x => x != null)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
                cbBoPhan.Items.Clear();
                cbBoPhan.Items.Add("");
                cbBoPhan.Items.AddRange(distinctPositions.ToArray());
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }

        }

        void ApplyNhanVienFilter()
        {
            if (dtNV == null) return;

            string filter = "";

            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                filter += $"[Họ và tên] LIKE '%{txtTimKiem.Text.Replace("'", "''")}%' ";
            }

            if (!string.IsNullOrWhiteSpace(cbPhong.Text))
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"[Tên PB] = '{cbPhong.Text.Replace("'", "''")}' ";
            }

            if (!string.IsNullOrWhiteSpace(cbBoPhan.Text))
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"[Tên Chức vụ] = '{cbBoPhan.Text.Replace("'", "''")}' ";
            }

            DataView dv = dtNV.DefaultView;
            dv.RowFilter = filter;
            dgvNhanVien.DataSource = dv;
        }

        private void Panel_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0) return;

            var selectedIds = dgvNhanVien.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells[0].Value))
                .ToList();

            bool allSuccess = true;
            foreach (int id in selectedIds)
            {
                if (!dbEm.DeleteEmployee(id))
                {
                    allSuccess = false;
                }
            }

            MessageBox.Show(allSuccess ? "Đã xóa thành công!" : "Có lỗi xảy ra khi xóa một số nhân viên.");
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text) ||
                string.IsNullOrWhiteSpace(txtPositionID.Text) ||
                string.IsNullOrWhiteSpace(txtIsProbation.Text) ||
                string.IsNullOrWhiteSpace(txtIsFired.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra các trường số hợp lệ
            if (!int.TryParse(txtDepartmentID.Text, out int departmentId))
            {
                MessageBox.Show("Mã phòng ban không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPositionID.Text, out int positionId))
            {
                MessageBox.Show("Mã chức vụ không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtIsProbation.Text, out int isProbation))
            {
                MessageBox.Show("Trạng thái thử việc không hợp lệ! (Chỉ nhập 0 hoặc 1)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtIsFired.Text, out int isFired))
            {
                MessageBox.Show("Trạng thái nghỉ việc không hợp lệ! (Chỉ nhập 0 hoặc 1)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Employee nếu mọi thứ đều hợp lệ
            var emp = new Employee
            {
                FullName = txtFullName.Text,
                BirthDate = dtpBirthDay.Value,
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                DepartmentID = int.Parse(txtDepartmentID.Text),
                PositionID = int.Parse(txtPositionID.Text),
                HireDate = dtpHireDate.Value,
                IsProbation = txtIsProbation.Text == "1",
                IsFired = txtIsFired.Text == "1",
                Password = txtPassword.Text
            };
            if (dbEm.InsertEmployee(emp, ref err))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2Button9_Click(object sender, EventArgs e)
        {
            ApplyNhanVienFilter();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0) return;
            var row = dgvNhanVien.SelectedRows[0];

            // check null 
            txtEmployeeID.Text = row.Cells[0].Value == DBNull.Value ? "" : row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value == DBNull.Value ? "" : row.Cells[1].Value.ToString();
            dtpBirthDay.Value = row.Cells[2].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells[2].Value);
            txtGender.Text = row.Cells[3].Value == DBNull.Value ? "" : row.Cells[3].Value.ToString();
            txtAddress.Text = row.Cells[4].Value == DBNull.Value ? "" : row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[5].Value == DBNull.Value ? "" : row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value == DBNull.Value ? "" : row.Cells[6].Value.ToString();
            txtDepartmentID.Text = row.Cells[7].Value == DBNull.Value ? "" : row.Cells[7].Value.ToString();
            txtPositionID.Text = row.Cells[9].Value == DBNull.Value ? "" : row.Cells[9].Value.ToString();
            dtpHireDate.Value = row.Cells[11].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells[11].Value);
            txtIsProbation.Text = row.Cells[12].Value == DBNull.Value ? "0" : Convert.ToInt32(row.Cells[12].Value).ToString();
            txtIsFired.Text = row.Cells[13].Value == DBNull.Value ? "0" : Convert.ToInt32(row.Cells[13].Value).ToString();
            txtPassword.Text = row.Cells[14].Value == DBNull.Value ? "" : row.Cells[14].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeID.Text, out int id)) return;

            var emp = new Employee
            {
                EmployeeID = id,
                FullName = txtFullName.Text,
                BirthDate = dtpBirthDay.Value,
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                DepartmentID = int.Parse(txtDepartmentID.Text),
                PositionID = int.Parse(txtPositionID.Text),
                HireDate = dtpHireDate.Value,
                IsProbation = txtIsProbation.Text == "1",
                IsFired = txtIsFired.Text == "1",
                Password = txtPassword.Text
            };

            if (dbEm.UpdateEmployee(emp))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
