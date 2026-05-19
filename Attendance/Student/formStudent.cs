using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance.Student
{
    public partial class formStudent : Form
    {
        public formStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_student_firstname_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.FirstName = txt_student_firstname.Text;
            txt_student_firstname.Text = vl.FirstName;
        }

        private void txt_student_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_student_lastname_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.LastName = txt_student_lastname.Text;
            txt_student_lastname.Text = vl.LastName;
        }

        private void txt_student_email_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.Email = txt_student_email.Text;
            txt_student_email .Text = vl.Email;
        }

        private void txt_student_phone_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.PhoneNumber = txt_student_phone.Text;
            txt_student_phone.Text = vl.PhoneNumber;
        }
    }
}
