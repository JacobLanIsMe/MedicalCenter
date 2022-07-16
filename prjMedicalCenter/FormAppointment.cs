using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMedicalCenter
{
    public partial class FormAppointment : Form
    {
        public FormAppointment()
        {
            InitializeComponent();
        }

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=MedicalCenter;Integrated Security=True";
            con.Open();
            string sql = "select fBranchName from tBranch";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxSelectBranch.Items.Add(reader["fBranchName"]);
            }
            con.Close();
        }

        private void comboBoxSelectBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxSelectDepartment.Enabled = true;
        }
    }
}
