using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance.Teacher
{
    public partial class formTeacher : Form
    {
        public formTeacher()
        {
            InitializeComponent();
        }

        private void txt_teacher_firstname_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.FirstName = txt_teacher_firstname.Text;
            txt_teacher_firstname.Text = vl.FirstName;
        }

        private void txt_teacher_lastname_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.LastName = txt_teacher_lastname.Text;
            txt_teacher_lastname.Text = vl.LastName;
        }

        private void txt_teacher_email_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.Email = txt_teacher_email.Text;
            txt_teacher_email.Text = vl.Email;
        }

        private void txt_teacher_phone_Leave(object sender, EventArgs e)
        {
            ValidationInfos.InfoValidation vl = new ValidationInfos.InfoValidation();
            vl.PhoneNumber = txt_teacher_phone.Text;
            txt_teacher_phone.Text = vl.PhoneNumber;
        }
    }
}
