namespace G10_BTL.GUI
{
    partial class QuanLy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mark = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.quảnLýHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHọcSinhToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem,
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem,
            this.mônHọcToolStripMenuItem,
            this.kếtQuảHọcTậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chu Duc Anh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Xin chào !";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Mark);
            this.groupBox2.Controls.Add(this.Student);
            this.groupBox2.Location = new System.Drawing.Point(0, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 143);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng - Quyền hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quản lý điểm trường tiểu học Vĩnh Ngọc ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::G10_BTL.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(202, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 410);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Mark
            // 
            this.Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark.Image = global::G10_BTL.Properties.Resources.login;
            this.Mark.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Mark.Location = new System.Drawing.Point(6, 33);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(149, 32);
            this.Mark.TabIndex = 7;
            this.Mark.Text = "Quản lý người dùng";
            this.Mark.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Image = global::G10_BTL.Properties.Resources.login;
            this.Student.Location = new System.Drawing.Point(6, 85);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(149, 32);
            this.Student.TabIndex = 6;
            this.Student.Text = "Đổi mật khẩu";
            this.Student.UseVisualStyleBackColor = false;
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            this.quảnLýHọcSinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýHọcSinhToolStripMenuItem.Image = global::G10_BTL.Properties.Resources.student2;
            this.quảnLýHọcSinhToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            this.quảnLýHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýGiáoViênToolStripMenuItem.Image = global::G10_BTL.Properties.Resources.teacher;
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Quản lý giáo viên";
            // 
            // quảnLýLớpHọcNhậpĐiểmToolStripMenuItem
            // 
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem.Image = global::G10_BTL.Properties.Resources._class;
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem.Name = "quảnLýLớpHọcNhậpĐiểmToolStripMenuItem";
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.quảnLýLớpHọcNhậpĐiểmToolStripMenuItem.Text = "Lớp học";
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mônHọcToolStripMenuItem.Image = global::G10_BTL.Properties.Resources.subject;
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            // 
            // kếtQuảHọcTậpToolStripMenuItem
            // 
            this.kếtQuảHọcTậpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kếtQuảHọcTậpToolStripMenuItem.Image = global::G10_BTL.Properties.Resources.Cup;
            this.kếtQuảHọcTậpToolStripMenuItem.Name = "kếtQuảHọcTậpToolStripMenuItem";
            this.kếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kếtQuảHọcTậpToolStripMenuItem.Text = "Kết quả học tập";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Mark;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcNhậpĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcTậpToolStripMenuItem;
    }
}