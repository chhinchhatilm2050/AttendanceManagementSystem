namespace Attendance.Student
{
    partial class formStudent
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_student_code = new System.Windows.Forms.TextBox();
            this.txt_student_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_student_lastname = new System.Windows.Forms.TextBox();
            this.txt_student_email = new System.Windows.Forms.TextBox();
            this.txt_student_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_student_group = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_student_gender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_student_type = new System.Windows.Forms.ComboBox();
            this.dtp_student_dob = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_student_isactive = new System.Windows.Forms.RadioButton();
            this.btn_student_save = new System.Windows.Forms.Button();
            this.btn_student_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(533, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(472, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(235, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Code";
            // 
            // txt_student_code
            // 
            this.txt_student_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_student_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_code.Location = new System.Drawing.Point(238, 303);
            this.txt_student_code.Name = "txt_student_code";
            this.txt_student_code.Size = new System.Drawing.Size(291, 27);
            this.txt_student_code.TabIndex = 3;
            this.txt_student_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_student_firstname
            // 
            this.txt_student_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_student_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_firstname.Location = new System.Drawing.Point(669, 303);
            this.txt_student_firstname.Name = "txt_student_firstname";
            this.txt_student_firstname.Size = new System.Drawing.Size(291, 27);
            this.txt_student_firstname.TabIndex = 4;
            this.txt_student_firstname.TextChanged += new System.EventHandler(this.txt_student_firstname_TextChanged);
            this.txt_student_firstname.Leave += new System.EventHandler(this.txt_student_firstname_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(666, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // txt_student_lastname
            // 
            this.txt_student_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_student_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_lastname.Location = new System.Drawing.Point(238, 364);
            this.txt_student_lastname.Name = "txt_student_lastname";
            this.txt_student_lastname.Size = new System.Drawing.Size(291, 27);
            this.txt_student_lastname.TabIndex = 6;
            this.txt_student_lastname.Leave += new System.EventHandler(this.txt_student_lastname_Leave);
            // 
            // txt_student_email
            // 
            this.txt_student_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_student_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_email.Location = new System.Drawing.Point(669, 364);
            this.txt_student_email.Name = "txt_student_email";
            this.txt_student_email.Size = new System.Drawing.Size(291, 27);
            this.txt_student_email.TabIndex = 7;
            this.txt_student_email.Leave += new System.EventHandler(this.txt_student_email_Leave);
            // 
            // txt_student_phone
            // 
            this.txt_student_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_student_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_phone.Location = new System.Drawing.Point(238, 425);
            this.txt_student_phone.Name = "txt_student_phone";
            this.txt_student_phone.Size = new System.Drawing.Size(291, 27);
            this.txt_student_phone.TabIndex = 8;
            this.txt_student_phone.Leave += new System.EventHandler(this.txt_student_phone_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(235, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(666, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(235, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            // 
            // cbb_student_group
            // 
            this.cbb_student_group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_student_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_student_group.FormattingEnabled = true;
            this.cbb_student_group.Location = new System.Drawing.Point(669, 424);
            this.cbb_student_group.Name = "cbb_student_group";
            this.cbb_student_group.Size = new System.Drawing.Size(291, 28);
            this.cbb_student_group.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(666, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Group";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(235, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gender";
            // 
            // cbb_student_gender
            // 
            this.cbb_student_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_student_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_student_gender.FormattingEnabled = true;
            this.cbb_student_gender.Location = new System.Drawing.Point(238, 488);
            this.cbb_student_gender.Name = "cbb_student_gender";
            this.cbb_student_gender.Size = new System.Drawing.Size(291, 28);
            this.cbb_student_gender.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(666, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Type";
            // 
            // cbb_student_type
            // 
            this.cbb_student_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_student_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_student_type.FormattingEnabled = true;
            this.cbb_student_type.Location = new System.Drawing.Point(669, 488);
            this.cbb_student_type.Name = "cbb_student_type";
            this.cbb_student_type.Size = new System.Drawing.Size(291, 28);
            this.cbb_student_type.TabIndex = 16;
            // 
            // dtp_student_dob
            // 
            this.dtp_student_dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_student_dob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_student_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_student_dob.Location = new System.Drawing.Point(238, 551);
            this.dtp_student_dob.Name = "dtp_student_dob";
            this.dtp_student_dob.Size = new System.Drawing.Size(291, 27);
            this.dtp_student_dob.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(235, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date of birth";
            // 
            // btn_student_isactive
            // 
            this.btn_student_isactive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_student_isactive.AutoSize = true;
            this.btn_student_isactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_isactive.Location = new System.Drawing.Point(669, 554);
            this.btn_student_isactive.Name = "btn_student_isactive";
            this.btn_student_isactive.Size = new System.Drawing.Size(94, 24);
            this.btn_student_isactive.TabIndex = 20;
            this.btn_student_isactive.TabStop = true;
            this.btn_student_isactive.Text = "Is Active";
            this.btn_student_isactive.UseVisualStyleBackColor = true;
            // 
            // btn_student_save
            // 
            this.btn_student_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_student_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_student_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_student_save.Location = new System.Drawing.Point(775, 545);
            this.btn_student_save.Name = "btn_student_save";
            this.btn_student_save.Size = new System.Drawing.Size(86, 33);
            this.btn_student_save.TabIndex = 21;
            this.btn_student_save.Text = "Save";
            this.btn_student_save.UseVisualStyleBackColor = false;
            // 
            // btn_student_close
            // 
            this.btn_student_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_student_close.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_student_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_student_close.Location = new System.Drawing.Point(874, 545);
            this.btn_student_close.Name = "btn_student_close";
            this.btn_student_close.Size = new System.Drawing.Size(86, 33);
            this.btn_student_close.TabIndex = 22;
            this.btn_student_close.Text = "Close";
            this.btn_student_close.UseVisualStyleBackColor = false;
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1217, 617);
            this.Controls.Add(this.btn_student_close);
            this.Controls.Add(this.btn_student_save);
            this.Controls.Add(this.btn_student_isactive);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_student_dob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbb_student_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbb_student_gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_student_group);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_student_phone);
            this.Controls.Add(this.txt_student_email);
            this.Controls.Add(this.txt_student_lastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_student_firstname);
            this.Controls.Add(this.txt_student_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formStudent";
            this.Text = "Student Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_student_code;
        private System.Windows.Forms.TextBox txt_student_firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_student_lastname;
        private System.Windows.Forms.TextBox txt_student_email;
        private System.Windows.Forms.TextBox txt_student_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_student_group;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_student_gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_student_type;
        private System.Windows.Forms.DateTimePicker dtp_student_dob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton btn_student_isactive;
        private System.Windows.Forms.Button btn_student_save;
        private System.Windows.Forms.Button btn_student_close;
    }
}