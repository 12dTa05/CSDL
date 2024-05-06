namespace CSDL_new
{
    partial class Form4
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
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLChungCuDataSet = new CSDL_new.QLChungCuDataSet();
            this.RESET_button = new System.Windows.Forms.Button();
            this.MAPDP_text = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DATPHONG_button = new System.Windows.Forms.Button();
            this.NGAYSINH_text = new System.Windows.Forms.DateTimePicker();
            this.GIOITINH_text = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DIACHI_text = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LOC_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DATE_traphong = new System.Windows.Forms.DateTimePicker();
            this.DATE_nhanphong = new System.Windows.Forms.DateTimePicker();
            this.SODT_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CCCD_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TENKH_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GIAPHONG_text = new System.Windows.Forms.TextBox();
            this.lOAIPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOPHONGDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.SOPHONG_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pHONGTableAdapter = new CSDL_new.QLChungCuDataSetTableAdapters.PHONGTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChungCuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.qLChungCuDataSet;
            // 
            // qLChungCuDataSet
            // 
            this.qLChungCuDataSet.DataSetName = "QLChungCuDataSet";
            this.qLChungCuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RESET_button
            // 
            this.RESET_button.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET_button.Location = new System.Drawing.Point(821, 108);
            this.RESET_button.Name = "RESET_button";
            this.RESET_button.Size = new System.Drawing.Size(75, 28);
            this.RESET_button.TabIndex = 8;
            this.RESET_button.Text = "Reset";
            this.RESET_button.UseVisualStyleBackColor = true;
            // 
            // MAPDP_text
            // 
            this.MAPDP_text.Location = new System.Drawing.Point(236, 274);
            this.MAPDP_text.Name = "MAPDP_text";
            this.MAPDP_text.ReadOnly = true;
            this.MAPDP_text.Size = new System.Drawing.Size(141, 22);
            this.MAPDP_text.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Goldenrod;
            this.label16.Location = new System.Drawing.Point(51, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Tạo phiếu đặt phòng";
            // 
            // DATPHONG_button
            // 
            this.DATPHONG_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATPHONG_button.Location = new System.Drawing.Point(848, 380);
            this.DATPHONG_button.Name = "DATPHONG_button";
            this.DATPHONG_button.Size = new System.Drawing.Size(89, 57);
            this.DATPHONG_button.TabIndex = 21;
            this.DATPHONG_button.Text = "Đặt phòng";
            this.DATPHONG_button.UseVisualStyleBackColor = true;
            // 
            // NGAYSINH_text
            // 
            this.NGAYSINH_text.Location = new System.Drawing.Point(551, 416);
            this.NGAYSINH_text.Name = "NGAYSINH_text";
            this.NGAYSINH_text.Size = new System.Drawing.Size(223, 22);
            this.NGAYSINH_text.TabIndex = 20;
            // 
            // GIOITINH_text
            // 
            this.GIOITINH_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GIOITINH_text.FormattingEnabled = true;
            this.GIOITINH_text.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GIOITINH_text.Location = new System.Drawing.Point(125, 416);
            this.GIOITINH_text.Name = "GIOITINH_text";
            this.GIOITINH_text.Size = new System.Drawing.Size(226, 24);
            this.GIOITINH_text.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(452, 416);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 21);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ngày sinh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Giới tính";
            // 
            // DIACHI_text
            // 
            this.DIACHI_text.Location = new System.Drawing.Point(549, 471);
            this.DIACHI_text.Name = "DIACHI_text";
            this.DIACHI_text.Size = new System.Drawing.Size(226, 22);
            this.DIACHI_text.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(463, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Địa chỉ";
            // 
            // LOC_button
            // 
            this.LOC_button.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOC_button.ForeColor = System.Drawing.Color.Goldenrod;
            this.LOC_button.Location = new System.Drawing.Point(701, 20);
            this.LOC_button.Name = "LOC_button";
            this.LOC_button.Size = new System.Drawing.Size(79, 36);
            this.LOC_button.TabIndex = 7;
            this.LOC_button.Text = "Lọc";
            this.LOC_button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(442, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày trả phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(38, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày nhận phòng";
            // 
            // DATE_traphong
            // 
            this.DATE_traphong.Location = new System.Drawing.Point(437, 39);
            this.DATE_traphong.Name = "DATE_traphong";
            this.DATE_traphong.Size = new System.Drawing.Size(200, 22);
            this.DATE_traphong.TabIndex = 4;
            // 
            // DATE_nhanphong
            // 
            this.DATE_nhanphong.Location = new System.Drawing.Point(35, 38);
            this.DATE_nhanphong.Name = "DATE_nhanphong";
            this.DATE_nhanphong.Size = new System.Drawing.Size(200, 22);
            this.DATE_nhanphong.TabIndex = 3;
            // 
            // SODT_text
            // 
            this.SODT_text.Location = new System.Drawing.Point(125, 472);
            this.SODT_text.Name = "SODT_text";
            this.SODT_text.Size = new System.Drawing.Size(226, 22);
            this.SODT_text.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Số ĐT";
            // 
            // CCCD_text
            // 
            this.CCCD_text.Location = new System.Drawing.Point(548, 360);
            this.CCCD_text.Name = "CCCD_text";
            this.CCCD_text.Size = new System.Drawing.Size(226, 22);
            this.CCCD_text.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "CCCD";
            // 
            // TENKH_text
            // 
            this.TENKH_text.Location = new System.Drawing.Point(125, 361);
            this.TENKH_text.Name = "TENKH_text";
            this.TENKH_text.Size = new System.Drawing.Size(226, 22);
            this.TENKH_text.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên KH";
            // 
            // GIAPHONG_text
            // 
            this.GIAPHONG_text.Location = new System.Drawing.Point(548, 312);
            this.GIAPHONG_text.Name = "GIAPHONG_text";
            this.GIAPHONG_text.ReadOnly = true;
            this.GIAPHONG_text.Size = new System.Drawing.Size(226, 22);
            this.GIAPHONG_text.TabIndex = 7;
            // 
            // lOAIPHONGDataGridViewTextBoxColumn
            // 
            this.lOAIPHONGDataGridViewTextBoxColumn.DataPropertyName = "LOAIPHONG";
            this.lOAIPHONGDataGridViewTextBoxColumn.HeaderText = "Loại phòng";
            this.lOAIPHONGDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lOAIPHONGDataGridViewTextBoxColumn.Name = "lOAIPHONGDataGridViewTextBoxColumn";
            this.lOAIPHONGDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOAIPHONGDataGridViewTextBoxColumn.Width = 140;
            // 
            // sOPHONGDataGridViewButtonColumn
            // 
            this.sOPHONGDataGridViewButtonColumn.DataPropertyName = "SOPHONG";
            this.sOPHONGDataGridViewButtonColumn.HeaderText = "Số phòng";
            this.sOPHONGDataGridViewButtonColumn.MinimumWidth = 10;
            this.sOPHONGDataGridViewButtonColumn.Name = "sOPHONGDataGridViewButtonColumn";
            this.sOPHONGDataGridViewButtonColumn.ReadOnly = true;
            this.sOPHONGDataGridViewButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sOPHONGDataGridViewButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sOPHONGDataGridViewButtonColumn.Width = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Giá phòng";
            // 
            // SOPHONG_text
            // 
            this.SOPHONG_text.Location = new System.Drawing.Point(125, 313);
            this.SOPHONG_text.Name = "SOPHONG_text";
            this.SOPHONG_text.ReadOnly = true;
            this.SOPHONG_text.Size = new System.Drawing.Size(226, 22);
            this.SOPHONG_text.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOPHONGDataGridViewButtonColumn,
            this.lOAIPHONGDataGridViewTextBoxColumn,
            this.gIADataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.pHONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(167, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 160);
            this.dataGridView1.TabIndex = 3;
            // 
            // gIADataGridViewTextBoxColumn
            // 
            this.gIADataGridViewTextBoxColumn.DataPropertyName = "GIA";
            this.gIADataGridViewTextBoxColumn.HeaderText = "Giá (VND)";
            this.gIADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gIADataGridViewTextBoxColumn.Name = "gIADataGridViewTextBoxColumn";
            this.gIADataGridViewTextBoxColumn.ReadOnly = true;
            this.gIADataGridViewTextBoxColumn.Width = 140;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LOC_button);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.DATE_traphong);
            this.panel5.Controls.Add(this.DATE_nhanphong);
            this.panel5.Location = new System.Drawing.Point(115, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(860, 100);
            this.panel5.TabIndex = 2;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm phòng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RESET_button);
            this.panel4.Controls.Add(this.MAPDP_text);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.DATPHONG_button);
            this.panel4.Controls.Add(this.NGAYSINH_text);
            this.panel4.Controls.Add(this.GIOITINH_text);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.DIACHI_text);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.SODT_text);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.CCCD_text);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.TENKH_text);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.GIAPHONG_text);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.SOPHONG_text);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 450);
            this.panel4.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChungCuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QLChungCuDataSet qLChungCuDataSet;
        private System.Windows.Forms.Button RESET_button;
        private System.Windows.Forms.TextBox MAPDP_text;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button DATPHONG_button;
        private System.Windows.Forms.DateTimePicker NGAYSINH_text;
        private System.Windows.Forms.ComboBox GIOITINH_text;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DIACHI_text;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button LOC_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DATE_traphong;
        private System.Windows.Forms.DateTimePicker DATE_nhanphong;
        private System.Windows.Forms.TextBox SODT_text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CCCD_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TENKH_text;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox GIAPHONG_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn sOPHONGDataGridViewButtonColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SOPHONG_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private QLChungCuDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
    }
}