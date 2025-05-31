using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.BUS._ado;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_PhongChucVu : UserControl
    {
        DepartmentBUS departmentBUS = new DepartmentBUS();
        PositionBUS positionBUS = new PositionBUS();
        private bool them, sua = false;
        public Panel_PhongChucVu()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            LoadDepartmentsToGrid(departmentBUS.LayTatCaPhongBan());
            LoadPositionsToGrid(positionBUS.LayTatCaChucVu());
            cbAction.SelectedIndex = 0;
        }

        private void LoadDepartmentsToGrid(List<Department> danhsach)
        {
            dgvDepartment.DataSource = danhsach;
            dgvDepartment.Columns["DepartmentID"].HeaderText = "Mã Phòng Ban";
            dgvDepartment.Columns["DepartmentName"].HeaderText = "Tên Phòng Ban";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartment.AllowUserToAddRows = false;
        }
        private void LoadPositionsToGrid(List<Position> danhSach)
        {
            dgvPosition.DataSource = danhSach;

            dgvPosition.Columns["PositionID"].HeaderText = "Mã Chức Vụ";
            dgvPosition.Columns["PositionName"].HeaderText = "Tên Chức Vụ";
            dgvPosition.Columns["BaseSalary"].HeaderText = "Lương Cơ Bản";

            dgvPosition.ReadOnly = true;
            dgvPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPosition.AllowUserToAddRows = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
            {
                txtIDDepartment.Enabled = false;
                LoadDepartmentsToGrid(departmentBUS.TimTenPhongBan(txtDepartmentName.Text.ToString()));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
            {
                txtIDDepartment.Enabled = false;
                txtDepartmentName.Clear();
                them = true;
            }
            else if (cbAction.SelectedIndex == 1)
            {
                txtIDPos.Enabled = false;
                txtPositionName.Clear();
                txtBaseSalary.Clear();
                them = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động là Phòng Ban hoặc Chức vụ");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";

            if (cbAction.SelectedIndex == 0)
            {
                string deptName = txtDepartmentName.Text.Trim();

                if (string.IsNullOrWhiteSpace(deptName))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = false;

                if (them)
                {
                    result = departmentBUS.ThemPhongBan(deptName, ref error);
                    if (result)
                        MessageBox.Show("Thêm phòng ban thành công.");
                    them = false;
                }
                else
                {
                    int id;
                    if (!int.TryParse(txtIDDepartment.Text, out id))
                    {
                        MessageBox.Show("ID phòng ban không hợp lệ!");
                        return;
                    }
                    result = departmentBUS.UpdateTen(id, deptName, ref error);
                    sua = false;
                }

                if (!result)
                {
                    MessageBox.Show("Lỗi: " + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
                txtDepartmentName.Clear();
                them = false;
            }
            else if (cbAction.SelectedIndex == 1)
            {
                string posName = txtPositionName.Text.Trim();
                string baseSalaryText = txtBaseSalary.Text.Trim();
                decimal baseSalary = 0;
                bool result = false;

                if (string.IsNullOrWhiteSpace(posName))
                {
                    MessageBox.Show("Vui lòng nhập tên chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(baseSalaryText, out baseSalary) || baseSalary < 0)
                {
                    MessageBox.Show("Lương cơ bản không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (them) // Thêm chức vụ
                {
                    result = positionBUS.ThemChucVu(posName, baseSalary, ref error);
                    if (result)
                        MessageBox.Show("Thêm chức vụ thành công.");
                    them = false;
                }
                else if (sua) // Sửa chức vụ
                {
                    if (!int.TryParse(txtIDPos.Text, out int id))
                    {
                        MessageBox.Show("ID chức vụ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    result = positionBUS.SuaChucVu(id, posName, baseSalary, ref error);
                    if (result)
                        MessageBox.Show("Cập nhật chức vụ thành công.");
                    sua = false;
                }

                if (!result)
                    MessageBox.Show("Lỗi: " + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LoadData(); // Tải lại dữ liệu (có thể tùy chỉnh load theo cbAction)
                txtPositionName.Clear();
                txtBaseSalary.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động là Phòng Ban hoặc Chức vụ");
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo người dùng click hợp lệ (không click header)
            if (e.RowIndex >= 0 && dgvDepartment.Rows[e.RowIndex].Cells["DepartmentID"].Value != null)
            {
                DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView xuống các TextBox
                txtIDDepartment.Text = row.Cells["DepartmentID"].Value.ToString();
                txtDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string error = string.Empty;

            if (cbAction.SelectedIndex == 0) // Phòng Ban
            {
                if (!int.TryParse(txtIDDepartment.Text, out int id))
                {
                    MessageBox.Show("ID phòng ban không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng ban này?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (departmentBUS.XoaPhongban(id, ref error))
                    {
                        MessageBox.Show("Xóa phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txtDepartmentName.Clear();
                        txtIDDepartment.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (cbAction.SelectedIndex == 1) // Chức Vụ
            {
                if (!int.TryParse(txtIDPos.Text, out int id))
                {
                    MessageBox.Show("ID chức vụ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (positionBUS.XoaChucVu(id, ref error))
                    {
                        MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txtPositionName.Clear();
                        txtBaseSalary.Clear();
                        txtIDPos.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động là Phòng Ban hoặc Chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPosition.Rows[e.RowIndex].Cells["PositionID"].Value != null)
            {
                DataGridViewRow row = dgvPosition.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView xuống các TextBox
                txtIDPos.Text = row.Cells["PositionID"].Value.ToString();
                txtPositionName.Text = row.Cells["PositionName"].Value.ToString();
                txtBaseSalary.Text = row.Cells["BaseSalary"].Value.ToString();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            sua = true;
            if (cbAction.SelectedIndex == 0)
            {
                txtIDDepartment.Enabled = false;
            }
            else if (cbAction.SelectedIndex == 1)
            {
                txtIDPos.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động hợp lệ");
            }
        }

        private void Panel_PhongChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
