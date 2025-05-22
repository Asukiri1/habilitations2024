using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace habilitations2024.view
{
    public partial class FrmHabitilations : Form
    {
        public FrmHabitilations()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=habilitations;User Id=habilitations;Password=motdepasseuser;";
            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : \n" + ex.Message, "Erreur MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
