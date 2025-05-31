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
        private PositionDAO positionDAO = new PositionDAO();
        public List<string> LayDSTenChucVu()
        {
            return positionDAO.GetPositionNames();
        }

        public string LayTenChucVuTheoID(int positionId)
        {
            return positionDAO.GetPositionNameById(positionId);
        }
    }
}
