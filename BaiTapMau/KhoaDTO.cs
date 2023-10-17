using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMau
{
    public class KhoaDTO
    {
        //KhoaBus khoaBus = new KhoaBus();
        private string maKhoa;
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        
        private string tenKhoa;
        public string TenKhoa 
        { 
            get { return tenKhoa; }
            set { tenKhoa = value; } 
        }
        //public KhoaDTO()
        //{

        //}
        public KhoaDTO(string ma, string ten)
        {
            ma = MaKhoa;
            ten = TenKhoa;
        }
        //public List<KhoaDTO> getAll()
        //{
        //    return khoaBus.getAll();
        //}
    }
}
