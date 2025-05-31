using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class PositionEF
    {
        private CompanyHRManagementEntities context = new CompanyHRManagementEntities();

        // Lấy tên vai trò theo ID 
        public string GetPositionNameById(int positionId)
        {
            var position = context.Positions
                                  .FirstOrDefault(p => p.PositionID == positionId);
            return position?.PositionName ?? string.Empty;
        }

        // Lấy danh sách tên vị trí (dùng cho ComboBox)
        public List<string> GetPositionNames()
        {
            return context.Positions
                          .Select(p => p.PositionName)
                          .ToList();
        }

        // Lấy danh sách tất cả các vị trí
        public List<Position> GetAllPositions()
        {
            return context.Positions.ToList();
        }

        // Thêm vị trí mới
        public bool InsertPosition(string name, decimal baseSalary, ref string error)
        {
            try
            {
                var newPos = new Position
                {
                    PositionName = name,
                    BaseSalary = baseSalary
                };
                context.Positions.Add(newPos);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Cập nhật vị trí
        public bool UpdatePosition(int id, string name, decimal baseSalary, ref string error)
        {
            try
            {
                var pos = context.Positions.FirstOrDefault(p => p.PositionID == id);
                if (pos == null)
                {
                    error = "Không tìm thấy chức vụ.";
                    return false;
                }

                pos.PositionName = name;
                pos.BaseSalary = baseSalary;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Xóa vị trí nếu không có nhân viên đang giữ
        public bool DeletePosition(int id, ref string error)
        {
            try
            {
                var position = context.Positions.FirstOrDefault(p => p.PositionID == id);
                if (position == null)
                {
                    error = "Không tìm thấy chức vụ.";
                    return false;
                }

                bool hasEmployees = context.Employees.Any(e => e.PositionID == id);
                if (hasEmployees)
                {
                    error = "Không thể xóa chức vụ này vì vẫn còn nhân viên đang giữ chức vụ này.";
                    return false;
                }

                context.Positions.Remove(position);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
