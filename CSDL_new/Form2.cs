using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_new
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChungCuDataSet1.PHIEUDATPHONG' table. You can move, or remove it, as needed.
            this.pHIEUDATPHONGTableAdapter.Fill(this.qLChungCuDataSet1.PHIEUDATPHONG);
            // TODO: This line of code loads data into the 'qLChungCuDataSet1.PHIEUDATPHONG' table. You can move, or remove it, as needed.
            this.pHIEUDATPHONGTableAdapter.Fill(this.qLChungCuDataSet1.PHIEUDATPHONG);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                MAPDP_text.Text = cellValue.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();




        }
    }
}
