using CompanyHRManagement.GUI.admin;
using System.Drawing;
using System.Windows.Forms;

namespace CompanyHRManagement.GUI.user
{
    partial class MainForm_user
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanTin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNghiPhep = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.panelTrangChu_user = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.panelDashBoard_User = new Guna.UI2.WinForms.Guna2Panel();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPhongBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.panelInfoDB_admin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Button21 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button20 = new Guna.UI2.WinForms.Guna2Button();
            this.lblRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.lblXinChao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.panelThongTin_BangLuong = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvThuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvPhat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvLuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button23 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTinhTongLuong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTongLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.panelThongTin_CaNhan = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayVaoLam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.dtbNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.lblDaNghiViec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIDChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIDNhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbIDPhongBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThuViec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGioiTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.panelThongTin_ChamCong = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBangChamCong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongGioLam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel35 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoNgayCong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel37 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayHomNay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnChamCongHomNay = new Guna.UI2.WinForms.Guna2Button();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel66 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel71 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel72 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button19 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThongTinCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnBangLuongCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panelNghiPhep = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSua_NghiPhep = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvNghiPhep = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNgayKetThuc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayBatDau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoVaTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel33 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_ID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLyDo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel39 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel41 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel42 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDangKyNghiPhep = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelChat = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTinNhanGui = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvTinNhanNhan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.sidebarPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelTrangChu_user.SuspendLayout();
            this.panelDashBoard_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.panelInfoDB_admin.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelThongTin_BangLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.panelThongTin_CaNhan.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelThongTin_ChamCong.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).BeginInit();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.panelNghiPhep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiPhep)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinNhanGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinNhanNhan)).BeginInit();
            this.guna2Panel6.SuspendLayout();
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
            this.sidebarPanel.Controls.Add(this.guna2Button18);
            this.sidebarPanel.Controls.Add(this.btnDangXuat);
            this.sidebarPanel.Controls.Add(this.guna2Button8);
            this.sidebarPanel.Controls.Add(this.btnNhanTin);
            this.sidebarPanel.Controls.Add(this.guna2Button4);
            this.sidebarPanel.Controls.Add(this.btnNghiPhep);
            this.sidebarPanel.Controls.Add(this.guna2Button2);
            this.sidebarPanel.Controls.Add(this.btnThongTin);
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
            // guna2Button18
            // 
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 20;
            this.guna2Button18.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button18.ForeColor = System.Drawing.Color.White;
            this.guna2Button18.Image = global::CompanyHRManagement.Properties.Resources.logout;
            this.guna2Button18.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button18.Location = new System.Drawing.Point(24, 706);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(38, 36);
            this.guna2Button18.TabIndex = 49;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(15, 702);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(193, 40);
            this.btnDangXuat.TabIndex = 48;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 20;
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Image = global::CompanyHRManagement.Properties.Resources.chat;
            this.guna2Button8.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button8.Location = new System.Drawing.Point(21, 370);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(38, 36);
            this.guna2Button8.TabIndex = 37;
            // 
            // btnNhanTin
            // 
            this.btnNhanTin.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanTin.FillColor = System.Drawing.Color.Transparent;
            this.btnNhanTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanTin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNhanTin.Location = new System.Drawing.Point(12, 366);
            this.btnNhanTin.Name = "btnNhanTin";
            this.btnNhanTin.Size = new System.Drawing.Size(193, 40);
            this.btnNhanTin.TabIndex = 36;
            this.btnNhanTin.Text = "Nhắn tin";
            this.btnNhanTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNhanTin.Click += new System.EventHandler(this.btnNhanTin_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Image = global::CompanyHRManagement.Properties.Resources.relax;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(21, 301);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(38, 36);
            this.guna2Button4.TabIndex = 33;
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.Transparent;
            this.btnNghiPhep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNghiPhep.FillColor = System.Drawing.Color.Transparent;
            this.btnNghiPhep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNghiPhep.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNghiPhep.Location = new System.Drawing.Point(12, 297);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(193, 40);
            this.btnNghiPhep.TabIndex = 32;
            this.btnNghiPhep.Text = "Nghỉ phép";
            this.btnNghiPhep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNghiPhep.Click += new System.EventHandler(this.btnNghiPhep_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Image = global::CompanyHRManagement.Properties.Resources.info;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(21, 236);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(38, 36);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.FillColor = System.Drawing.Color.Transparent;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThongTin.Location = new System.Drawing.Point(12, 232);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(193, 40);
            this.btnThongTin.TabIndex = 30;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
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
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUsername.Location = new System.Drawing.Point(7, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 99;
            this.lblUsername.Text = "label1";
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
            this.btnCaiDat.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.SlateGray;
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
            this.btnTrangChu.Location = new System.Drawing.Point(12, 163);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(193, 40);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panelTrangChu_user
            // 
            this.panelTrangChu_user.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.panelTrangChu_user.Controls.Add(this.guna2Button26);
            this.panelTrangChu_user.Controls.Add(this.panelDashBoard_User);
            this.panelTrangChu_user.Controls.Add(this.panelInfoDB_admin);
            this.panelTrangChu_user.Location = new System.Drawing.Point(225, 0);
            this.panelTrangChu_user.Name = "panelTrangChu_user";
            this.panelTrangChu_user.Size = new System.Drawing.Size(1050, 787);
            this.panelTrangChu_user.TabIndex = 62;
            // 
            // guna2Button26
            // 
            this.guna2Button26.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button26.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button26.ForeColor = System.Drawing.Color.White;
            this.guna2Button26.Location = new System.Drawing.Point(25, 112);
            this.guna2Button26.Name = "guna2Button26";
            this.guna2Button26.Size = new System.Drawing.Size(1008, 45);
            this.guna2Button26.TabIndex = 57;
            this.guna2Button26.Text = "Thông tin chi tiết";
            this.guna2Button26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelDashBoard_User
            // 
            this.panelDashBoard_User.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDashBoard_User.Controls.Add(this.chartAttendance);
            this.panelDashBoard_User.Controls.Add(this.chartSalary);
            this.panelDashBoard_User.Controls.Add(this.guna2Panel4);
            this.panelDashBoard_User.Location = new System.Drawing.Point(25, 156);
            this.panelDashBoard_User.Name = "panelDashBoard_User";
            this.panelDashBoard_User.Size = new System.Drawing.Size(1008, 597);
            this.panelDashBoard_User.TabIndex = 56;
            // 
            // chartAttendance
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAttendance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAttendance.Legends.Add(legend1);
            this.chartAttendance.Location = new System.Drawing.Point(36, 271);
            this.chartAttendance.Name = "chartAttendance";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAttendance.Series.Add(series1);
            this.chartAttendance.Size = new System.Drawing.Size(534, 269);
            this.chartAttendance.TabIndex = 59;
            this.chartAttendance.Text = "chart1";
            // 
            // chartSalary
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSalary.Legends.Add(legend2);
            this.chartSalary.Location = new System.Drawing.Point(591, 16);
            this.chartSalary.Name = "chartSalary";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSalary.Series.Add(series2);
            this.chartSalary.Size = new System.Drawing.Size(414, 524);
            this.chartSalary.TabIndex = 58;
            this.chartSalary.Text = "chart1";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 5;
            this.guna2Panel4.Controls.Add(this.lblPhongBan);
            this.guna2Panel4.Controls.Add(this.lblChucVu);
            this.guna2Panel4.Controls.Add(this.lblHoTen);
            this.guna2Panel4.Controls.Add(this.guna2Button22);
            this.guna2Panel4.Location = new System.Drawing.Point(33, 29);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(534, 211);
            this.guna2Panel4.TabIndex = 57;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPhongBan.Location = new System.Drawing.Point(21, 155);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(125, 33);
            this.lblPhongBan.TabIndex = 64;
            this.lblPhongBan.Text = "Phòng ban: ";
            // 
            // lblChucVu
            // 
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblChucVu.Location = new System.Drawing.Point(21, 86);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(95, 33);
            this.lblChucVu.TabIndex = 62;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHoTen.Location = new System.Drawing.Point(21, 27);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(82, 33);
            this.lblHoTen.TabIndex = 48;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // guna2Button22
            // 
            this.guna2Button22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button22.BorderRadius = 10;
            this.guna2Button22.BorderThickness = 2;
            this.guna2Button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button22.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button22.ForeColor = System.Drawing.Color.White;
            this.guna2Button22.Image = global::CompanyHRManagement.Properties.Resources.staff_total_icon;
            this.guna2Button22.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button22.Location = new System.Drawing.Point(446, 7);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(69, 53);
            this.guna2Button22.TabIndex = 61;
            this.guna2Button22.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // panelInfoDB_admin
            // 
            this.panelInfoDB_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoDB_admin.Controls.Add(this.guna2VSeparator2);
            this.panelInfoDB_admin.Controls.Add(this.guna2Button21);
            this.panelInfoDB_admin.Controls.Add(this.guna2Button20);
            this.panelInfoDB_admin.Controls.Add(this.lblRole);
            this.panelInfoDB_admin.Controls.Add(this.lblTime);
            this.panelInfoDB_admin.Controls.Add(this.lblDate);
            this.panelInfoDB_admin.Controls.Add(this.guna2Button3);
            this.panelInfoDB_admin.Controls.Add(this.lblXinChao);
            this.panelInfoDB_admin.Controls.Add(this.guna2HtmlLabel1);
            this.panelInfoDB_admin.Controls.Add(this.guna2VSeparator1);
            this.panelInfoDB_admin.Location = new System.Drawing.Point(25, 3);
            this.panelInfoDB_admin.Name = "panelInfoDB_admin";
            this.panelInfoDB_admin.Size = new System.Drawing.Size(1008, 93);
            this.panelInfoDB_admin.TabIndex = 55;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(462, 17);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 56);
            this.guna2VSeparator2.TabIndex = 60;
            // 
            // guna2Button21
            // 
            this.guna2Button21.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button21.BorderRadius = 20;
            this.guna2Button21.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button21.ForeColor = System.Drawing.Color.White;
            this.guna2Button21.Image = global::CompanyHRManagement.Properties.Resources.admin;
            this.guna2Button21.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button21.Location = new System.Drawing.Point(691, 20);
            this.guna2Button21.Name = "guna2Button21";
            this.guna2Button21.Size = new System.Drawing.Size(69, 53);
            this.guna2Button21.TabIndex = 59;
            // 
            // guna2Button20
            // 
            this.guna2Button20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button20.BorderRadius = 20;
            this.guna2Button20.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button20.ForeColor = System.Drawing.Color.White;
            this.guna2Button20.Image = global::CompanyHRManagement.Properties.Resources.welcome;
            this.guna2Button20.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button20.Location = new System.Drawing.Point(387, 21);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(69, 53);
            this.guna2Button20.TabIndex = 58;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRole.Location = new System.Drawing.Point(478, 35);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(72, 30);
            this.lblRole.TabIndex = 57;
            this.lblRole.Text = "Vai trò: ";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTime.Location = new System.Drawing.Point(773, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 30);
            this.lblTime.TabIndex = 56;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDate.Location = new System.Drawing.Point(776, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 30);
            this.lblDate.TabIndex = 55;
            this.lblDate.Text = "Hôm nay: ";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::CompanyHRManagement.Properties.Resources.sun;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(936, 20);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(69, 53);
            this.guna2Button3.TabIndex = 29;
            // 
            // lblXinChao
            // 
            this.lblXinChao.BackColor = System.Drawing.Color.Transparent;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXinChao.Location = new System.Drawing.Point(16, 29);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(127, 39);
            this.lblXinChao.TabIndex = 54;
            this.lblXinChao.Text = "Xin chào :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(961, 46);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 48;
            this.guna2HtmlLabel1.Text = null;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(750, 18);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 56);
            this.guna2VSeparator1.TabIndex = 53;
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.panelThongTin_BangLuong);
            this.panelThongTin.Controls.Add(this.panelThongTin_CaNhan);
            this.panelThongTin.Controls.Add(this.panelThongTin_ChamCong);
            this.panelThongTin.Controls.Add(this.guna2Panel8);
            this.panelThongTin.Location = new System.Drawing.Point(225, 3);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1053, 784);
            this.panelThongTin.TabIndex = 28;
            this.panelThongTin.Visible = false;
            // 
            // panelThongTin_BangLuong
            // 
            this.panelThongTin_BangLuong.Controls.Add(this.dgvThuong);
            this.panelThongTin_BangLuong.Controls.Add(this.dgvPhat);
            this.panelThongTin_BangLuong.Controls.Add(this.dgvLuong);
            this.panelThongTin_BangLuong.Controls.Add(this.guna2Button23);
            this.panelThongTin_BangLuong.Controls.Add(this.guna2Button17);
            this.panelThongTin_BangLuong.Controls.Add(this.guna2Panel3);
            this.panelThongTin_BangLuong.Controls.Add(this.guna2HtmlLabel6);
            this.panelThongTin_BangLuong.Controls.Add(this.guna2Button12);
            this.panelThongTin_BangLuong.Controls.Add(this.guna2Button15);
            this.panelThongTin_BangLuong.Location = new System.Drawing.Point(16, 101);
            this.panelThongTin_BangLuong.Name = "panelThongTin_BangLuong";
            this.panelThongTin_BangLuong.Size = new System.Drawing.Size(1014, 671);
            this.panelThongTin_BangLuong.TabIndex = 73;
            // 
            // dgvThuong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuong.ColumnHeadersHeight = 4;
            this.dgvThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThuong.Location = new System.Drawing.Point(514, 356);
            this.dgvThuong.Name = "dgvThuong";
            this.dgvThuong.RowHeadersVisible = false;
            this.dgvThuong.RowHeadersWidth = 51;
            this.dgvThuong.RowTemplate.Height = 24;
            this.dgvThuong.Size = new System.Drawing.Size(457, 196);
            this.dgvThuong.TabIndex = 89;
            this.dgvThuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThuong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThuong.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvThuong.ThemeStyle.ReadOnly = false;
            this.dgvThuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThuong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvPhat
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPhat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhat.ColumnHeadersHeight = 4;
            this.dgvPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhat.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhat.Location = new System.Drawing.Point(3, 356);
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.RowHeadersVisible = false;
            this.dgvPhat.RowHeadersWidth = 51;
            this.dgvPhat.RowTemplate.Height = 24;
            this.dgvPhat.Size = new System.Drawing.Size(445, 196);
            this.dgvPhat.TabIndex = 88;
            this.dgvPhat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhat.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPhat.ThemeStyle.ReadOnly = false;
            this.dgvPhat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhat.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPhat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvLuong
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLuong.ColumnHeadersHeight = 4;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuong.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLuong.Location = new System.Drawing.Point(6, 43);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersVisible = false;
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(965, 267);
            this.dgvLuong.TabIndex = 87;
            this.dgvLuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLuong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLuong.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvLuong.ThemeStyle.ReadOnly = false;
            this.dgvLuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLuong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button23
            // 
            this.guna2Button23.BackColor = System.Drawing.Color.MediumAquamarine;
            this.guna2Button23.BorderRadius = 10;
            this.guna2Button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button23.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button23.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button23.ForeColor = System.Drawing.Color.Teal;
            this.guna2Button23.Location = new System.Drawing.Point(514, 316);
            this.guna2Button23.Name = "guna2Button23";
            this.guna2Button23.Size = new System.Drawing.Size(457, 40);
            this.guna2Button23.TabIndex = 86;
            this.guna2Button23.Text = "Thông tin thưởng";
            // 
            // guna2Button17
            // 
            this.guna2Button17.BackColor = System.Drawing.Color.LightSalmon;
            this.guna2Button17.BorderRadius = 10;
            this.guna2Button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button17.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button17.ForeColor = System.Drawing.Color.Red;
            this.guna2Button17.Location = new System.Drawing.Point(3, 316);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(445, 40);
            this.guna2Button17.TabIndex = 77;
            this.guna2Button17.Text = "Thông tin phạt";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.btnTinhTongLuong);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel3.Controls.Add(this.cbbNam);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel3.Controls.Add(this.cbbThang);
            this.guna2Panel3.Controls.Add(this.lblTongLuong);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel3.Location = new System.Drawing.Point(9, 560);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(840, 100);
            this.guna2Panel3.TabIndex = 83;
            // 
            // btnTinhTongLuong
            // 
            this.btnTinhTongLuong.BorderRadius = 10;
            this.btnTinhTongLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTongLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTinhTongLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhTongLuong.Location = new System.Drawing.Point(451, 42);
            this.btnTinhTongLuong.Name = "btnTinhTongLuong";
            this.btnTinhTongLuong.Size = new System.Drawing.Size(100, 40);
            this.btnTinhTongLuong.TabIndex = 84;
            this.btnTinhTongLuong.Text = "Tính";
            this.btnTinhTongLuong.Click += new System.EventHandler(this.btnTinhTongLuong_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(231, 16);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(41, 25);
            this.guna2HtmlLabel2.TabIndex = 85;
            this.guna2HtmlLabel2.Text = "Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNam.ItemHeight = 30;
            this.cbbNam.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbbNam.Location = new System.Drawing.Point(231, 46);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(140, 36);
            this.cbbNam.TabIndex = 84;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(12, 16);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(53, 25);
            this.guna2HtmlLabel9.TabIndex = 83;
            this.guna2HtmlLabel9.Text = "Tháng";
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbThang.ItemHeight = 30;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(12, 46);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(140, 36);
            this.cbbThang.TabIndex = 78;
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLuong.Location = new System.Drawing.Point(708, 46);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(55, 25);
            this.lblTongLuong.TabIndex = 82;
            this.lblTongLuong.Text = "0  VND";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(600, 46);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(102, 25);
            this.guna2HtmlLabel7.TabIndex = 81;
            this.guna2HtmlLabel7.Text = "Tổng lương:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(479, 356);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel6.TabIndex = 80;
            this.guna2HtmlLabel6.Text = null;
            // 
            // guna2Button12
            // 
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.Location = new System.Drawing.Point(6, 3);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(965, 40);
            this.guna2Button12.TabIndex = 71;
            this.guna2Button12.Text = "Thông tin lương cá nhân";
            this.guna2Button12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button15
            // 
            this.guna2Button15.BorderRadius = 10;
            this.guna2Button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button15.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.Black;
            this.guna2Button15.Location = new System.Drawing.Point(871, 561);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(100, 40);
            this.guna2Button15.TabIndex = 70;
            this.guna2Button15.Text = "Print";
            // 
            // panelThongTin_CaNhan
            // 
            this.panelThongTin_CaNhan.Controls.Add(this.btnReload);
            this.panelThongTin_CaNhan.Controls.Add(this.guna2Panel2);
            this.panelThongTin_CaNhan.Controls.Add(this.guna2Button10);
            this.panelThongTin_CaNhan.Location = new System.Drawing.Point(19, 98);
            this.panelThongTin_CaNhan.Name = "panelThongTin_CaNhan";
            this.panelThongTin_CaNhan.Size = new System.Drawing.Size(1019, 674);
            this.panelThongTin_CaNhan.TabIndex = 67;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 20;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = global::CompanyHRManagement.Properties.Resources.reload;
            this.btnReload.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReload.Location = new System.Drawing.Point(977, 26);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(38, 36);
            this.btnReload.TabIndex = 67;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel2.Controls.Add(this.txtDiaChi);
            this.guna2Panel2.Controls.Add(this.lblNgaySinh);
            this.guna2Panel2.Controls.Add(this.lblNgayVaoLam);
            this.guna2Panel2.Controls.Add(this.btnSua);
            this.guna2Panel2.Controls.Add(this.btnLamMoi);
            this.guna2Panel2.Controls.Add(this.dtbNgaySinh);
            this.guna2Panel2.Controls.Add(this.btnXuatExcel);
            this.guna2Panel2.Controls.Add(this.lblDaNghiViec);
            this.guna2Panel2.Controls.Add(this.lblIDChucVu);
            this.guna2Panel2.Controls.Add(this.lblIDNhanVien);
            this.guna2Panel2.Controls.Add(this.lbIDPhongBan);
            this.guna2Panel2.Controls.Add(this.lblThuViec);
            this.guna2Panel2.Controls.Add(this.txtSDT);
            this.guna2Panel2.Controls.Add(this.txtGioiTinh);
            this.guna2Panel2.Controls.Add(this.txtEmail);
            this.guna2Panel2.Controls.Add(this.txtTen);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel22);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel21);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel20);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel19);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel18);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel16);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Location = new System.Drawing.Point(6, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(965, 610);
            this.guna2Panel2.TabIndex = 72;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(133, 264);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 30);
            this.txtDiaChi.TabIndex = 96;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgaySinh.Location = new System.Drawing.Point(814, 274);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(26, 25);
            this.lblNgaySinh.TabIndex = 95;
            this.lblNgaySinh.Text = "ID:";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVaoLam.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(843, 171);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(26, 25);
            this.lblNgayVaoLam.TabIndex = 94;
            this.lblNgayVaoLam.Text = "ID:";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(69, 527);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(171, 40);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "Lưu thay đổi";
            this.btnSua.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(451, 530);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 69;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.Checked = true;
            this.dtbNgaySinh.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtbNgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtbNgaySinh.Location = new System.Drawing.Point(705, 304);
            this.dtbNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(200, 36);
            this.dtbNgaySinh.TabIndex = 93;
            this.dtbNgaySinh.Value = new System.DateTime(2025, 5, 13, 9, 11, 26, 348);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BorderRadius = 10;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(789, 527);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(120, 40);
            this.btnXuatExcel.TabIndex = 70;
            this.btnXuatExcel.Text = "Xuất Excel";
            // 
            // lblDaNghiViec
            // 
            this.lblDaNghiViec.BackColor = System.Drawing.Color.Transparent;
            this.lblDaNghiViec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaNghiViec.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDaNghiViec.Location = new System.Drawing.Point(820, 402);
            this.lblDaNghiViec.Name = "lblDaNghiViec";
            this.lblDaNghiViec.Size = new System.Drawing.Size(26, 25);
            this.lblDaNghiViec.TabIndex = 91;
            this.lblDaNghiViec.Text = "ID:";
            // 
            // lblIDChucVu
            // 
            this.lblIDChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblIDChucVu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDChucVu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIDChucVu.Location = new System.Drawing.Point(803, 72);
            this.lblIDChucVu.Name = "lblIDChucVu";
            this.lblIDChucVu.Size = new System.Drawing.Size(26, 25);
            this.lblIDChucVu.TabIndex = 90;
            this.lblIDChucVu.Text = "ID:";
            // 
            // lblIDNhanVien
            // 
            this.lblIDNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblIDNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNhanVien.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIDNhanVien.Location = new System.Drawing.Point(74, 72);
            this.lblIDNhanVien.Name = "lblIDNhanVien";
            this.lblIDNhanVien.Size = new System.Drawing.Size(26, 25);
            this.lblIDNhanVien.TabIndex = 89;
            this.lblIDNhanVien.Text = "ID:";
            // 
            // lbIDPhongBan
            // 
            this.lbIDPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lbIDPhongBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDPhongBan.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbIDPhongBan.Location = new System.Drawing.Point(547, 72);
            this.lbIDPhongBan.Name = "lbIDPhongBan";
            this.lbIDPhongBan.Size = new System.Drawing.Size(26, 25);
            this.lbIDPhongBan.TabIndex = 88;
            this.lbIDPhongBan.Text = "ID:";
            // 
            // lblThuViec
            // 
            this.lblThuViec.BackColor = System.Drawing.Color.Transparent;
            this.lblThuViec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuViec.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblThuViec.Location = new System.Drawing.Point(565, 171);
            this.lblThuViec.Name = "lblThuViec";
            this.lblThuViec.Size = new System.Drawing.Size(26, 25);
            this.lblThuViec.TabIndex = 87;
            this.lblThuViec.Text = "ID:";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(473, 264);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(175, 30);
            this.txtSDT.TabIndex = 86;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioiTinh.DefaultText = "";
            this.txtGioiTinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGioiTinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGioiTinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGioiTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.Location = new System.Drawing.Point(505, 402);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.PlaceholderText = "";
            this.txtGioiTinh.SelectedText = "";
            this.txtGioiTinh.Size = new System.Drawing.Size(71, 30);
            this.txtGioiTinh.TabIndex = 85;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(133, 402);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(245, 30);
            this.txtEmail.TabIndex = 84;
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(133, 166);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(245, 30);
            this.txtTen.TabIndex = 80;
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(705, 402);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(107, 25);
            this.guna2HtmlLabel22.TabIndex = 77;
            this.guna2HtmlLabel22.Text = "Đã nghỉ việc:";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel21.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(416, 171);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(120, 25);
            this.guna2HtmlLabel21.TabIndex = 76;
            this.guna2HtmlLabel21.Text = "Đang thử việc:";
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel20.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(705, 171);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(118, 25);
            this.guna2HtmlLabel20.TabIndex = 75;
            this.guna2HtmlLabel20.Text = "Ngày vào làm:";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(705, 72);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(92, 25);
            this.guna2HtmlLabel19.TabIndex = 74;
            this.guna2HtmlLabel19.Text = "ID chức vụ:";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(42, 402);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(52, 25);
            this.guna2HtmlLabel18.TabIndex = 73;
            this.guna2HtmlLabel18.Text = "Email:";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(42, 269);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(63, 25);
            this.guna2HtmlLabel16.TabIndex = 72;
            this.guna2HtmlLabel16.Text = "Địa chỉ:";
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(416, 269);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(41, 25);
            this.guna2HtmlLabel17.TabIndex = 71;
            this.guna2HtmlLabel17.Text = "SDT:";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(416, 402);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(78, 25);
            this.guna2HtmlLabel15.TabIndex = 69;
            this.guna2HtmlLabel15.Text = "Giới tính:";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(705, 273);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(87, 25);
            this.guna2HtmlLabel14.TabIndex = 68;
            this.guna2HtmlLabel14.Text = "Ngày sinh:";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(416, 72);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(118, 25);
            this.guna2HtmlLabel13.TabIndex = 67;
            this.guna2HtmlLabel13.Text = "ID phòng ban:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(42, 171);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(85, 25);
            this.guna2HtmlLabel12.TabIndex = 66;
            this.guna2HtmlLabel12.Text = "Họ và tên:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(42, 72);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(26, 25);
            this.guna2HtmlLabel5.TabIndex = 65;
            this.guna2HtmlLabel5.Text = "ID:";
            // 
            // guna2Button10
            // 
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Location = new System.Drawing.Point(6, 4);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(965, 40);
            this.guna2Button10.TabIndex = 71;
            this.guna2Button10.Text = "Thông tin chi tiết";
            this.guna2Button10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelThongTin_ChamCong
            // 
            this.panelThongTin_ChamCong.Controls.Add(this.guna2Panel9);
            this.panelThongTin_ChamCong.Controls.Add(this.guna2Button19);
            this.panelThongTin_ChamCong.Location = new System.Drawing.Point(16, 98);
            this.panelThongTin_ChamCong.Name = "panelThongTin_ChamCong";
            this.panelThongTin_ChamCong.Size = new System.Drawing.Size(1022, 668);
            this.panelThongTin_ChamCong.TabIndex = 75;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.White;
            this.guna2Panel9.Controls.Add(this.guna2Button14);
            this.guna2Panel9.Controls.Add(this.dgvBangChamCong);
            this.guna2Panel9.Controls.Add(this.guna2Panel7);
            this.guna2Panel9.Location = new System.Drawing.Point(6, 46);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(965, 605);
            this.guna2Panel9.TabIndex = 110;
            // 
            // guna2Button14
            // 
            this.guna2Button14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button14.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button14.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2Button14.Location = new System.Drawing.Point(405, 44);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(535, 45);
            this.guna2Button14.TabIndex = 112;
            this.guna2Button14.Text = "Lịch sử chấm công";
            // 
            // dgvBangChamCong
            // 
            this.dgvBangChamCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBangChamCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBangChamCong.ColumnHeadersHeight = 4;
            this.dgvBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangChamCong.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBangChamCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangChamCong.Location = new System.Drawing.Point(406, 89);
            this.dgvBangChamCong.Name = "dgvBangChamCong";
            this.dgvBangChamCong.ReadOnly = true;
            this.dgvBangChamCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangChamCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBangChamCong.RowHeadersVisible = false;
            this.dgvBangChamCong.RowHeadersWidth = 51;
            this.dgvBangChamCong.RowTemplate.Height = 24;
            this.dgvBangChamCong.Size = new System.Drawing.Size(536, 469);
            this.dgvBangChamCong.TabIndex = 111;
            this.dgvBangChamCong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangChamCong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBangChamCong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBangChamCong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBangChamCong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBangChamCong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangChamCong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangChamCong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBangChamCong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBangChamCong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangChamCong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBangChamCong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBangChamCong.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBangChamCong.ThemeStyle.ReadOnly = true;
            this.dgvBangChamCong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangChamCong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangChamCong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangChamCong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangChamCong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBangChamCong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangChamCong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel7.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.guna2Button13);
            this.guna2Panel7.Controls.Add(this.lblTongGioLam);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel35);
            this.guna2Panel7.Controls.Add(this.lblSoNgayCong);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel37);
            this.guna2Panel7.Controls.Add(this.lblTrangThai);
            this.guna2Panel7.Controls.Add(this.lblNgayHomNay);
            this.guna2Panel7.Controls.Add(this.btnChamCongHomNay);
            this.guna2Panel7.Controls.Add(this.lblID);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel66);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel71);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel72);
            this.guna2Panel7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Panel7.Location = new System.Drawing.Point(22, 50);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(348, 508);
            this.guna2Panel7.TabIndex = 110;
            // 
            // guna2Button13
            // 
            this.guna2Button13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button13.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button13.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2Button13.Location = new System.Drawing.Point(3, 3);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(342, 39);
            this.guna2Button13.TabIndex = 108;
            this.guna2Button13.Text = "Chấm công";
            // 
            // lblTongGioLam
            // 
            this.lblTongGioLam.BackColor = System.Drawing.Color.Transparent;
            this.lblTongGioLam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGioLam.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTongGioLam.Location = new System.Drawing.Point(250, 372);
            this.lblTongGioLam.Name = "lblTongGioLam";
            this.lblTongGioLam.Size = new System.Drawing.Size(23, 25);
            this.lblTongGioLam.TabIndex = 103;
            this.lblTongGioLam.Text = "26";
            // 
            // guna2HtmlLabel35
            // 
            this.guna2HtmlLabel35.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel35.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel35.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel35.Location = new System.Drawing.Point(43, 372);
            this.guna2HtmlLabel35.Name = "guna2HtmlLabel35";
            this.guna2HtmlLabel35.Size = new System.Drawing.Size(201, 25);
            this.guna2HtmlLabel35.TabIndex = 102;
            this.guna2HtmlLabel35.Text = "Tổng giờ làm tháng này: ";
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoNgayCong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayCong.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSoNgayCong.Location = new System.Drawing.Point(227, 292);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(23, 25);
            this.lblSoNgayCong.TabIndex = 101;
            this.lblSoNgayCong.Text = "26";
            // 
            // guna2HtmlLabel37
            // 
            this.guna2HtmlLabel37.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel37.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel37.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel37.Location = new System.Drawing.Point(43, 292);
            this.guna2HtmlLabel37.Name = "guna2HtmlLabel37";
            this.guna2HtmlLabel37.Size = new System.Drawing.Size(178, 25);
            this.guna2HtmlLabel37.TabIndex = 100;
            this.guna2HtmlLabel37.Text = "Tổng công tháng này: ";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTrangThai.Location = new System.Drawing.Point(140, 217);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 25);
            this.lblTrangThai.TabIndex = 99;
            this.lblTrangThai.Text = "chưa chấm";
            // 
            // lblNgayHomNay
            // 
            this.lblNgayHomNay.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayHomNay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHomNay.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNgayHomNay.Location = new System.Drawing.Point(173, 141);
            this.lblNgayHomNay.Name = "lblNgayHomNay";
            this.lblNgayHomNay.Size = new System.Drawing.Size(26, 25);
            this.lblNgayHomNay.TabIndex = 98;
            this.lblNgayHomNay.Text = "ID:";
            // 
            // btnChamCongHomNay
            // 
            this.btnChamCongHomNay.BorderRadius = 10;
            this.btnChamCongHomNay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCongHomNay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCongHomNay.ForeColor = System.Drawing.Color.White;
            this.btnChamCongHomNay.Location = new System.Drawing.Point(29, 438);
            this.btnChamCongHomNay.Name = "btnChamCongHomNay";
            this.btnChamCongHomNay.Size = new System.Drawing.Size(298, 40);
            this.btnChamCongHomNay.TabIndex = 68;
            this.btnChamCongHomNay.Text = "Check In";
            this.btnChamCongHomNay.Click += new System.EventHandler(this.btnChamCongHomNay_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblID.Location = new System.Drawing.Point(160, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 25);
            this.lblID.TabIndex = 89;
            this.lblID.Text = "ID:";
            // 
            // guna2HtmlLabel66
            // 
            this.guna2HtmlLabel66.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel66.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel66.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel66.Location = new System.Drawing.Point(43, 217);
            this.guna2HtmlLabel66.Name = "guna2HtmlLabel66";
            this.guna2HtmlLabel66.Size = new System.Drawing.Size(91, 25);
            this.guna2HtmlLabel66.TabIndex = 72;
            this.guna2HtmlLabel66.Text = "Trạng thái:";
            // 
            // guna2HtmlLabel71
            // 
            this.guna2HtmlLabel71.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel71.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel71.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel71.Location = new System.Drawing.Point(43, 140);
            this.guna2HtmlLabel71.Name = "guna2HtmlLabel71";
            this.guna2HtmlLabel71.Size = new System.Drawing.Size(124, 25);
            this.guna2HtmlLabel71.TabIndex = 66;
            this.guna2HtmlLabel71.Text = "Ngày hôm nay:";
            // 
            // guna2HtmlLabel72
            // 
            this.guna2HtmlLabel72.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel72.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel72.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel72.Location = new System.Drawing.Point(43, 78);
            this.guna2HtmlLabel72.Name = "guna2HtmlLabel72";
            this.guna2HtmlLabel72.Size = new System.Drawing.Size(111, 25);
            this.guna2HtmlLabel72.TabIndex = 65;
            this.guna2HtmlLabel72.Text = "ID Nhân viên:";
            // 
            // guna2Button19
            // 
            this.guna2Button19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button19.ForeColor = System.Drawing.Color.White;
            this.guna2Button19.Location = new System.Drawing.Point(6, 4);
            this.guna2Button19.Name = "guna2Button19";
            this.guna2Button19.Size = new System.Drawing.Size(965, 40);
            this.guna2Button19.TabIndex = 71;
            this.guna2Button19.Text = "Thông tin chấm công";
            this.guna2Button19.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.Controls.Add(this.btnThongTinCaNhan);
            this.guna2Panel8.Controls.Add(this.btnBangLuongCaNhan);
            this.guna2Panel8.Controls.Add(this.btnChamCong);
            this.guna2Panel8.Location = new System.Drawing.Point(22, 21);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(968, 86);
            this.guna2Panel8.TabIndex = 76;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.BorderRadius = 10;
            this.btnThongTinCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTinCaNhan.FillColor = System.Drawing.Color.Transparent;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(38, 20);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(193, 40);
            this.btnThongTinCaNhan.TabIndex = 73;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnBangLuongCaNhan
            // 
            this.btnBangLuongCaNhan.BorderRadius = 10;
            this.btnBangLuongCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBangLuongCaNhan.FillColor = System.Drawing.Color.Transparent;
            this.btnBangLuongCaNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangLuongCaNhan.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBangLuongCaNhan.Location = new System.Drawing.Point(386, 20);
            this.btnBangLuongCaNhan.Name = "btnBangLuongCaNhan";
            this.btnBangLuongCaNhan.Size = new System.Drawing.Size(193, 40);
            this.btnBangLuongCaNhan.TabIndex = 74;
            this.btnBangLuongCaNhan.Text = "Bảng lương cá nhân";
            this.btnBangLuongCaNhan.Click += new System.EventHandler(this.btnBangLuongCaNhan_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BorderRadius = 10;
            this.btnChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCong.FillColor = System.Drawing.Color.Transparent;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnChamCong.Location = new System.Drawing.Point(715, 20);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(193, 40);
            this.btnChamCong.TabIndex = 76;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog2.Caption = null;
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog2.Parent = this;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog2.Text = null;
            // 
            // panelNghiPhep
            // 
            this.panelNghiPhep.Controls.Add(this.btnSua_NghiPhep);
            this.panelNghiPhep.Controls.Add(this.guna2Button7);
            this.panelNghiPhep.Controls.Add(this.dgvNghiPhep);
            this.panelNghiPhep.Controls.Add(this.guna2Panel5);
            this.panelNghiPhep.Controls.Add(this.btnDangKyNghiPhep);
            this.panelNghiPhep.Controls.Add(this.guna2Button5);
            this.panelNghiPhep.Controls.Add(this.guna2HtmlLabel8);
            this.panelNghiPhep.Location = new System.Drawing.Point(209, 0);
            this.panelNghiPhep.Name = "panelNghiPhep";
            this.panelNghiPhep.Size = new System.Drawing.Size(1050, 784);
            this.panelNghiPhep.TabIndex = 77;
            // 
            // btnSua_NghiPhep
            // 
            this.btnSua_NghiPhep.BorderRadius = 10;
            this.btnSua_NghiPhep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua_NghiPhep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua_NghiPhep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua_NghiPhep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua_NghiPhep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua_NghiPhep.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_NghiPhep.ForeColor = System.Drawing.Color.White;
            this.btnSua_NghiPhep.Location = new System.Drawing.Point(22, 662);
            this.btnSua_NghiPhep.Name = "btnSua_NghiPhep";
            this.btnSua_NghiPhep.Size = new System.Drawing.Size(523, 45);
            this.btnSua_NghiPhep.TabIndex = 99;
            this.btnSua_NghiPhep.Text = "Sửa";
            this.btnSua_NghiPhep.Click += new System.EventHandler(this.btnSua_NghiPhep_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2Button7.Location = new System.Drawing.Point(25, 112);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(519, 40);
            this.guna2Button7.TabIndex = 98;
            this.guna2Button7.Text = "Lịch sử đăng kí";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvNghiPhep
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.dgvNghiPhep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNghiPhep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvNghiPhep.ColumnHeadersHeight = 4;
            this.dgvNghiPhep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNghiPhep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdit,
            this.btnDelete});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNghiPhep.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvNghiPhep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNghiPhep.Location = new System.Drawing.Point(26, 158);
            this.dgvNghiPhep.Name = "dgvNghiPhep";
            this.dgvNghiPhep.RowHeadersVisible = false;
            this.dgvNghiPhep.RowHeadersWidth = 51;
            this.dgvNghiPhep.RowTemplate.Height = 24;
            this.dgvNghiPhep.Size = new System.Drawing.Size(519, 475);
            this.dgvNghiPhep.TabIndex = 77;
            this.dgvNghiPhep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNghiPhep.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNghiPhep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNghiPhep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNghiPhep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNghiPhep.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNghiPhep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNghiPhep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNghiPhep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNghiPhep.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNghiPhep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNghiPhep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNghiPhep.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvNghiPhep.ThemeStyle.ReadOnly = false;
            this.dgvNghiPhep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNghiPhep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNghiPhep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNghiPhep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNghiPhep.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNghiPhep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNghiPhep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNghiPhep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNghiPhep_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Sửa";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "✏";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "❌";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.Controls.Add(this.lblNgayKetThuc);
            this.guna2Panel5.Controls.Add(this.lblNgayBatDau);
            this.guna2Panel5.Controls.Add(this.lblHoVaTen);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel5.Controls.Add(this.guna2Button6);
            this.guna2Panel5.Controls.Add(this.dtpNgayBatDau);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel33);
            this.guna2Panel5.Controls.Add(this.dtpNgayKetThuc);
            this.guna2Panel5.Controls.Add(this.lbl_ID);
            this.guna2Panel5.Controls.Add(this.txtLyDo);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel39);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel41);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel42);
            this.guna2Panel5.Location = new System.Drawing.Point(576, 120);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(443, 509);
            this.guna2Panel5.TabIndex = 73;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(162, 426);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(29, 25);
            this.lblNgayKetThuc.TabIndex = 101;
            this.lblNgayKetThuc.Text = "tên";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgayBatDau.Location = new System.Drawing.Point(156, 328);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(29, 25);
            this.lblNgayBatDau.TabIndex = 100;
            this.lblNgayBatDau.Text = "tên";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoVaTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHoVaTen.Location = new System.Drawing.Point(131, 137);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(29, 25);
            this.lblHoVaTen.TabIndex = 99;
            this.lblHoVaTen.Text = "tên";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(33, 137);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(85, 25);
            this.guna2HtmlLabel11.TabIndex = 98;
            this.guna2HtmlLabel11.Text = "Họ và tên:";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2Button6.Location = new System.Drawing.Point(0, 0);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(443, 40);
            this.guna2Button6.TabIndex = 50;
            this.guna2Button6.Text = "Đăng kí nghỉ phép";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(158, 365);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 36);
            this.dtpNgayBatDau.TabIndex = 97;
            this.dtpNgayBatDau.Value = new System.DateTime(2025, 5, 13, 9, 11, 26, 348);
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDau_ValueChanged);
            // 
            // guna2HtmlLabel33
            // 
            this.guna2HtmlLabel33.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel33.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel33.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel33.Location = new System.Drawing.Point(33, 328);
            this.guna2HtmlLabel33.Name = "guna2HtmlLabel33";
            this.guna2HtmlLabel33.Size = new System.Drawing.Size(117, 25);
            this.guna2HtmlLabel33.TabIndex = 96;
            this.guna2HtmlLabel33.Text = "Ngày bắt đầu:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(162, 457);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 36);
            this.dtpNgayKetThuc.TabIndex = 93;
            this.dtpNgayKetThuc.Value = new System.DateTime(2025, 5, 13, 9, 11, 26, 348);
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtpNgayKetThuc_ValueChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_ID.Location = new System.Drawing.Point(156, 83);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(26, 25);
            this.lbl_ID.TabIndex = 89;
            this.lbl_ID.Text = "ID:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLyDo.DefaultText = "";
            this.txtLyDo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLyDo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLyDo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLyDo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLyDo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLyDo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLyDo.Location = new System.Drawing.Point(35, 219);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.PlaceholderText = "";
            this.txtLyDo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyDo.SelectedText = "";
            this.txtLyDo.Size = new System.Drawing.Size(364, 60);
            this.txtLyDo.TabIndex = 80;
            // 
            // guna2HtmlLabel39
            // 
            this.guna2HtmlLabel39.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel39.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel39.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel39.Location = new System.Drawing.Point(35, 426);
            this.guna2HtmlLabel39.Name = "guna2HtmlLabel39";
            this.guna2HtmlLabel39.Size = new System.Drawing.Size(121, 25);
            this.guna2HtmlLabel39.TabIndex = 68;
            this.guna2HtmlLabel39.Text = "Ngày kết thúc:";
            // 
            // guna2HtmlLabel41
            // 
            this.guna2HtmlLabel41.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel41.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel41.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel41.Location = new System.Drawing.Point(35, 187);
            this.guna2HtmlLabel41.Name = "guna2HtmlLabel41";
            this.guna2HtmlLabel41.Size = new System.Drawing.Size(52, 25);
            this.guna2HtmlLabel41.TabIndex = 66;
            this.guna2HtmlLabel41.Text = "Lý do:";
            // 
            // guna2HtmlLabel42
            // 
            this.guna2HtmlLabel42.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel42.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel42.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel42.Location = new System.Drawing.Point(35, 84);
            this.guna2HtmlLabel42.Name = "guna2HtmlLabel42";
            this.guna2HtmlLabel42.Size = new System.Drawing.Size(115, 25);
            this.guna2HtmlLabel42.TabIndex = 65;
            this.guna2HtmlLabel42.Text = "Mã nhân viên:";
            // 
            // btnDangKyNghiPhep
            // 
            this.btnDangKyNghiPhep.BorderRadius = 10;
            this.btnDangKyNghiPhep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKyNghiPhep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyNghiPhep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyNghiPhep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKyNghiPhep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKyNghiPhep.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyNghiPhep.ForeColor = System.Drawing.Color.White;
            this.btnDangKyNghiPhep.Location = new System.Drawing.Point(576, 662);
            this.btnDangKyNghiPhep.Name = "btnDangKyNghiPhep";
            this.btnDangKyNghiPhep.Size = new System.Drawing.Size(443, 45);
            this.btnDangKyNghiPhep.TabIndex = 74;
            this.btnDangKyNghiPhep.Text = "Đăng kí";
            this.btnDangKyNghiPhep.Click += new System.EventHandler(this.btnDangKyNghiPhep_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(25, 48);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(997, 45);
            this.guna2Button5.TabIndex = 1;
            this.guna2Button5.Text = "Thông tin nghỉ phép";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(413, 264);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel8.TabIndex = 0;
            this.guna2HtmlLabel8.Text = null;
            // 
            // panelChat
            // 
            this.panelChat.BorderRadius = 10;
            this.panelChat.Controls.Add(this.guna2Button11);
            this.panelChat.Controls.Add(this.guna2Button9);
            this.panelChat.Controls.Add(this.dgvTinNhanGui);
            this.panelChat.Controls.Add(this.dgvTinNhanNhan);
            this.panelChat.Controls.Add(this.guna2Panel6);
            this.panelChat.Controls.Add(this.guna2Button16);
            this.panelChat.Location = new System.Drawing.Point(209, 3);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(1063, 772);
            this.panelChat.TabIndex = 1;
            // 
            // guna2Button11
            // 
            this.guna2Button11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2Button11.Location = new System.Drawing.Point(553, 437);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(481, 45);
            this.guna2Button11.TabIndex = 108;
            this.guna2Button11.Text = "Lịch sử gửi tin nhắn";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2Button9.Location = new System.Drawing.Point(29, 437);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(505, 45);
            this.guna2Button9.TabIndex = 107;
            this.guna2Button9.Text = "Tin nhắn mới";
            // 
            // dgvTinNhanGui
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanGui.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTinNhanGui.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTinNhanGui.ColumnHeadersHeight = 4;
            this.dgvTinNhanGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTinNhanGui.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTinNhanGui.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinNhanGui.Location = new System.Drawing.Point(554, 478);
            this.dgvTinNhanGui.Name = "dgvTinNhanGui";
            this.dgvTinNhanGui.RowHeadersVisible = false;
            this.dgvTinNhanGui.RowHeadersWidth = 51;
            this.dgvTinNhanGui.RowTemplate.Height = 24;
            this.dgvTinNhanGui.Size = new System.Drawing.Size(480, 285);
            this.dgvTinNhanGui.TabIndex = 107;
            this.dgvTinNhanGui.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanGui.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTinNhanGui.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTinNhanGui.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTinNhanGui.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTinNhanGui.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanGui.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinNhanGui.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTinNhanGui.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTinNhanGui.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTinNhanGui.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTinNhanGui.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTinNhanGui.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTinNhanGui.ThemeStyle.ReadOnly = false;
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinNhanGui.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTinNhanGui.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinNhanGui_CellClick);
            // 
            // dgvTinNhanNhan
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTinNhanNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTinNhanNhan.ColumnHeadersHeight = 4;
            this.dgvTinNhanNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTinNhanNhan.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvTinNhanNhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinNhanNhan.Location = new System.Drawing.Point(32, 478);
            this.dgvTinNhanNhan.Name = "dgvTinNhanNhan";
            this.dgvTinNhanNhan.RowHeadersVisible = false;
            this.dgvTinNhanNhan.RowHeadersWidth = 51;
            this.dgvTinNhanNhan.RowTemplate.Height = 24;
            this.dgvTinNhanNhan.Size = new System.Drawing.Size(502, 285);
            this.dgvTinNhanNhan.TabIndex = 106;
            this.dgvTinNhanNhan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanNhan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTinNhanNhan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTinNhanNhan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTinNhanNhan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTinNhanNhan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanNhan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinNhanNhan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTinNhanNhan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTinNhanNhan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTinNhanNhan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTinNhanNhan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTinNhanNhan.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTinNhanNhan.ThemeStyle.ReadOnly = false;
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTinNhanNhan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.White;
            this.guna2Panel6.Controls.Add(this.btnGui);
            this.guna2Panel6.Controls.Add(this.txtNoiDung);
            this.guna2Panel6.Controls.Add(this.cbbNhanVien);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel23);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel6.Location = new System.Drawing.Point(29, 90);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(1005, 329);
            this.guna2Panel6.TabIndex = 105;
            // 
            // btnGui
            // 
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(24, 265);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(950, 45);
            this.btnGui.TabIndex = 106;
            this.btnGui.Text = "Gửi ";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Location = new System.Drawing.Point(124, 113);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(850, 138);
            this.txtNoiDung.TabIndex = 105;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNhanVien.ItemHeight = 30;
            this.cbbNhanVien.Location = new System.Drawing.Point(124, 23);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(400, 36);
            this.cbbNhanVien.TabIndex = 103;
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(24, 113);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(94, 30);
            this.guna2HtmlLabel23.TabIndex = 104;
            this.guna2HtmlLabel23.Text = "Nội dung:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(24, 27);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(69, 30);
            this.guna2HtmlLabel10.TabIndex = 102;
            this.guna2HtmlLabel10.Text = "Gửi tới:";
            // 
            // guna2Button16
            // 
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.Location = new System.Drawing.Point(28, 47);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(1006, 45);
            this.guna2Button16.TabIndex = 101;
            this.guna2Button16.Text = "Chat";
            this.guna2Button16.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MainForm_user
            // 
            this.ClientSize = new System.Drawing.Size(1275, 787);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.panelTrangChu_user);
            this.Controls.Add(this.panelNghiPhep);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "MainForm_user";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelTrangChu_user.ResumeLayout(false);
            this.panelDashBoard_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.panelInfoDB_admin.ResumeLayout(false);
            this.panelInfoDB_admin.PerformLayout();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin_BangLuong.ResumeLayout(false);
            this.panelThongTin_BangLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.panelThongTin_CaNhan.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panelThongTin_ChamCong.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).EndInit();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.panelNghiPhep.ResumeLayout(false);
            this.panelNghiPhep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiPhep)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.panelChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinNhanGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinNhanNhan)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private Guna.UI2.WinForms.Guna2Panel panelThongTin;
        private Guna.UI2.WinForms.Guna2Panel panelTrangChu_user;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnNghiPhep;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Timer timerClock;
        private Guna.UI2.WinForms.Guna2Panel panelInfoDB_admin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblXinChao;
        private Guna.UI2.WinForms.Guna2Panel panelDashBoard_User;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRole;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2Button guna2Button26;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChucVu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhongBan;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnNhanTin;
        private Guna.UI2.WinForms.Guna2Panel panelThongTin_CaNhan;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayVaoLam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDaNghiViec;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDChucVu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbIDPhongBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThuViec;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Button btnChamCong;
        private Guna.UI2.WinForms.Guna2Button btnBangLuongCaNhan;
        private Guna.UI2.WinForms.Guna2Button btnThongTinCaNhan;
        private Guna.UI2.WinForms.Guna2Panel panelThongTin_BangLuong;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Panel panelThongTin_ChamCong;
        private Guna.UI2.WinForms.Guna2Button guna2Button19;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnTinhTongLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2Panel panelNghiPhep;
        private Guna.UI2.WinForms.Guna2Panel panelChat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnDangKyNghiPhep;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKetThuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ID;
        private Guna.UI2.WinForms.Guna2TextBox txtLyDo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel39;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel41;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel42;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBatDau;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel33;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNghiPhep;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoVaTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Label lblUsername;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayKetThuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayBatDau;
        private Guna.UI2.WinForms.Guna2Button btnSua_NghiPhep;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTinNhanGui;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTinNhanNhan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBangChamCong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongGioLam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel35;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoNgayCong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel37;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrangThai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayHomNay;
        private Guna.UI2.WinForms.Guna2Button btnChamCongHomNay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel66;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel71;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel72;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2Button guna2Button23;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLuong;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThuong;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhat;
    }
}
