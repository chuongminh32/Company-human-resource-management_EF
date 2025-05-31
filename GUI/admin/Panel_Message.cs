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
using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using CompanyHRManagement.DAL._ado;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_Message : UserControl
    {
        public int CurrentUserId { get; set; }
        DataTable TNMoi = null;
        String err = null;

        MessageBUS dbMess = new MessageBUS();
        EmployeeBUS dbEmp = new EmployeeBUS();

        public Panel_Message()
        {
            InitializeComponent();
        }

        private void LoadSent()
        {
            try
            {
                TNMoi = dbMess.GetMessageEF();
                dgvMess.DataSource = TNMoi;

                dgvMess.AutoResizeColumns();
                dgvMess.ReadOnly = true;
                dgvMess.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgvMess.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);


                if (!dgvMess.Columns.Contains("colEdit"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                    {
                        Name = "colEdit",
                        HeaderText = "",
                        Text = "✏️",
                        UseColumnTextForButtonValue = true,
                        Width = 40
                    };
                    dgvMess.Columns.Add(btnEdit);
                }

                if (!dgvMess.Columns.Contains("colDelete"))
                {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                    {
                        Name = "colDelete",
                        HeaderText = "",
                        Text = "❌",
                        UseColumnTextForButtonValue = true,
                        Width = 40
                    };
                    dgvMess.Columns.Add(btnDelete);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Message. Lỗi rồi!!!");
            }

        }

        private void LoadReceiverList()
        {
            try
            {
                var employees = dbEmp.GetAllEmployeesEF();
                cbReceiver.DataSource = employees;
                cbReceiver.DisplayMember = "FullName";
                cbReceiver.ValueMember = "EmployeeID";
                cbReceiver.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được danh sách người nhận: {ex.Message}");
            }
        }

        private void btnGuiTN_Click(object sender, EventArgs e)
        {
            if (cbReceiver.SelectedValue == null || string.IsNullOrWhiteSpace(txtND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool result = dbMess.GuiTin(
                CurrentUserId,
                (int)cbReceiver.SelectedValue,
                txtND.Text,
                ref err);

            if (result)
            {
                MessageBox.Show("Gửi thành công!");
                txtND.Clear();
                LoadSent();
            }
            else
            {
                MessageBox.Show($"Gửi thất bại: {err}");
            }
        }

        private void dgvLSTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var messageId = Convert.ToInt32(dgvMess.Rows[e.RowIndex].Cells["Mã"].Value);

            if (dgvMess.Columns[e.ColumnIndex].Name == "colEdit")
            {
                string oldContent = dgvMess.Rows[e.RowIndex].Cells["Nội dung"].Value.ToString();
                string newContent = ShowDialog("Sửa nội dung:", oldContent);

                if (!string.IsNullOrWhiteSpace(newContent))
                {
                    bool success = dbMess.UpdateTinNhanMoi(messageId, newContent, ref err);
                    if (success)
                    {
                        LoadSent();
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi cập nhật: {err}");
                    }
                }
            }
            else if (dgvMess.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show("Xác nhận xóa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool success = dbMess.XoaTin(messageId, ref err);
                    if (success)
                    {
                        LoadSent();
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi xóa: {err}");
                    }
                }
            }
        }

        private void Panel_Message_Load(object sender, EventArgs e)
        {
            LoadSent();
            LoadReceiverList();
        }
        private static string ShowDialog(string title, string defaultValue)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label lbl = new Label() { Left = 20, Top = 20, Text = title, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 90, DialogResult = DialogResult.OK };

            prompt.Controls.Add(lbl);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

    }
}
