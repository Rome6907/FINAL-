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

namespace Attendance
{
    public partial class FormAddSection : Form
    {
        public FormAddSection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            }

        private void FormAddSection_Load(object sender, EventArgs e)
        {
            string connstring = "Server=localhost;Database=granby_db;Uid=root;";
            string query = "SELECT studentID, firstname, lastname FROM student_record";

            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt; // Bind directly to DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration student = new StudentRegistration();
            student.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

