using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaiTapMau
{
    public partial class Form1 : Form
    {
        KhoaBus khoaBus;
        SqlConnection conn;
        DataTable bangLop;
        SqlDataAdapter adap;
        public Form1()
        {
            string str = (@"Data Source=LAPTOP-6HCL197P\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True");
            InitializeComponent();
            khoaBus = new KhoaBus();
            conn = new SqlConnection(str);
            bangLop = new DataTable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bangLop.Clear();
            cmbKhoa.Text = "";

        }
        private void load(string maKhoa)
        {
            DataView dataView = new DataView();
            dataView.RowFilter("MaKhoa='" + maKhoa + "");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = khoaBus.getAll();
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";

            cmbKhoa.SelectedIndex = 0;

            string strconn = "Select *from Lop where MaKhoa='"+cmbKhoa.SelectedValue+"'";
            adap = new SqlDataAdapter("select *from Khoa", conn);
            adap.Fill(bangLop);
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
        }

        private void Lop(object sender, EventArgs e)
        {

        }
    }
}
