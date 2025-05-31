using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CompanyHRManagement.DTO;
namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_ThuongPhat : UserControl
    {
        private RewardBUS _rewardBUS = new RewardBUS();
        private DisciplineBUS _disciplineBUS = new DisciplineBUS();
        private bool them, sua = false;
        public Panel_ThuongPhat()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            LoadDGVThuong(_rewardBUS.LayDanhSachKhenThuong());
            LoadDGVPhat(_disciplineBUS.LayDanhSachPhat());

        }
        private void LoadDGVThuong(List<RewardDTO> danhSachThuong)
        {
            try
            {
                dgvThuong.DataSource = danhSachThuong;

                dgvThuong.Columns["EmployeeID"].Visible = false;

                dgvThuong.Columns["RewardID"].HeaderText = "Mã khen thưởng";
                dgvThuong.Columns["FullName"].HeaderText = "Họ tên";
                dgvThuong.Columns["Reason"].HeaderText = "Lý do";
                dgvThuong.Columns["RewardDate"].HeaderText = "Ngày thưởng";
                dgvThuong.Columns["Amount"].HeaderText = "Số tiền";

                dgvThuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvThuong.ReadOnly = true;
                dgvThuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvThuong.AllowUserToAddRows = false;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không lấy được nội dung bảng thưởng. Đã xảy ra lỗi!\n" + e.Message);
            }
        }

        private void LoadDGVPhat(List<DisciplineDTO> danhSachPhat)
        {
            try
            {
                dgvPhat.DataSource = danhSachPhat;

                dgvPhat.Columns["EmployeeID"].Visible = false;

                // Đặt tiêu đề cho các cột hiển thị
                dgvPhat.Columns["DisciplineID"].HeaderText = "Mã kỷ luật";
                dgvPhat.Columns["FullName"].HeaderText = "Họ tên";
                dgvPhat.Columns["Reason"].HeaderText = "Lý do";
                dgvPhat.Columns["DisciplineDate"].HeaderText = "Ngày kỷ luật";
                dgvPhat.Columns["Amount"].HeaderText = "Số tiền";

                dgvPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhat.ReadOnly = true;
                dgvPhat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPhat.AllowUserToAddRows = false;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không lấy được nội dung bảng kỷ luật. Đã xảy ra lỗi!\n" + e.Message);
            }
        }


        private void Panel_ThuongPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng bấm vào tiêu đề cột hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0)
                return;

            // Lấy số hàng đang được chọn
            int selectedCount = dgvThuong.SelectedRows.Count;
            cbAction.SelectedIndex = 0;
            // Nếu chọn nhiều dòng
            if (selectedCount > 1)
            {
                List<string> rewardIDs = new List<string>();
                foreach (DataGridViewRow row in dgvThuong.SelectedRows)
                {
                    if (row.Cells["RewardID"].Value != null)
                        rewardIDs.Add(row.Cells["RewardID"].Value.ToString());
                }

                txtRewDisID.Text = string.Join(",", rewardIDs);
                ClearAllText();

            }
            else // Nếu chỉ chọn 1 dòng
            {
                DataGridViewRow row = dgvThuong.Rows[e.RowIndex];

                txtRewDisID.Text = row.Cells["RewardID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtReason.Text = row.Cells["Reason"].Value?.ToString();
                txtAmount.Text = row.Cells["Amount"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["RewardDate"].Value?.ToString(), out DateTime rewardDate))
                {
                    txtDay.Text = rewardDate.Day.ToString();
                    txtMonth.Text = rewardDate.Month.ToString();
                    txtYear.Text = rewardDate.Year.ToString();
                }
                else
                {
                    txtDay.Clear();
                    txtMonth.Clear();
                    txtYear.Clear();
                }
            }
        }

        private void ClearAllText()
        {
            txtFullName.Clear();
            txtReason.Clear();
            txtAmount.Clear();
            txtDay.Clear();
            txtMonth.Clear();
            txtYear.Clear();
        }

        private void dgvPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng bấm vào tiêu đề cột hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0)
                return;

            // Lấy số hàng đang được chọn
            int selectedCount = dgvPhat.SelectedRows.Count;
            cbAction.SelectedIndex = 1;

            // Nếu chọn nhiều dòng
            if (selectedCount > 1)
            {
                List<string> disciplineIDs = new List<string>();
                foreach (DataGridViewRow row in dgvPhat.SelectedRows)
                {
                    if (row.Cells["DisciplineID"].Value != null)
                        disciplineIDs.Add(row.Cells["DisciplineID"].Value.ToString());
                }

                txtRewDisID.Text = string.Join(",", disciplineIDs);
                ClearAllText();
            }
            else // Nếu chỉ chọn 1 dòng
            {
                DataGridViewRow row = dgvPhat.Rows[e.RowIndex];

                txtRewDisID.Text = row.Cells["DisciplineID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtReason.Text = row.Cells["Reason"].Value?.ToString();
                txtAmount.Text = row.Cells["Amount"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["DisciplineDate"].Value?.ToString(), out DateTime disciplineDate))
                {
                    txtDay.Text = disciplineDate.Day.ToString();
                    txtMonth.Text = disciplineDate.Month.ToString();
                    txtYear.Text = disciplineDate.Year.ToString();
                }
                else
                {
                    txtDay.Clear();
                    txtMonth.Clear();
                    txtYear.Clear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
            {
                LoadDGVThuong(_rewardBUS.TimKiemThuong(txtRewDisID.Text.ToString(), txtFullName.Text.ToString(),
                    txtAmount.Text.ToString(), txtDay.Text.ToString(), txtMonth.Text.ToString(),
                    txtYear.Text.ToString(), txtReason.Text.ToString()));

            }
            else if (cbAction.SelectedIndex == 1)
            {
                LoadDGVPhat(_disciplineBUS.TimKiemPhat(txtRewDisID.Text.ToString(), txtFullName.Text.ToString(),
                    txtAmount.Text.ToString(), txtDay.Text.ToString(), txtMonth.Text.ToString(),
                    txtYear.Text.ToString(), txtReason.Text.ToString()));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động là Thưởng hoặc Phạt");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";
            string fullName = txtFullName.Text.Trim();
            string reason = txtReason.Text.Trim();
            string day = txtDay.Text.Trim();
            string month = txtMonth.Text.Trim();
            string year = txtYear.Text.Trim();
            string amountStr = txtAmount.Text.Trim();
            string ID = txtRewDisID.Text.Trim();
            bool result = false;
            if (!decimal.TryParse(amountStr, out decimal amount))
            {
                MessageBox.Show("Số tiền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (them == true)
            {
                if (cbAction.SelectedIndex == 0)
                {
                    result = _rewardBUS.ThemThuong(fullName, reason, day, month, year, amount, ref error);
                                        
                } else if (cbAction.SelectedIndex == 1)
                {
                    result = _disciplineBUS.Themphat(fullName, reason, day, month, year, amount, ref error);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hành động là Thưởng/Phạt");
                }

                if (result)
                {
                    MessageBox.Show("Thêm khen thưởng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    them = false;
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm khen thưởng: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } else
            {
                if (sua == true)
                {
                    panel_thongtin.Enabled = true;
                    txtRewDisID.Enabled = false;
                    if (cbAction.SelectedIndex == 0)
                    {
                        // 2. Gọi BUS để cập nhật
                        result = _rewardBUS.CapNhatReward(ID, fullName, reason, day, month, year, amount, ref error);
                    } else if (cbAction.SelectedIndex == 1)
                    {
                        result = _disciplineBUS.CapNhatDiscipline(ID, fullName, reason, day, month, year, amount, ref error);
                    }

                    // 3. Hiển thị kết quả
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        sua = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string error = "";
            string input = txtRewDisID.Text;  // Lấy danh sách ID từ txtRewDisID
            bool result = false;    
            // 1. Phân tách danh sách ID từ người dùng nhập
            List<int> IDs = input.Split(',')
                .Select(id => int.TryParse(id.Trim(), out int parsedId) ? parsedId : 0)
                .Where(id => id > 0)
                .ToList();

            if (IDs.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbAction.SelectedIndex == 0)
            {
                // 2. Xác nhận người dùng
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {IDs.Count} bản ghi thưởng?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                    return;

                // 3. Gọi BUS để xóa
                result = _rewardBUS.xoaThuong(IDs, ref error);

            }
            else if (cbAction.SelectedIndex == 1) {
                // 2. Xác nhận người dùng
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {IDs.Count} bản ghi phạt?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                    return;

                // 3. Gọi BUS để xóa
                result = _disciplineBUS.xoaPhat(IDs, ref error);
            }
            // 4. Kết quả
            if (result)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            sua = true;
            txtRewDisID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            them = true;
            ClearAllText();
            txtRewDisID.Enabled = false;
        }
    }
}
