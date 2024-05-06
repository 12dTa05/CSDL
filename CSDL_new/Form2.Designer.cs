namespace CSDL_new
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MAPH_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HUYPHONG_button = new System.Windows.Forms.Button();
            this.GIOITINH_text = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LIDO_text = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SODT_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CCCD_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TENKH_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MAPDP_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LOC_button = new System.Windows.Forms.Button();
            this.TIMPHONG_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qLChungCuDataSet1 = new CSDL_new.QLChungCuDataSet1();
            this.pHIEUDATPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATPHONGTableAdapter = new CSDL_new.QLChungCuDataSet1TableAdapters.PHIEUDATPHONGTableAdapter();
            this.mAPDPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGNHANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGTRAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLChungCuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATPHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.MAPH_text);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.HUYPHONG_button);
            this.panel4.Controls.Add(this.GIOITINH_text);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.LIDO_text);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.SODT_text);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.CCCD_text);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.TENKH_text);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.MAPDP_text);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 499);
            this.panel4.TabIndex = 2;
            // 
            // MAPH_text
            // 
            this.MAPH_text.Location = new System.Drawing.Point(546, 279);
            this.MAPH_text.Name = "MAPH_text";
            this.MAPH_text.Size = new System.Drawing.Size(226, 22);
            this.MAPH_text.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã Hủy";
            // 
            // HUYPHONG_button
            // 
            this.HUYPHONG_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HUYPHONG_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUYPHONG_button.Location = new System.Drawing.Point(847, 364);
            this.HUYPHONG_button.Name = "HUYPHONG_button";
            this.HUYPHONG_button.Size = new System.Drawing.Size(89, 57);
            this.HUYPHONG_button.TabIndex = 21;
            this.HUYPHONG_button.Text = "Hủy phòng";
            this.HUYPHONG_button.UseVisualStyleBackColor = true;
            // 
            // GIOITINH_text
            // 
            this.GIOITINH_text.FormattingEnabled = true;
            this.GIOITINH_text.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GIOITINH_text.Location = new System.Drawing.Point(130, 376);
            this.GIOITINH_text.Name = "GIOITINH_text";
            this.GIOITINH_text.Size = new System.Drawing.Size(226, 24);
            this.GIOITINH_text.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Giới tính";
            // 
            // LIDO_text
            // 
            this.LIDO_text.Location = new System.Drawing.Point(129, 428);
            this.LIDO_text.Multiline = true;
            this.LIDO_text.Name = "LIDO_text";
            this.LIDO_text.Size = new System.Drawing.Size(644, 79);
            this.LIDO_text.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Lí do";
            // 
            // SODT_text
            // 
            this.SODT_text.Location = new System.Drawing.Point(548, 377);
            this.SODT_text.Name = "SODT_text";
            this.SODT_text.Size = new System.Drawing.Size(226, 22);
            this.SODT_text.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(459, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Số ĐT";
            // 
            // CCCD_text
            // 
            this.CCCD_text.Location = new System.Drawing.Point(547, 326);
            this.CCCD_text.Name = "CCCD_text";
            this.CCCD_text.Size = new System.Drawing.Size(226, 22);
            this.CCCD_text.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(458, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "CCCD";
            // 
            // TENKH_text
            // 
            this.TENKH_text.Location = new System.Drawing.Point(130, 327);
            this.TENKH_text.Name = "TENKH_text";
            this.TENKH_text.Size = new System.Drawing.Size(226, 22);
            this.TENKH_text.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên KH";
            // 
            // MAPDP_text
            // 
            this.MAPDP_text.Location = new System.Drawing.Point(130, 279);
            this.MAPDP_text.Name = "MAPDP_text";
            this.MAPDP_text.Size = new System.Drawing.Size(226, 22);
            this.MAPDP_text.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã PDP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPDPDataGridViewTextBoxColumn,
            this.tGNHANDataGridViewTextBoxColumn,
            this.tGTRAPHONGDataGridViewTextBoxColumn,
            this.sOPHONGDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.pHIEUDATPHONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 165);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LOC_button);
            this.panel5.Controls.Add(this.TIMPHONG_text);
            this.panel5.Location = new System.Drawing.Point(103, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(860, 73);
            this.panel5.TabIndex = 2;
            // 
            // LOC_button
            // 
            this.LOC_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOC_button.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOC_button.ForeColor = System.Drawing.Color.Goldenrod;
            this.LOC_button.Location = new System.Drawing.Point(658, 17);
            this.LOC_button.Name = "LOC_button";
            this.LOC_button.Size = new System.Drawing.Size(79, 36);
            this.LOC_button.TabIndex = 7;
            this.LOC_button.Text = "Lọc";
            this.LOC_button.UseVisualStyleBackColor = true;
            // 
            // TIMPHONG_text
            // 
            this.TIMPHONG_text.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIMPHONG_text.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TIMPHONG_text.Location = new System.Drawing.Point(6, 22);
            this.TIMPHONG_text.Name = "TIMPHONG_text";
            this.TIMPHONG_text.Size = new System.Drawing.Size(582, 28);
            this.TIMPHONG_text.TabIndex = 2;
            this.TIMPHONG_text.Text = "                 Nhập mã đặt phòng (hoặc mã KH)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(4, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm phòng";
            // 
            // qLChungCuDataSet1
            // 
            this.qLChungCuDataSet1.DataSetName = "QLChungCuDataSet1";
            this.qLChungCuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUDATPHONGBindingSource
            // 
            this.pHIEUDATPHONGBindingSource.DataMember = "PHIEUDATPHONG";
            this.pHIEUDATPHONGBindingSource.DataSource = this.qLChungCuDataSet1;
            // 
            // pHIEUDATPHONGTableAdapter
            // 
            this.pHIEUDATPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // mAPDPDataGridViewTextBoxColumn
            // 
            this.mAPDPDataGridViewTextBoxColumn.DataPropertyName = "MAPDP";
            this.mAPDPDataGridViewTextBoxColumn.HeaderText = "MAPDP";
            this.mAPDPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAPDPDataGridViewTextBoxColumn.Name = "mAPDPDataGridViewTextBoxColumn";
            this.mAPDPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAPDPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGNHANDataGridViewTextBoxColumn
            // 
            this.tGNHANDataGridViewTextBoxColumn.DataPropertyName = "TGNHAN";
            this.tGNHANDataGridViewTextBoxColumn.HeaderText = "TGNHAN";
            this.tGNHANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGNHANDataGridViewTextBoxColumn.Name = "tGNHANDataGridViewTextBoxColumn";
            this.tGNHANDataGridViewTextBoxColumn.ReadOnly = true;
            this.tGNHANDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGTRAPHONGDataGridViewTextBoxColumn
            // 
            this.tGTRAPHONGDataGridViewTextBoxColumn.DataPropertyName = "TGTRAPHONG";
            this.tGTRAPHONGDataGridViewTextBoxColumn.HeaderText = "TGTRAPHONG";
            this.tGTRAPHONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGTRAPHONGDataGridViewTextBoxColumn.Name = "tGTRAPHONGDataGridViewTextBoxColumn";
            this.tGTRAPHONGDataGridViewTextBoxColumn.ReadOnly = true;
            this.tGTRAPHONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOPHONGDataGridViewTextBoxColumn
            // 
            this.sOPHONGDataGridViewTextBoxColumn.DataPropertyName = "SOPHONG";
            this.sOPHONGDataGridViewTextBoxColumn.HeaderText = "SOPHONG";
            this.sOPHONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOPHONGDataGridViewTextBoxColumn.Name = "sOPHONGDataGridViewTextBoxColumn";
            this.sOPHONGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOPHONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 499);
            this.Controls.Add(this.panel4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLChungCuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATPHONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox MAPH_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button HUYPHONG_button;
        private System.Windows.Forms.ComboBox GIOITINH_text;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LIDO_text;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SODT_text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CCCD_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TENKH_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MAPDP_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button LOC_button;
        private System.Windows.Forms.TextBox TIMPHONG_text;
        private System.Windows.Forms.Label label5;
        private QLChungCuDataSet1 qLChungCuDataSet1;
        private System.Windows.Forms.BindingSource pHIEUDATPHONGBindingSource;
        private QLChungCuDataSet1TableAdapters.PHIEUDATPHONGTableAdapter pHIEUDATPHONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPDPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGNHANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGTRAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
    }
}