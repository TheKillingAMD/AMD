using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tenant
{
    public partial class Delete_Tenant : Form
    {
        public Delete_Tenant()
        {
            InitializeComponent();
        }

        string connectionString = @"server=.;Database=Tenant Master;Trusted_Connection=True;";
        void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                var query = new SqlCommand("DELETE FROM TENANT_MASTER WHERE Tenant_Name=@name", sqlCon);

                query.Parameters.AddWithValue("@name", textBox1.Text);

                int x = query.ExecuteNonQuery();

                sqlCon.Close();

                if (x > 0) label2.Text = ("Delete Succesfully");
                else label2.Text = "Add Data Properly";
            }
        }
    }
}