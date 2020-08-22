using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant
{
    public partial class Add_Tenant : Form
    {
        string connectionString = @"server=.;Database=Tenant Master;Trusted_Connection=True;";
        public Add_Tenant()
        {
            InitializeComponent();
        }

        void add_data_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    var sqlDa = new SqlDataAdapter();
                    var query = new SqlCommand("INSERT INTO TENANT_MASTER(TENANT_CODE, TENANT_NAME, OCCUPANCY_DATE, FAMILY_MEMBERS, OWNERS, PURCHASE_PRICE, OCCUPIED, MOBILE_NUMBER) VALUES(@code, @name, @date, @family, @owners, @purchase, @occupy, @mobile)", sqlCon);

                    string owners, occ;
                    if (check_box_owners.Checked) { owners = "TRUE"; }
                    else owners = "FALSE";
                    if (check_box_occ.Checked) { occ = "TRUE"; }
                    else occ = "FALSE";
                    query.Parameters.AddWithValue("@code", textBox1.Text);
                    query.Parameters.AddWithValue("@name", textBox2.Text);
                    query.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                    query.Parameters.AddWithValue("@family", numericUpDown1.Text);
                    query.Parameters.AddWithValue("@owners", owners);
                    query.Parameters.AddWithValue("@purchase", textBox3.Text);
                    query.Parameters.AddWithValue("@occupy", occ);
                    query.Parameters.AddWithValue("@mobile", textBox4.Text);

                    query.ExecuteNonQuery();

                    sqlCon.Close();
                }

                catch
                {
                    textBox5.Text = "Add Data Properly";
                }

                textBox5.Text = "Data Added Succesfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.ResetText();
                check_box_owners.Refresh();
                check_box_occ.Refresh();
                numericUpDown1.ResetText();

                Refresh();

                int interval = 15000;
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(interval);
                });
                Close();
            }
            // INSERT INTO TENANT_MASTER(TENANT_CODE, TENANT_NAME, OCCUPANCY_DATE, FAMILY_MEMBERS, OWNERS, PURCHASE_DATE, OCCUPIED, MOBILENUMBER) VALUES(@code, @name, @date, @family, @owners, @purchase, @occupy, @mobile)"
        }
    }
}