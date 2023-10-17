using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BaiTapMau
{
   public class KhoaBus
    {
        KhoaDAO khoaDAO;
        public KhoaBus()
        {
            khoaDAO = new KhoaDAO();
        }
        public List<KhoaDTO> getAll()
        {
            return khoaDAO.getAll();
        }
        public bool insert(KhoaDTO khoa)
        {
            return khoaDAO.insert(khoa);
        }
    }
}
