using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMedicalCenter
{
    public partial class FormPersonalAppointmentInfo : Form
    {
        public FormPersonalAppointmentInfo()
        {
            InitializeComponent();
        }
        private void FormPersonalAppointmentInfo_Load(object sender, EventArgs e)
        {
            labelRefreshVerification_Click(sender, e);
        }
        bool IsIDHasText = false;
        bool IsDOBHasText = false;
        bool IsVerificationHasText = false; 
        private void textBoxID_Enter(object sender, EventArgs e)
        {
            if (IsIDHasText == false)
            {
                textBoxID.Text = "";
            }
            textBoxID.ForeColor = Color.Black;
            textBoxID.Font = new Font("Arial", 14, FontStyle.Regular);
        }
        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                textBoxID.Text = "請輸入證號";
                textBoxID.ForeColor = Color.Gray;
                textBoxID.Font = new Font("標楷體", 14, FontStyle.Regular);
                IsIDHasText = false;
            }
            else
            {
                IsIDHasText = true;
            }
        }
        private void textBoxDOB_Enter(object sender, EventArgs e)
        {
            if (IsDOBHasText == false)
            {
                textBoxDOB.Text = "";
            }
            textBoxDOB.ForeColor = Color.Black;
            textBoxDOB.Font = new Font("Arial", 14, FontStyle.Regular);
        }
        private void textBoxDOB_Leave(object sender, EventArgs e)
        {
            if (textBoxDOB.Text == "")
            {
                textBoxDOB.Text = "請輸入生日(西元年、月、日)";
                textBoxDOB.ForeColor = Color.Gray;
                textBoxDOB.Font = new Font("標楷體", 14, FontStyle.Regular);
                IsDOBHasText = false;
            }
            else
            {
                IsDOBHasText = true;
            }
        }
        private void textBoxVerification_Enter(object sender, EventArgs e)
        {
            if (IsVerificationHasText == false)
            {
                textBoxVerification.Text = "";
            }
            textBoxVerification.ForeColor = Color.Black;
            textBoxVerification.Font = new Font("Arial", 14, FontStyle.Regular);
        }
        private void textBoxVerification_Leave(object sender, EventArgs e)
        {
            if (textBoxVerification.Text == "")
            {
                textBoxVerification.Text = "請輸入驗證碼";
                textBoxVerification.ForeColor = Color.Gray;
                textBoxVerification.Font = new Font("標楷體", 14, FontStyle.Regular);
                IsVerificationHasText = false;
            }
            else
            {
                IsVerificationHasText = true;
            }
        }

        private void labelRefreshVerification_Click(object sender, EventArgs e)
        {
            labelVerification.Text = Guid.NewGuid().ToString().Substring(0, 4);
        }

        
    }
}
