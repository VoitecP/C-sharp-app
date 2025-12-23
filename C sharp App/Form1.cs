using Microsoft.Data.SqlClient;

namespace C_sharp_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                using (SqlConnection conn = database.db.GetConnection()) 
                {
                    conn.Open();
                    string addSqlQuery = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
    }
}
