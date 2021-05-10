using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sarracherif
namespace EasyPlant
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        private void Authentification_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            ParametrageBase.parametrerBase();
            txtServerName.Text = ParametrageBase.serverName;
            if (ParametrageBase.connectionMode == "SQL")
            {
                rdBtnSql.Checked = true;
                rdBtnWindows.Checked = false;
            }
            else
            {
                rdBtnSql.Checked = false;
                rdBtnWindows.Checked = true;
            }
            cmbBD.Text = ParametrageBase.dataBaseName;
            ParametrageBase.attachDatabase();

            }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT  CodeUtilisateur, Password FROM Utilisateur  WHERE CodeUtilisateur = @Username";

            using (SqlConnection conn = new SqlConnection(ParametrageBase.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //add a parameter to sql query
                    cmd.Parameters.AddWithValue("Username", txtUsername.Text);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //read the first row that reader returned and save password from DB into variable
                            reader.Read();
                            string username = reader["CodeUtilisateur"].ToString();
                            string password = reader["Password"].ToString();
                            if (reader.Read() == true)
                            {

                                return;
                            }

                            else if (txtPassword.Text == password)
                            {
                                this.Visible = false;
                                //MainMenu main = new MainMenu();
                                //main.ShowDialog();
                                //MessageBox.Show("Authentification reussite", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Menu form_menu = new Menu();
                                form_menu.Show();
                                
                                
                            }
                            else if (txtUsername.Text != username || txtPassword.Text != password)
                            {
                                MessageBox.Show("Password not Valid, Please TryAgain", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Access Please TryAgain", "UserLogin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
