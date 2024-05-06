using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_new
{
    public partial class Form3 : Form
    {
        //gọi chuỗi kết nối ở file App.config bằng thuộc tính ConfigurationManager trong lớp System.Configuration

        public Form3()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChungCuDataSet2.PHIEUDATPHONG' table. You can move, or remove it, as needed.
            this.pHIEUDATPHONGTableAdapter.Fill(this.qLChungCuDataSet2.PHIEUDATPHONG);
            // TODO: This line of code loads data into the 'qLChungCuDataSet3.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qLChungCuDataSet3.DICHVU);
            // TODO: This line of code loads data into the 'qLChungCuDataSet2.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLChungCuDataSet2.KHACHHANG);
            // TODO: This line of code loads data into the 'qLChungCuDataSet2.PHIEUDATPHONG' table. You can move, or remove it, as needed.
            this.pHIEUDATPHONGTableAdapter.Fill(this.qLChungCuDataSet2.PHIEUDATPHONG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
