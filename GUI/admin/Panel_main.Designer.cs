namespace CompanyHRManagement.GUI.admin
{
    partial class Panel_main
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongLuongThuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button27 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNhanVienThuViec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button25 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoPhongBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button24 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button23 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongNhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.panelInfoDB_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // chartStatus
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatus.Legends.Add(legend1);
            this.chartStatus.Location = new System.Drawing.Point(610, 501);
            this.chartStatus.Name = "chartStatus";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatus.Series.Add(series1);
            this.chartStatus.Size = new System.Drawing.Size(421, 268);
            this.chartStatus.TabIndex = 64;
            this.chartStatus.Text = "chart1";
            // 
            // chartAttendance
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAttendance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAttendance.Legends.Add(legend2);
            this.chartAttendance.Location = new System.Drawing.Point(610, 173);
            this.chartAttendance.Name = "chartAttendance";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAttendance.Series.Add(series2);
            this.chartAttendance.Size = new System.Drawing.Size(421, 302);
            this.chartAttendance.TabIndex = 63;
            this.chartAttendance.Text = "chart1";
            // 
            // guna2Button26
            // 
            this.guna2Button26.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button26.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button26.ForeColor = System.Drawing.Color.White;
            this.guna2Button26.Location = new System.Drawing.Point(3, 106);
            this.guna2Button26.Name = "guna2Button26";
            this.guna2Button26.Size = new System.Drawing.Size(1028, 45);
            this.guna2Button26.TabIndex = 62;
            this.guna2Button26.Text = "Thông tin chi tiết";
            this.guna2Button26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel3.Controls.Add(this.guna2Panel8);
            this.guna2Panel3.Controls.Add(this.guna2Panel7);
            this.guna2Panel3.Controls.Add(this.guna2Panel6);
            this.guna2Panel3.Controls.Add(this.guna2Panel5);
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Location = new System.Drawing.Point(3, 172);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(601, 596);
            this.guna2Panel3.TabIndex = 61;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel8.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel8.BorderRadius = 10;
            this.guna2Panel8.BorderThickness = 5;
            this.guna2Panel8.Controls.Add(this.lblTongLuongThuong);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel8.Controls.Add(this.guna2Button27);
            this.guna2Panel8.Location = new System.Drawing.Point(36, 382);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(525, 158);
            this.guna2Panel8.TabIndex = 63;
            // 
            // lblTongLuongThuong
            // 
            this.lblTongLuongThuong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongLuongThuong.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLuongThuong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTongLuongThuong.Location = new System.Drawing.Point(23, 17);
            this.lblTongLuongThuong.Name = "lblTongLuongThuong";
            this.lblTongLuongThuong.Size = new System.Drawing.Size(41, 56);
            this.lblTongLuongThuong.TabIndex = 62;
            this.lblTongLuongThuong.Text = "10";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(280, 33);
            this.guna2HtmlLabel15.TabIndex = 48;
            this.guna2HtmlLabel15.Text = "Tổng thưởng (triệu đồng)";
            // 
            // guna2Button27
            // 
            this.guna2Button27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button27.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button27.BorderRadius = 10;
            this.guna2Button27.BorderThickness = 1;
            this.guna2Button27.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button27.ForeColor = System.Drawing.Color.White;
            this.guna2Button27.Image = global::CompanyHRManagement.Properties.Resources.salary_total_icon;
            this.guna2Button27.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button27.Location = new System.Drawing.Point(441, 16);
            this.guna2Button27.Name = "guna2Button27";
            this.guna2Button27.Size = new System.Drawing.Size(69, 53);
            this.guna2Button27.TabIndex = 61;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel7.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel7.BorderRadius = 10;
            this.guna2Panel7.BorderThickness = 5;
            this.guna2Panel7.Controls.Add(this.lblNhanVienThuViec);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel7.Controls.Add(this.guna2Button25);
            this.guna2Panel7.Location = new System.Drawing.Point(308, 202);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(253, 158);
            this.guna2Panel7.TabIndex = 64;
            // 
            // lblNhanVienThuViec
            // 
            this.lblNhanVienThuViec.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVienThuViec.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienThuViec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNhanVienThuViec.Location = new System.Drawing.Point(23, 17);
            this.lblNhanVienThuViec.Name = "lblNhanVienThuViec";
            this.lblNhanVienThuViec.Size = new System.Drawing.Size(41, 56);
            this.lblNhanVienThuViec.TabIndex = 62;
            this.lblNhanVienThuViec.Text = "10";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(204, 33);
            this.guna2HtmlLabel14.TabIndex = 48;
            this.guna2HtmlLabel14.Text = "Nhân viên thử việc";
            // 
            // guna2Button25
            // 
            this.guna2Button25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button25.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button25.BorderRadius = 10;
            this.guna2Button25.BorderThickness = 1;
            this.guna2Button25.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button25.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button25.ForeColor = System.Drawing.Color.White;
            this.guna2Button25.Image = global::CompanyHRManagement.Properties.Resources.staff_intern_total_icon;
            this.guna2Button25.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button25.Location = new System.Drawing.Point(169, 16);
            this.guna2Button25.Name = "guna2Button25";
            this.guna2Button25.Size = new System.Drawing.Size(69, 53);
            this.guna2Button25.TabIndex = 61;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel6.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.BorderThickness = 5;
            this.guna2Panel6.Controls.Add(this.lblSoPhongBan);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel6.Controls.Add(this.guna2Button24);
            this.guna2Panel6.Location = new System.Drawing.Point(308, 16);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(253, 158);
            this.guna2Panel6.TabIndex = 63;
            // 
            // lblSoPhongBan
            // 
            this.lblSoPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lblSoPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongBan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSoPhongBan.Location = new System.Drawing.Point(23, 17);
            this.lblSoPhongBan.Name = "lblSoPhongBan";
            this.lblSoPhongBan.Size = new System.Drawing.Size(41, 56);
            this.lblSoPhongBan.TabIndex = 62;
            this.lblSoPhongBan.Text = "10";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(152, 33);
            this.guna2HtmlLabel13.TabIndex = 48;
            this.guna2HtmlLabel13.Text = "Số phòng ban";
            // 
            // guna2Button24
            // 
            this.guna2Button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button24.BorderRadius = 10;
            this.guna2Button24.BorderThickness = 1;
            this.guna2Button24.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button24.ForeColor = System.Drawing.Color.White;
            this.guna2Button24.Image = global::CompanyHRManagement.Properties.Resources.room_total_icon;
            this.guna2Button24.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button24.Location = new System.Drawing.Point(169, 16);
            this.guna2Button24.Name = "guna2Button24";
            this.guna2Button24.Size = new System.Drawing.Size(69, 53);
            this.guna2Button24.TabIndex = 61;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 5;
            this.guna2Panel5.Controls.Add(this.lblSoChucVu);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel5.Controls.Add(this.guna2Button23);
            this.guna2Panel5.Location = new System.Drawing.Point(36, 202);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(253, 158);
            this.guna2Panel5.TabIndex = 62;
            // 
            // lblSoChucVu
            // 
            this.lblSoChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblSoChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoChucVu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSoChucVu.Location = new System.Drawing.Point(23, 17);
            this.lblSoChucVu.Name = "lblSoChucVu";
            this.lblSoChucVu.Size = new System.Drawing.Size(41, 56);
            this.lblSoChucVu.TabIndex = 62;
            this.lblSoChucVu.Text = "10";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(119, 33);
            this.guna2HtmlLabel11.TabIndex = 48;
            this.guna2HtmlLabel11.Text = "Số chức vụ ";
            // 
            // guna2Button23
            // 
            this.guna2Button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button23.BorderRadius = 10;
            this.guna2Button23.BorderThickness = 1;
            this.guna2Button23.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button23.ForeColor = System.Drawing.Color.White;
            this.guna2Button23.Image = global::CompanyHRManagement.Properties.Resources.rank_total_icon;
            this.guna2Button23.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button23.Location = new System.Drawing.Point(169, 16);
            this.guna2Button23.Name = "guna2Button23";
            this.guna2Button23.Size = new System.Drawing.Size(69, 53);
            this.guna2Button23.TabIndex = 61;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 5;
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel4.Controls.Add(this.guna2Button22);
            this.guna2Panel4.Controls.Add(this.lblTongNhanVien);
            this.guna2Panel4.Location = new System.Drawing.Point(36, 16);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(253, 158);
            this.guna2Panel4.TabIndex = 57;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(169, 33);
            this.guna2HtmlLabel10.TabIndex = 48;
            this.guna2HtmlLabel10.Text = "Tổng nhân viên ";
            // 
            // guna2Button22
            // 
            this.guna2Button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button22.BorderRadius = 10;
            this.guna2Button22.BorderThickness = 1;
            this.guna2Button22.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button22.ForeColor = System.Drawing.Color.White;
            this.guna2Button22.Image = global::CompanyHRManagement.Properties.Resources.staff_total_icon;
            this.guna2Button22.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button22.Location = new System.Drawing.Point(169, 16);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(69, 53);
            this.guna2Button22.TabIndex = 61;
            this.guna2Button22.Click += new System.EventHandler(this.guna2Button22_Click);
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNhanVien.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTongNhanVien.Location = new System.Drawing.Point(23, 16);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.Size = new System.Drawing.Size(41, 56);
            this.lblTongNhanVien.TabIndex = 58;
            this.lblTongNhanVien.Text = "10";
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
            this.panelInfoDB_admin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfoDB_admin.Location = new System.Drawing.Point(2, 7);
            this.panelInfoDB_admin.Name = "panelInfoDB_admin";
            this.panelInfoDB_admin.Size = new System.Drawing.Size(1029, 93);
            this.panelInfoDB_admin.TabIndex = 60;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(505, 20);
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
            this.guna2Button21.Location = new System.Drawing.Point(725, 21);
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
            this.guna2Button20.Location = new System.Drawing.Point(430, 23);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(69, 53);
            this.guna2Button20.TabIndex = 58;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.SlateGray;
            this.lblRole.Location = new System.Drawing.Point(521, 32);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(62, 27);
            this.lblRole.TabIndex = 57;
            this.lblRole.Text = "Vai trò: ";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTime.Location = new System.Drawing.Point(811, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 27);
            this.lblTime.TabIndex = 56;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDate.Location = new System.Drawing.Point(811, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 27);
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
            this.guna2Button3.Location = new System.Drawing.Point(961, 20);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(69, 53);
            this.guna2Button3.TabIndex = 29;
            // 
            // lblXinChao
            // 
            this.lblXinChao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXinChao.BackColor = System.Drawing.Color.Transparent;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXinChao.Location = new System.Drawing.Point(12, 32);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(108, 33);
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
            this.guna2VSeparator1.Location = new System.Drawing.Point(784, 18);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 56);
            this.guna2VSeparator1.TabIndex = 53;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // Panel_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.chartStatus);
            this.Controls.Add(this.chartAttendance);
            this.Controls.Add(this.guna2Button26);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panelInfoDB_admin);
            this.Name = "Panel_main";
            this.Size = new System.Drawing.Size(1035, 787);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.panelInfoDB_admin.ResumeLayout(false);
            this.panelInfoDB_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
        private Guna.UI2.WinForms.Guna2Button guna2Button26;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongLuongThuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2Button guna2Button27;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNhanVienThuViec;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2Button guna2Button25;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoPhongBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Button guna2Button24;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoChucVu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Button guna2Button23;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongNhanVien;
        private Guna.UI2.WinForms.Guna2Panel panelInfoDB_admin;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblXinChao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Timer timerClock;
    }
}
