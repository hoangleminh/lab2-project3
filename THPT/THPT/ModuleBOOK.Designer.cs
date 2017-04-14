namespace THUVIEN
{
    partial class ModuleBOOK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNAMEBOOK = new System.Windows.Forms.TextBox();
            this.txtAUTHOR = new System.Windows.Forms.TextBox();
            this.txtTYPE = new System.Windows.Forms.TextBox();
            this.txtNUMBER = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnFIND = new System.Windows.Forms.Button();
            this.dGVLISTBOOK = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNAMEBOOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAUTHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDAYIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPDAYIN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnREFRESH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLISTBOOK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 73);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 20);
            this.label.TabIndex = 3;
            this.label.Text = "Thể loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // txtNAMEBOOK
            // 
            this.txtNAMEBOOK.Location = new System.Drawing.Point(123, 14);
            this.txtNAMEBOOK.Name = "txtNAMEBOOK";
            this.txtNAMEBOOK.Size = new System.Drawing.Size(333, 26);
            this.txtNAMEBOOK.TabIndex = 5;
            // 
            // txtAUTHOR
            // 
            this.txtAUTHOR.Location = new System.Drawing.Point(123, 42);
            this.txtAUTHOR.Name = "txtAUTHOR";
            this.txtAUTHOR.Size = new System.Drawing.Size(333, 26);
            this.txtAUTHOR.TabIndex = 6;
            // 
            // txtTYPE
            // 
            this.txtTYPE.Location = new System.Drawing.Point(123, 70);
            this.txtTYPE.Name = "txtTYPE";
            this.txtTYPE.Size = new System.Drawing.Size(333, 26);
            this.txtTYPE.TabIndex = 7;
            // 
            // txtNUMBER
            // 
            this.txtNUMBER.Location = new System.Drawing.Point(123, 124);
            this.txtNUMBER.Name = "txtNUMBER";
            this.txtNUMBER.Size = new System.Drawing.Size(333, 26);
            this.txtNUMBER.TabIndex = 9;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(498, 17);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(108, 47);
            this.btnADD.TabIndex = 10;
            this.btnADD.Text = "THÊM";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(631, 89);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(108, 47);
            this.btnUPDATE.TabIndex = 11;
            this.btnUPDATE.Text = "SỬA";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(498, 86);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(108, 47);
            this.btnDELETE.TabIndex = 12;
            this.btnDELETE.Text = "XÓA";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnFIND
            // 
            this.btnFIND.Location = new System.Drawing.Point(631, 17);
            this.btnFIND.Name = "btnFIND";
            this.btnFIND.Size = new System.Drawing.Size(108, 47);
            this.btnFIND.TabIndex = 13;
            this.btnFIND.Text = "TÌM KIẾM";
            this.btnFIND.UseVisualStyleBackColor = true;
            this.btnFIND.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // dGVLISTBOOK
            // 
            this.dGVLISTBOOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLISTBOOK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmNAMEBOOK,
            this.clmAUTHOR,
            this.clmTYPE,
            this.clmDAYIN,
            this.clmNUMBER});
            this.dGVLISTBOOK.Location = new System.Drawing.Point(25, 169);
            this.dGVLISTBOOK.Name = "dGVLISTBOOK";
            this.dGVLISTBOOK.ReadOnly = true;
            this.dGVLISTBOOK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVLISTBOOK.Size = new System.Drawing.Size(714, 329);
            this.dGVLISTBOOK.TabIndex = 0;
            this.dGVLISTBOOK.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dGVLISTBOOK_RowPrePaint);
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.ReadOnly = true;
            this.clmSTT.Width = 50;
            // 
            // clmNAMEBOOK
            // 
            this.clmNAMEBOOK.DataPropertyName = "namebook";
            this.clmNAMEBOOK.HeaderText = "Tên sách";
            this.clmNAMEBOOK.Name = "clmNAMEBOOK";
            this.clmNAMEBOOK.ReadOnly = true;
            this.clmNAMEBOOK.Width = 220;
            // 
            // clmAUTHOR
            // 
            this.clmAUTHOR.DataPropertyName = "author";
            this.clmAUTHOR.HeaderText = "Tác giả";
            this.clmAUTHOR.Name = "clmAUTHOR";
            this.clmAUTHOR.ReadOnly = true;
            this.clmAUTHOR.Width = 150;
            // 
            // clmTYPE
            // 
            this.clmTYPE.DataPropertyName = "type";
            this.clmTYPE.HeaderText = "Thể loại";
            this.clmTYPE.Name = "clmTYPE";
            this.clmTYPE.ReadOnly = true;
            this.clmTYPE.Width = 130;
            // 
            // clmDAYIN
            // 
            this.clmDAYIN.DataPropertyName = "dayin";
            this.clmDAYIN.HeaderText = "Ngày nhập";
            this.clmDAYIN.Name = "clmDAYIN";
            this.clmDAYIN.ReadOnly = true;
            this.clmDAYIN.Width = 120;
            // 
            // clmNUMBER
            // 
            this.clmNUMBER.DataPropertyName = "number";
            this.clmNUMBER.HeaderText = "Số lượng";
            this.clmNUMBER.Name = "clmNUMBER";
            this.clmNUMBER.ReadOnly = true;
            this.clmNUMBER.Width = 50;
            // 
            // dTPDAYIN
            // 
            this.dTPDAYIN.CustomFormat = "dd/MM/yyyy";
            this.dTPDAYIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDAYIN.Location = new System.Drawing.Point(123, 97);
            this.dTPDAYIN.Name = "dTPDAYIN";
            this.dTPDAYIN.Size = new System.Drawing.Size(118, 26);
            this.dTPDAYIN.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "(dd/MM/yyyy)";
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(619, 504);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(120, 49);
            this.btnREFRESH.TabIndex = 17;
            this.btnREFRESH.Text = "CẬP NHẬT";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // ModuleBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPDAYIN);
            this.Controls.Add(this.dGVLISTBOOK);
            this.Controls.Add(this.btnFIND);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtNUMBER);
            this.Controls.Add(this.txtTYPE);
            this.Controls.Add(this.txtAUTHOR);
            this.Controls.Add(this.txtNAMEBOOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModuleBOOK";
            this.Size = new System.Drawing.Size(758, 571);
            this.Load += new System.EventHandler(this.ModuleBOOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLISTBOOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNAMEBOOK;
        private System.Windows.Forms.TextBox txtAUTHOR;
        private System.Windows.Forms.TextBox txtTYPE;
        private System.Windows.Forms.TextBox txtNUMBER;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnFIND;
        private System.Windows.Forms.DateTimePicker dTPDAYIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVLISTBOOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNAMEBOOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAUTHOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDAYIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNUMBER;
        private System.Windows.Forms.Button btnREFRESH;
    }
}
