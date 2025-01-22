using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Attendance
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Server=localhost;Database=granby_db;Uid=root;";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();


                string sqlInsert = "INSERT INTO `user_account` (`Username`, `Password`, `Name`) VALUES (@Username, @Password, @Name)";
                MySqlCommand cmd = new MySqlCommand(sqlInsert, con);
               
                cmd.Parameters.AddWithValue("@Password", password.Text);
                int value = cmd.ExecuteNonQuery();
                if (value > 0)
                {
                    MessageBox.Show("Account created successfully!");
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();
                
                    
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                

            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
