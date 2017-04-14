namespace THUVIEN
{
    partial class ModuleReader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dTPNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.comNATIVE = new System.Windows.Forms.ComboBox();
            this.txtSosachmuon = new System.Windows.Forms.TextBox();
            this.comTypereader = new System.Windows.Forms.ComboBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnFIND = new System.Windows.Forms.Button();
            this.dGVReader = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSosachmuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.tHUVIENDataSet = new THUVIEN.THUVIENDataSet();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new THUVIEN.THUVIENDataSetTableAdapters.readerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người đọc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số sách đã mượn: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại người đọc:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 27);
            this.txtName.TabIndex = 6;
            // 
            // dTPNgaysinh
            // 
            this.dTPNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dTPNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgaysinh.Location = new System.Drawing.Point(182, 54);
            this.dTPNgaysinh.Name = "dTPNgaysinh";
            this.dTPNgaysinh.Size = new System.Drawing.Size(140, 27);
            this.dTPNgaysinh.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(182, 87);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(261, 27);
            this.txtCMND.TabIndex = 8;
            // 
            // comNATIVE
            // 
            this.comNATIVE.FormattingEnabled = true;
            this.comNATIVE.Location = new System.Drawing.Point(182, 120);
            this.comNATIVE.Name = "comNATIVE";
            this.comNATIVE.Size = new System.Drawing.Size(156, 28);
            this.comNATIVE.TabIndex = 10;
            // 
            // txtSosachmuon
            // 
            this.txtSosachmuon.Location = new System.Drawing.Point(182, 154);
            this.txtSosachmuon.Name = "txtSosachmuon";
            this.txtSosachmuon.Size = new System.Drawing.Size(115, 27);
            this.txtSosachmuon.TabIndex = 11;
            // 
            // comTypereader
            // 
            this.comTypereader.FormattingEnabled = true;
            this.comTypereader.Location = new System.Drawing.Point(182, 188);
            this.comTypereader.Name = "comTypereader";
            this.comTypereader.Size = new System.Drawing.Size(156, 28);
            this.comTypereader.TabIndex = 12;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(459, 21);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(121, 56);
            this.btnADD.TabIndex = 13;
            this.btnADD.Text = "THÊM";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(614, 91);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(122, 56);
            this.btnUPDATE.TabIndex = 14;
            this.btnUPDATE.Text = "SỬA";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(459, 90);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(121, 58);
            this.btnDELETE.TabIndex = 15;
            this.btnDELETE.Text = "XÓA";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnFIND
            // 
            this.btnFIND.Location = new System.Drawing.Point(614, 20);
            this.btnFIND.Name = "btnFIND";
            this.btnFIND.Size = new System.Drawing.Size(122, 58);
            this.btnFIND.TabIndex = 16;
            this.btnFIND.Text = "TÌM KIẾM";
            this.btnFIND.UseVisualStyleBackColor = true;
            this.btnFIND.Click += new System.EventHandler(this.btnFIND_Click);
            // 
            // dGVReader
            // 
            this.dGVReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmName,
            this.clmNgaysinh,
            this.clmCMND,
            this.clmNative,
            this.clmSosachmuon,
            this.clmTYPE});
            this.dGVReader.Location = new System.Drawing.Point(26, 239);
            this.dGVReader.Name = "dGVReader";
            this.dGVReader.RowTemplate.Height = 24;
            this.dGVReader.Size = new System.Drawing.Size(710, 315);
            this.dGVReader.TabIndex = 17;
            this.dGVReader.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dGVReader_RowPrePaint);
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.Width = 50;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "name";
            this.clmName.HeaderText = "Tên người đọc";
            this.clmName.Name = "clmName";
            this.clmName.Width = 200;
            // 
            // clmNgaysinh
            // 
            this.clmNgaysinh.DataPropertyName = "ngaysinh";
            this.clmNgaysinh.HeaderText = "Ngày sinh";
            this.clmNgaysinh.Name = "clmNgaysinh";
            this.clmNgaysinh.Width = 120;
            // 
            // clmCMND
            // 
            this.clmCMND.DataPropertyName = "socmnd";
            this.clmCMND.HeaderText = "CMND";
            this.clmCMND.Name = "clmCMND";
            this.clmCMND.Width = 120;
            // 
            // clmNative
            // 
            this.clmNative.DataPropertyName = "quequan";
            this.clmNative.HeaderText = "Quê Quán";
            this.clmNative.Name = "clmNative";
            // 
            // clmSosachmuon
            // 
            this.clmSosachmuon.DataPropertyName = "sosachmuon";
            this.clmSosachmuon.HeaderText = "Số sách mượn";
            this.clmSosachmuon.Name = "clmSosachmuon";
            this.clmSosachmuon.Width = 70;
            // 
            // clmTYPE
            // 
            this.clmTYPE.DataPropertyName = "typereader";
            this.clmTYPE.HeaderText = "Loại người đọc";
            this.clmTYPE.Name = "clmTYPE";
            this.clmTYPE.Width = 70;
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(459, 159);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(277, 56);
            this.btnREFRESH.TabIndex = 18;
            this.btnREFRESH.Text = "CẬP NHẬT";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // tHUVIENDataSet
            // 
            this.tHUVIENDataSet.DataSetName = "THUVIENDataSet";
            this.tHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            this.readerBindingSource.DataSource = this.tHUVIENDataSet;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // ModuleReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.dGVReader);
            this.Controls.Add(this.btnFIND);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.comTypereader);
            this.Controls.Add(this.txtSosachmuon);
            this.Controls.Add(this.comNATIVE);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.dTPNgaysinh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModuleReader";
            this.Size = new System.Drawing.Size(758, 571);
            this.Load += new System.EventHandler(this.ModuleReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dTPNgaysinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.ComboBox comNATIVE;
        private System.Windows.Forms.TextBox txtSosachmuon;
        private System.Windows.Forms.ComboBox comTypereader;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnFIND;
        private System.Windows.Forms.DataGridView dGVReader;
        private System.Windows.Forms.Button btnREFRESH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNative;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSosachmuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTYPE;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private THUVIENDataSet tHUVIENDataSet;
        private THUVIENDataSetTableAdapters.readerTableAdapter readerTableAdapter;
    }
}
