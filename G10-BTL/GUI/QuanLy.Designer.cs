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
            this.label1 = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Teacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trường Tiểu Học Vĩnh Ngọc";
            // 
            // Mark
            // 
            this.Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark.Location = new System.Drawing.Point(356, 173);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(128, 32);
            this.Mark.TabIndex = 7;
            this.Mark.Text = "Quản lý điểm";
            this.Mark.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(10, 173);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(136, 32);
            this.Student.TabIndex = 6;
            this.Student.Text = "Quản lý học sinh";
            this.Student.UseVisualStyleBackColor = false;
            // 
            // Teacher
            // 
            this.Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher.Location = new System.Drawing.Point(189, 173);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(134, 32);
            this.Teacher.TabIndex = 5;
            this.Teacher.Text = "Quản lý giáo viên";
            this.Teacher.UseVisualStyleBackColor = false;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::G10_BTL.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(495, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Teacher);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mark;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Teacher;
    }
}