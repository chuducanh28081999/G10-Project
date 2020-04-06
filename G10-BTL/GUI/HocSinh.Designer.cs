namespace G10_BTL.GUI
{
    partial class HocSinh
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
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tentk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.montk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hktk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.namtk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mahs = new System.Windows.Forms.Label();
            this.tenhs = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.timkiem = new System.Windows.Forms.Button();
            this.điểmTổngKếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmTổngKếtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 240);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timkiem);
            this.groupBox1.Controls.Add(this.namtk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hktk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.montk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tentk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(408, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học sinh:";
            // 
            // tentk
            // 
            this.tentk.Location = new System.Drawing.Point(111, 28);
            this.tentk.Name = "tentk";
            this.tentk.Size = new System.Drawing.Size(144, 22);
            this.tentk.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn học:";
            // 
            // montk
            // 
            this.montk.Location = new System.Drawing.Point(111, 62);
            this.montk.Name = "montk";
            this.montk.Size = new System.Drawing.Size(144, 22);
            this.montk.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Học kỳ:";
            // 
            // hktk
            // 
            this.hktk.Location = new System.Drawing.Point(368, 28);
            this.hktk.Name = "hktk";
            this.hktk.Size = new System.Drawing.Size(144, 22);
            this.hktk.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm học:";
            // 
            // namtk
            // 
            this.namtk.Location = new System.Drawing.Point(368, 65);
            this.namtk.Name = "namtk";
            this.namtk.Size = new System.Drawing.Size(144, 22);
            this.namtk.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã học sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Họ và tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lớp:";
            // 
            // mahs
            // 
            this.mahs.AutoSize = true;
            this.mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahs.Location = new System.Drawing.Point(119, 69);
            this.mahs.Name = "mahs";
            this.mahs.Size = new System.Drawing.Size(41, 16);
            this.mahs.TabIndex = 6;
            this.mahs.Text = "HS01";
            // 
            // tenhs
            // 
            this.tenhs.AutoSize = true;
            this.tenhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenhs.Location = new System.Drawing.Point(119, 103);
            this.tenhs.Name = "tenhs";
            this.tenhs.Size = new System.Drawing.Size(83, 16);
            this.tenhs.TabIndex = 7;
            this.tenhs.Text = "Chu Đức Anh";
            // 
            // lop
            // 
            this.lop.AutoSize = true;
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.Location = new System.Drawing.Point(119, 142);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(25, 16);
            this.lop.TabIndex = 8;
            this.lop.Text = "5D";
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.timkiem.Location = new System.Drawing.Point(226, 123);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(113, 28);
            this.timkiem.TabIndex = 9;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = false;
            // 
            // điểmTổngKếtToolStripMenuItem
            // 
            this.điểmTổngKếtToolStripMenuItem.Name = "điểmTổngKếtToolStripMenuItem";
            this.điểmTổngKếtToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.điểmTổngKếtToolStripMenuItem.Text = "Điểm tổng kết";
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.tenhs);
            this.Controls.Add(this.mahs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HocSinh";
            this.Text = "HocSinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem điểmTổngKếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.TextBox namtk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hktk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox montk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tentk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mahs;
        private System.Windows.Forms.Label tenhs;
        private System.Windows.Forms.Label lop;
    }
}