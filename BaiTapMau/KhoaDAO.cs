using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BaiTapMau
{ 
    public class KhoaDAO
    { 
        SqlConnection conn;
        DataTable tableKhoa;
        SqlDataAdapter adapt;
     public KhoaDAO()
        {
            string strconn = (@"Data Source=LAPTOP-6HCL197P\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True");
            conn = new SqlConnection(strconn);
            tableKhoa = new DataTable();
            adapt = new SqlDataAdapter("Select *from Khoa", conn);
            adapt.Fill(tableKhoa);
        }

        public bool insert(KhoaDTO khoa)
        {
            DataRow newRow = tableKhoa.NewRow();
            newRow["MaKhoa"] = khoa.MaKhoa;
            newRow["TenKhoa"] = khoa.TenKhoa;
            tableKhoa.Rows.Add(newRow);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            int kq = adapt.Update(tableKhoa);
            if (kq != 0)
                return true;
            return false;
        }
        //Lay toan bo du lieu tu CSDL
        public List<KhoaDTO> getAll ()
        {
            List<KhoaDTO> lst = new List<KhoaDTO>();
            foreach(DataRow row in tableKhoa.Rows)
            {
                KhoaDTO khoa = new KhoaDTO(row["MaKhoa"].ToString(), row["TenKhoa"].ToString());
                lst.Add(khoa);
            }
            return lst;
        }

    }
}
