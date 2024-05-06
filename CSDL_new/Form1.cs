using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_new
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter da;
        private SqlConnection conn = new SqlConnection();
        BindingSource bsource = new BindingSource();
        DataSet ds = null;
        string sql ;
        String ID_NV_text; 

        public Form1()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["CSDL_new.Properties.Settings.QLChungCuConnectionString"].ConnectionString;
        }

        public Form1(String ID_NV)
        {
            ID_NV_text = ID_NV;
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["CSDL_new.Properties.Settings.QLChungCuConnectionString"].ConnectionString;
            //Update_Data(sql, conn, null);
        }

        private void Update_Data(String sql, SqlConnection conn, SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    
                    ds = new DataSet();
                    da.Fill(ds, "Orders");
                    bsource.DataSource = ds.Tables["Orders"];
                    dataGridView1.DataSource = bsource;
                   
                }
                conn.Close();
            }
        }


        private void LOC_button_Click(object sender, EventArgs e)
        {
            String SOPHONG = SOPHONG_text.Text;
            DateTime NGAYNHAN = DATE_nhanphong.Value.Date;
            DateTime NGAYTRA = DATE_traphong.Value.Date;

            sql = "exec LOC_button_Click @NGAYNHAN, @NGAYTRA ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NGAYTRA", SqlDbType.DateTime) { Value = NGAYTRA },
                new SqlParameter("@NGAYNHAN", SqlDbType.DateTime) { Value = NGAYNHAN }
            };

            Update_Data(sql, conn, parameters);
        }

        private void MaPDP()
        {
            String pdp = "declare @cnt_pdp int " +
                         "exec Count_PDP @cnt_pdp = @cnt_pdp output " +
                         "select @cnt_pdp";
            SqlCommand cmd = new SqlCommand(pdp, conn);
            conn.Open();
            String cnt = ((int)cmd.ExecuteScalar() + 1).ToString();
            //cnt = "PH" + cnt;
            MAPDP_text.Text = "PH" + cnt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                SOPHONG_text.Text = cellValue.ToString();
                GIAPHONG_text.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                MaPDP();
            }
        }

        private String MaKH()
        {
            String pdp = "select count(*) from dbo.KHACHHANG";
            SqlCommand cmd = new SqlCommand(pdp, conn);
            String cnt = ((int)cmd.ExecuteScalar() + 1).ToString();
            String makh = "KH" + cnt;
            return makh;
        }

        private String add_KH()
        {
            String sql = "insert into dbo.KHACHHANG values(@MAKH, @HOTEN, @GT, @NS, @CCCD, @DT, @DC)";
            String makh = MaKH();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKH", makh);
            cmd.Parameters.AddWithValue("@HOTEN", TENKH_text.Text);
            cmd.Parameters.AddWithValue("@GT", (GIOITINH_text.Text == "Nam" ? 0 : 1));
            cmd.Parameters.AddWithValue("@NS", NGAYSINH_text.Value.Date);
            cmd.Parameters.AddWithValue("@CCCD", CCCD_text.Text);
            cmd.Parameters.AddWithValue("@DT", SODT_text.Text);
            cmd.Parameters.AddWithValue("@DC", DIACHI_text.Text);

            cmd.ExecuteNonQuery();
            return makh;
        }

        private String KH_exist()
        {
            String sql = "select MAKH from KHACHHANG where CCCD = @CCCD";
            String makh;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CCCD", CCCD_text.Text);
            makh = cmd.ExecuteScalar()?.ToString();
            if(makh == "")
            {
                makh = add_KH();
            }
            return makh;

        }

        private void DATPHONG_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "insert into dbo.PHIEUDATPHONG values(@MAPDP, @TGDAT, @TGNHAN, @TGTRAPHONG, @SOPHONG, @MANV, @MAKH)";
            String makh = KH_exist();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAPDP", MAPDP_text.Text);
            cmd.Parameters.AddWithValue("@TGDAT", DATE_nhanphong.Value.Date);
            cmd.Parameters.AddWithValue("@TGNHAN", DATE_nhanphong.Value.Date);
            cmd.Parameters.AddWithValue("@TGTRAPHONG", DATE_traphong.Value.Date);
            cmd.Parameters.AddWithValue("@SOPHONG", SOPHONG_text.Text);
            cmd.Parameters.AddWithValue("@MANV", ID_NV_text);
            cmd.Parameters.AddWithValue("@MAKH", makh);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLChungCuDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLChungCuDataSet.PHONG);
            conn.Close();
        }

        private void RESET_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pHONGBindingSource;
        }
    }
}
