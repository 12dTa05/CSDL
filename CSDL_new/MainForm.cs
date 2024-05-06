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
    public partial class MainForm : Form
    {
        private Form currentFormChild;

        public MainForm()
        {
            InitializeComponent();
            String ID_NV = ID_NV_text.Text;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(ID_NV_text.Text));
            label_top.Text = button1.Text.ToUpper();
            make_button_default();
            button1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            label_top.Text = button2.Text.ToUpper();
            make_button_default();
            button2.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            label_top.Text = button3.Text.ToUpper();
            make_button_default();
            button3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            label_top.Text = button1.Text.ToUpper();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            label_top.Text = button1.Text.ToUpper();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            label_top.Text = button1.Text.ToUpper();
        }

        private void make_button_default()
        {
            button1.BackColor = Color.Khaki;
            button2.BackColor = Color.Khaki;
            button3.BackColor = Color.Khaki;
            button4.BackColor = Color.Khaki;
            button5.BackColor = Color.Khaki;
            button6.BackColor = Color.Khaki;
        }
    }
}
