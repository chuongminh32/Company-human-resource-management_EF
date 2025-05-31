namespace CompanyHRManagement.GUI.admin
{
    partial class Panel_Message
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.lblRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGuiTN = new Guna.UI2.WinForms.Guna2Button();
            this.cbReceiver = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtND = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvMess = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMess)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button26
            // 
            this.guna2Button26.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button26.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button26.ForeColor = System.Drawing.Color.White;
            this.guna2Button26.Location = new System.Drawing.Point(0, 12);
            this.guna2Button26.Name = "guna2Button26";
            this.guna2Button26.Size = new System.Drawing.Size(1050, 45);
            this.guna2Button26.TabIndex = 58;
            this.guna2Button26.Text = "Chat";
            this.guna2Button26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRole.Location = new System.Drawing.Point(12, 17);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(74, 30);
            this.lblRole.TabIndex = 59;
            this.lblRole.Text = "Gửi tới:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel1.Controls.Add(this.btnGuiTN);
            this.guna2Panel1.Controls.Add(this.cbReceiver);
            this.guna2Panel1.Controls.Add(this.txtND);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.lblRole);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1050, 303);
            this.guna2Panel1.TabIndex = 60;
            // 
            // btnGuiTN
            // 
            this.btnGuiTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuiTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuiTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuiTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuiTN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiTN.ForeColor = System.Drawing.Color.White;
            this.btnGuiTN.Location = new System.Drawing.Point(3, 254);
            this.btnGuiTN.Name = "btnGuiTN";
            this.btnGuiTN.Size = new System.Drawing.Size(1044, 34);
            this.btnGuiTN.TabIndex = 89;
            this.btnGuiTN.Text = "Gửi";
            this.btnGuiTN.Click += new System.EventHandler(this.btnGuiTN_Click);
            // 
            // cbReceiver
            // 
            this.cbReceiver.BackColor = System.Drawing.Color.Transparent;
            this.cbReceiver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReceiver.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReceiver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReceiver.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbReceiver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbReceiver.ItemHeight = 30;
            this.cbReceiver.Location = new System.Drawing.Point(122, 15);
            this.cbReceiver.Name = "cbReceiver";
            this.cbReceiver.Size = new System.Drawing.Size(528, 36);
            this.cbReceiver.TabIndex = 62;
            // 
            // txtND
            // 
            this.txtND.BackColor = System.Drawing.Color.White;
            this.txtND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtND.DefaultText = "";
            this.txtND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtND.Location = new System.Drawing.Point(123, 70);
            this.txtND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.PlaceholderText = "";
            this.txtND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtND.SelectedText = "";
            this.txtND.Size = new System.Drawing.Size(851, 167);
            this.txtND.TabIndex = 61;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 73);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 30);
            this.guna2HtmlLabel1.TabIndex = 60;
            this.guna2HtmlLabel1.Text = "Nội dung:";
            // 
            // dgvMess
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMess.ColumnHeadersHeight = 40;
            this.dgvMess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMess.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMess.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMess.Location = new System.Drawing.Point(0, 410);
            this.dgvMess.Name = "dgvMess";
            this.dgvMess.RowHeadersVisible = false;
            this.dgvMess.RowHeadersWidth = 51;
            this.dgvMess.RowTemplate.Height = 24;
            this.dgvMess.Size = new System.Drawing.Size(1050, 374);
            this.dgvMess.TabIndex = 62;
            this.dgvMess.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMess.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMess.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMess.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMess.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMess.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMess.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMess.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMess.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMess.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvMess.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMess.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMess.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMess.ThemeStyle.ReadOnly = false;
            this.dgvMess.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMess.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMess.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvMess.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMess.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMess.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMess.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSTin_CellClick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button2.Location = new System.Drawing.Point(3, 359);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(1055, 45);
            this.guna2Button2.TabIndex = 64;
            this.guna2Button2.Text = "Lịch sử tin nhắn";
            // 
            // Panel_Message
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.dgvMess);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Button26);
            this.Name = "Panel_Message";
            this.Size = new System.Drawing.Size(1050, 787);
            this.Load += new System.EventHandler(this.Panel_Message_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button26;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRole;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtND;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbReceiver;
        private Guna.UI2.WinForms.Guna2Button btnGuiTN;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMess;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
