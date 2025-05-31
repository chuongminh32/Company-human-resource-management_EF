using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.DAL._ado;

namespace CompanyHRManagement.BUS._ado
{
    public class PositionBUS
    {
        private PositionEF positionDAO = new PositionEF();
        public List<string> LayDSTenChucVu()
        {
            return positionDAO.GetPositionNames();
        }

        public string LayTenChucVuTheoID(int positionId)
        {
            return positionDAO.GetPositionNameById(positionId);
        }

        public List<Position> LayTatCaChucVu()
        {
            return positionDAO.GetAllPositions();
        }

        public bool ThemChucVu(string name, decimal baseSalary, ref string error)
        {
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                error = "Tên chức vụ không được để trống.";
                return false;
            }
            if (baseSalary < 0)
            {
                error = "Lương cơ bản phải lớn hơn hoặc bằng 0.";
                return false;
            }

            return positionDAO.InsertPosition(name, baseSalary, ref error);
        }

        public bool SuaChucVu(int id, string name, decimal baseSalary, ref string error)
        {
            error = string.Empty;

            if (id <= 0)
            {
                error = "ID chức vụ không hợp lệ.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                error = "Tên chức vụ không được để trống.";
                return false;
            }
            if (baseSalary < 0)
            {
                error = "Lương cơ bản phải lớn hơn hoặc bằng 0.";
                return false;
            }

            return positionDAO.UpdatePosition(id, name, baseSalary, ref error);
        }

        public bool XoaChucVu(int id, ref string error)
        {
            error = string.Empty;

            if (id <= 0)
            {
                error = "ID chức vụ không hợp lệ.";
                return false;
            }

            return positionDAO.DeletePosition(id, ref error);
        }
    }
}
