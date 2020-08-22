using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tenant
{
    public partial class Display_Tenants : Form
    {
        string connectionString = @"server=.;Database=Tenant Master;Trusted_Connection=True;";
        public Display_Tenants()
        {
            InitializeComponent();
        }

        void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var sqlDa = new SqlDataAdapter("SELECT * FROM TENANT_MASTER", sqlCon);
                var dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridTenant.DataSource = dtbl;
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var form2 = new Add_Tenant();
            form2.Show();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            var form3 = new Delete_Tenant();
            form3.Show();
        }
    }
}