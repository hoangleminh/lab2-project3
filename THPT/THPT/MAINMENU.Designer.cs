namespace THUVIEN
{
    partial class MAINMENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BOOK = new System.Windows.Forms.ToolStripMenuItem();
            this.READER = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGTINMƯỢNTRẢToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MUON = new System.Windows.Forms.ToolStripMenuItem();
            this.TRA = new System.Windows.Forms.ToolStripMenuItem();
            this.HUONGDAN = new System.Windows.Forms.ToolStripMenuItem();
            this.THONGTIN = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTHAOTAC = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BOOK,
            this.READER,
            this.tHÔNGTINMƯỢNTRẢToolStripMenuItem,
            this.HUONGDAN,
            this.THONGTIN,
            this.LOGOUT,
            this.EXIT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BOOK
            // 
            this.BOOK.Name = "BOOK";
            this.BOOK.Size = new System.Drawing.Size(94, 24);
            this.BOOK.Text = "ĐẦU SÁCH";
            this.BOOK.Click += new System.EventHandler(this.BOOK_Click);
            // 
            // READER
            // 
            this.READER.Name = "READER";
            this.READER.Size = new System.Drawing.Size(80, 24);
            this.READER.Text = "ĐỘC GIẢ";
            this.READER.Click += new System.EventHandler(this.READER_Click);
            // 
            // tHÔNGTINMƯỢNTRẢToolStripMenuItem
            // 
            this.tHÔNGTINMƯỢNTRẢToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MUON,
            this.TRA});
            this.tHÔNGTINMƯỢNTRẢToolStripMenuItem.Name = "tHÔNGTINMƯỢNTRẢToolStripMenuItem";
            this.tHÔNGTINMƯỢNTRẢToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.tHÔNGTINMƯỢNTRẢToolStripMenuItem.Text = "THÔNG TIN MƯỢN - TRẢ";
            // 
            // MUON
            // 
            this.MUON.Name = "MUON";
            this.MUON.Size = new System.Drawing.Size(166, 24);
            this.MUON.Text = "MƯỢN SÁCH";
            // 
            // TRA
            // 
            this.TRA.Name = "TRA";
            this.TRA.Size = new System.Drawing.Size(166, 24);
            this.TRA.Text = "TRẢ SÁCH";
            // 
            // HUONGDAN
            // 
            this.HUONGDAN.Name = "HUONGDAN";
            this.HUONGDAN.Size = new System.Drawing.Size(111, 24);
            this.HUONGDAN.Text = "HƯỚNG DẪN";
            // 
            // THONGTIN
            // 
            this.THONGTIN.Name = "THONGTIN";
            this.THONGTIN.Size = new System.Drawing.Size(181, 24);
            this.THONGTIN.Text = "THÔNG TIN PHẦN MỀM";
            // 
            // LOGOUT
            // 
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(104, 24);
            this.LOGOUT.Text = "ĐĂNG XUẤT";
            this.LOGOUT.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // EXIT
            // 
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(68, 24);
            this.EXIT.Text = "THOÁT";
            this.EXIT.Click += new System.EventHandler(this.tHOÁTToolStripMenuItem_Click);
            // 
            // panelTHAOTAC
            // 
            this.panelTHAOTAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTHAOTAC.Location = new System.Drawing.Point(0, 28);
            this.panelTHAOTAC.Name = "panelTHAOTAC";
            this.panelTHAOTAC.Size = new System.Drawing.Size(993, 550);
            this.panelTHAOTAC.TabIndex = 1;
            // 
            // MAINMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 578);
            this.Controls.Add(this.panelTHAOTAC);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MAINMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU CHÍNH";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BOOK;
        private System.Windows.Forms.ToolStripMenuItem READER;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGTINMƯỢNTRẢToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MUON;
        private System.Windows.Forms.ToolStripMenuItem TRA;
        private System.Windows.Forms.ToolStripMenuItem HUONGDAN;
        private System.Windows.Forms.ToolStripMenuItem THONGTIN;
        private System.Windows.Forms.Panel panelTHAOTAC;
        private System.Windows.Forms.ToolStripMenuItem LOGOUT;
        private System.Windows.Forms.ToolStripMenuItem EXIT;
    }
}