using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EClerx.ADO.Day14
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtEmailId.Text = "";
            TxtPassword.Text = "";
            TxtConfirmPassword.Text = "";
            DdlGender.Text = "--Select--";
            DtpBirthDate.Value = DateTime.Now;
        }

        private int FindAge()
        {
            DateTime selectedDate = DtpBirthDate.Value;
            int age = DateTime.Now.Year - selectedDate.Year;
            if (DateTime.Now.DayOfYear < selectedDate.DayOfYear)
            {
                age--;
            }
            return age;
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            DdlGender.Text = "--Select--";
            DdlGender.Items.Add("Male");
            DdlGender.Items.Add("Female");
            DdlGender.Items.Add("Others");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void DtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            int age = FindAge();
            if (age < 18)
            {
                MessageBox.Show("Age should be greater than 18 years");                
            }          
        }
    }
}
