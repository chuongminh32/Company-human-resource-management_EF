using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CompanyHRManagement.BUS._ado;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_main : UserControl
    {
        public Panel_main()
        {
            InitializeComponent();
        }

        // Giả sử lblSoPhongBan là Label trên Form của bạn
        EmployeeBUS employeeBUS = new EmployeeBUS();
        DashBoard_adminBUS bus = new DashBoard_adminBUS();
        PositionBUS positionBUS = new PositionBUS();
        AttendanceBUS attendanceBUS = new AttendanceBUS();

        public void LoadDashBoard_Count(Employee emp)
        {

            int countDepartment = bus.GetDepartmentCount();  // Lấy số lượng phòng ban
            int countEmployees = bus.GetAllEmployeeCount();
            int countProbation = bus.GetProbationEmployeeCount();
            int countPosition = bus.GetPositionCount();
            decimal totalReward = bus.GetTotalRewardAmount() / 1000000;

            // Hiển thị lên label
            lblSoPhongBan.Text = countDepartment.ToString();
            lblTongNhanVien.Text = countEmployees.ToString();
            lblNhanVienThuViec.Text = countProbation.ToString();
            lblXinChao.Text = "Xin chào: " + emp.FullName;
            lblRole.Text = "Quyền hạn: " + positionBUS.LayTenChucVuTheoID((int)emp.PositionID);
            lblTongLuongThuong.Text = totalReward.ToString();

            // hiển thị ngày giờ 
            timerClock.Start();

            LoadCharts();
        }
        private void LoadCharts()
        {
            // Theo dõi tình hình đi làm toàn công ty
            DrawAttendanceChart();
            //  Quản lý nguồn nhân lực
            DrawStatusChart();
        }

        private void DrawAttendanceChart()
        {
            var data = attendanceBUS.GetAttendanceByMonth();
            chartAttendance.Series.Clear();

            Series series = new Series("Ngày công theo tháng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            foreach (var item in data)
            {
                series.Points.AddXY(item.MonthYear, item.WorkDays);
            }

            chartAttendance.Series.Add(series);
            chartAttendance.ChartAreas[0].AxisX.Title = "Tháng";
            chartAttendance.ChartAreas[0].AxisY.Title = "Ngày công";
        }
        private void DrawStatusChart()
        {
            var data = employeeBUS.GetEmployeeStatuses();
            chartStatus.Series.Clear();

            Series series = new Series("Trạng thái nhân viên")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (var item in data)
            {
                series.Points.AddXY(item.Status, item.Count);
            }

            chartStatus.Series.Add(series);
            chartStatus.Legends[0].Enabled = true;
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:  " + DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = "Today:  " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {

        }
    }
}
