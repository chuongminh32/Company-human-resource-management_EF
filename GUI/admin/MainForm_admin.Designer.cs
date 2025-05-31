using System.Drawing;
using System.Windows.Forms;

namespace CompanyHRManagement.GUI.admin
{
    partial class MainForm_admin
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDepPos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThuongPhat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnTinNhan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_main = new CompanyHRManagement.GUI.admin.Panel_main();
            this.panel_NhanVien = new CompanyHRManagement.GUI.admin.Panel_NhanVien();
            this.panel_Luong = new CompanyHRManagement.GUI.admin.Panel_Luong();
            this.panel_ChamCong1 = new CompanyHRManagement.GUI.admin.Panel_ChamCong();
            this.panel_Message1 = new CompanyHRManagement.GUI.admin.Panel_Message();
            this.panel_ThuongPhat = new CompanyHRManagement.GUI.admin.Panel_ThuongPhat();
            this.panel_PhongChucVu = new CompanyHRManagement.GUI.admin.Panel_PhongChucVu();
            this.sidebarPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2MessageDialog
            // 
            this.guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog.Caption = null;
            this.guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog.Parent = this;
            this.guna2MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog.Text = null;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.sidebarPanel.Controls.Add(this.guna2Button5);
            this.sidebarPanel.Controls.Add(this.btnDepPos);
            this.sidebarPanel.Controls.Add(this.guna2Button18);
            this.sidebarPanel.Controls.Add(this.btnDangXuat);
            this.sidebarPanel.Controls.Add(this.guna2Button12);
            this.sidebarPanel.Controls.Add(this.btnThuongPhat);
            this.sidebarPanel.Controls.Add(this.guna2Button6);
            this.sidebarPanel.Controls.Add(this.btnLuong);
            this.sidebarPanel.Controls.Add(this.guna2Button8);
            this.sidebarPanel.Controls.Add(this.btnTinNhan);
            this.sidebarPanel.Controls.Add(this.guna2Button4);
            this.sidebarPanel.Controls.Add(this.btnChamCong);
            this.sidebarPanel.Controls.Add(this.guna2Button2);
            this.sidebarPanel.Controls.Add(this.btnNhanVien);
            this.sidebarPanel.Controls.Add(this.guna2Button1);
            this.sidebarPanel.Controls.Add(this.guna2Panel1);
            this.sidebarPanel.Controls.Add(this.guna2HtmlLabel4);
            this.sidebarPanel.Controls.Add(this.guna2PictureBox1);
            this.sidebarPanel.Controls.Add(this.guna2HtmlLabel3);
            this.sidebarPanel.Controls.Add(this.btnTrangChu);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(231, 787);
            this.sidebarPanel.TabIndex = 0;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 20;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::CompanyHRManagement.Properties.Resources.room_total_icon;
            this.guna2Button5.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button5.Location = new System.Drawing.Point(21, 291);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(38, 36);
            this.guna2Button5.TabIndex = 49;
            // 
            // btnDepPos
            // 
            this.btnDepPos.BackColor = System.Drawing.Color.Transparent;
            this.btnDepPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepPos.FillColor = System.Drawing.Color.Transparent;
            this.btnDepPos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepPos.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDepPos.Location = new System.Drawing.Point(65, 282);
            this.btnDepPos.Name = "btnDepPos";
            this.btnDepPos.Size = new System.Drawing.Size(167, 64);
            this.btnDepPos.TabIndex = 48;
            this.btnDepPos.Text = "Phòng ban/ Chức vụ";
            this.btnDepPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDepPos.Click += new System.EventHandler(this.btnDepPos_Click);
            // 
            // guna2Button18
            // 
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 20;
            this.guna2Button18.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button18.ForeColor = System.Drawing.Color.White;
            this.guna2Button18.Image = global::CompanyHRManagement.Properties.Resources.logout;
            this.guna2Button18.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button18.Location = new System.Drawing.Point(21, 702);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(38, 36);
            this.guna2Button18.TabIndex = 47;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(12, 698);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(193, 40);
            this.btnDangXuat.TabIndex = 46;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // guna2Button12
            // 
            this.guna2Button12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button12.BorderRadius = 20;
            this.guna2Button12.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.Image = global::CompanyHRManagement.Properties.Resources.reward;
            this.guna2Button12.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button12.Location = new System.Drawing.Point(21, 548);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(38, 36);
            this.guna2Button12.TabIndex = 41;
            // 
            // btnThuongPhat
            // 
            this.btnThuongPhat.BackColor = System.Drawing.Color.Transparent;
            this.btnThuongPhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThuongPhat.FillColor = System.Drawing.Color.Transparent;
            this.btnThuongPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThuongPhat.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThuongPhat.Location = new System.Drawing.Point(39, 548);
            this.btnThuongPhat.Name = "btnThuongPhat";
            this.btnThuongPhat.Size = new System.Drawing.Size(193, 40);
            this.btnThuongPhat.TabIndex = 40;
            this.btnThuongPhat.Text = "Thưởng/Phạt";
            this.btnThuongPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThuongPhat.Click += new System.EventHandler(this.btnThuongPhat_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 20;
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = global::CompanyHRManagement.Properties.Resources.icons8_salary_32;
            this.guna2Button6.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button6.Location = new System.Drawing.Point(21, 478);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(38, 36);
            this.guna2Button6.TabIndex = 39;
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuong.FillColor = System.Drawing.Color.Transparent;
            this.btnLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuong.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLuong.Location = new System.Drawing.Point(39, 478);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(193, 40);
            this.btnLuong.TabIndex = 38;
            this.btnLuong.Text = "Tính Lương";
            this.btnLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 20;
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = global::CompanyHRManagement.Properties.Resources.chat;
            this.guna2Button8.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button8.Location = new System.Drawing.Point(21, 411);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(38, 36);
            this.guna2Button8.TabIndex = 37;
            // 
            // btnTinNhan
            // 
            this.btnTinNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnTinNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinNhan.FillColor = System.Drawing.Color.Transparent;
            this.btnTinNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTinNhan.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTinNhan.Location = new System.Drawing.Point(39, 415);
            this.btnTinNhan.Name = "btnTinNhan";
            this.btnTinNhan.Size = new System.Drawing.Size(193, 40);
            this.btnTinNhan.TabIndex = 36;
            this.btnTinNhan.Text = "Message";
            this.btnTinNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTinNhan.Click += new System.EventHandler(this.btnTinNhan_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::CompanyHRManagement.Properties.Resources.time;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(21, 352);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(38, 36);
            this.guna2Button4.TabIndex = 33;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCong.FillColor = System.Drawing.Color.Transparent;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnChamCong.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnChamCong.Location = new System.Drawing.Point(39, 352);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(193, 40);
            this.btnChamCong.TabIndex = 32;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::CompanyHRManagement.Properties.Resources.staff;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(21, 236);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(38, 36);
            this.guna2Button2.TabIndex = 31;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FillColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNhanVien.Location = new System.Drawing.Point(39, 236);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(193, 40);
            this.btnNhanVien.TabIndex = 30;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(21, 167);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(38, 36);
            this.guna2Button1.TabIndex = 29;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Controls.Add(this.btnCaiDat);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 93);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(196, 43);
            this.guna2Panel1.TabIndex = 28;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoEllipsis = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUsername.Location = new System.Drawing.Point(4, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 23);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "usernameeeeeeeeeeeee";
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.BorderRadius = 20;
            this.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaiDat.FillColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::CompanyHRManagement.Properties.Resources.setting;
            this.btnCaiDat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCaiDat.Location = new System.Drawing.Point(155, 4);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(38, 36);
            this.btnCaiDat.TabIndex = 28;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.LightBlue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 54);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(59, 22);
            this.guna2HtmlLabel4.TabIndex = 19;
            this.guna2HtmlLabel4.Text = "Manage";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CompanyHRManagement.Properties.Resources.staff_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(127, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(81, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(21, 24);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 29);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "ComHR";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FillColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTrangChu.Location = new System.Drawing.Point(39, 167);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(193, 40);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(443, 179);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(121, 33);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Phòng ban: ";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(22, 43);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(74, 22);
            this.guna2HtmlLabel5.TabIndex = 54;
            this.guna2HtmlLabel5.Text = "Nhân viên";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(317, 43);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlLabel6.TabIndex = 57;
            this.guna2HtmlLabel6.Text = "Quản lý chế độ";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(586, 43);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(147, 22);
            this.guna2HtmlLabel7.TabIndex = 58;
            this.guna2HtmlLabel7.Text = "Quản lý thử/thôi việc";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(924, 43);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel8.TabIndex = 59;
            this.guna2HtmlLabel8.Text = "Gửi Mail";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(733, 179);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(95, 33);
            this.guna2HtmlLabel9.TabIndex = 61;
            this.guna2HtmlLabel9.Text = "Bộ phận:";
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Location = new System.Drawing.Point(237, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1050, 787);
            this.panel_main.TabIndex = 1;
            // 
            // panel_NhanVien
            // 
            this.panel_NhanVien.Location = new System.Drawing.Point(237, 0);
            this.panel_NhanVien.Name = "panel_NhanVien";
            this.panel_NhanVien.Size = new System.Drawing.Size(1050, 787);
            this.panel_NhanVien.TabIndex = 2;
            // 
            // panel_Luong
            // 
            this.panel_Luong.Location = new System.Drawing.Point(237, 0);
            this.panel_Luong.Name = "panel_Luong";
            this.panel_Luong.Size = new System.Drawing.Size(1050, 787);
            this.panel_Luong.TabIndex = 3;
            // 
            // panel_ChamCong1
            // 
            this.panel_ChamCong1.Location = new System.Drawing.Point(237, 12);
            this.panel_ChamCong1.Name = "panel_ChamCong1";
            this.panel_ChamCong1.Size = new System.Drawing.Size(1050, 787);
            this.panel_ChamCong1.TabIndex = 4;
            // 
            // panel_Message1
            // 
            this.panel_Message1.CurrentUserId = 0;
            this.panel_Message1.Location = new System.Drawing.Point(237, 0);
            this.panel_Message1.Name = "panel_Message1";
            this.panel_Message1.Size = new System.Drawing.Size(1050, 787);
            this.panel_Message1.TabIndex = 5;
            // 
            // panel_ThuongPhat
            // 
            this.panel_ThuongPhat.Location = new System.Drawing.Point(238, 0);
            this.panel_ThuongPhat.Name = "panel_ThuongPhat";
            this.panel_ThuongPhat.Size = new System.Drawing.Size(1033, 787);
            this.panel_ThuongPhat.TabIndex = 6;
            // 
            // panel_PhongChucVu
            // 
            this.panel_PhongChucVu.Location = new System.Drawing.Point(237, 0);
            this.panel_PhongChucVu.Name = "panel_PhongChucVu";
            this.panel_PhongChucVu.Size = new System.Drawing.Size(1050, 787);
            this.panel_PhongChucVu.TabIndex = 7;
            // 
            // MainForm_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1275, 787);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_NhanVien);
            this.Controls.Add(this.panel_Luong);
            this.Controls.Add(this.panel_ChamCong1);
            this.Controls.Add(this.panel_Message1);
            this.Controls.Add(this.panel_ThuongPhat);
            this.Controls.Add(this.panel_PhongChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.MainForm_admin_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button btnTinNhan;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnChamCong;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button btnThuongPhat;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button btnLuong;
        private Timer timerClock;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Panel_main panel_main;
        private Panel_NhanVien panel_NhanVien;
        private Panel_Luong panel_Luong;
        private Panel_ChamCong panel_ChamCong1;
        private Panel_Message panel_Message1;
        private Label lblUsername;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog;
        private Panel_ThuongPhat panel_ThuongPhat;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnDepPos;
        private Panel_PhongChucVu panel_PhongChucVu;
    }
}
