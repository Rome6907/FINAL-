using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;

namespace Attendance
{
	public partial class Form1 : Form

	{
		public DataGridViewRow row = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void panelback_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}



        private void datatbl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_Shown(object sender, EventArgs e)
		{

			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=grandby_db";
				MySqlConnection con = new MySqlConnection();
				con.ConnectionString = connstring;
				con.Open();
				

				string sql = "SELECT * FROM attendance;";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader dr = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(dr);
				
				con.Close() ;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message); 
				Console.WriteLine(ex.ToString()); 
			}

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void label4_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		

		

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}
		
		private void button4_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();

			form3.Show();
            this.Hide();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            int teacherID = 123; // Replace with the actual ID
            string teacherName = "John Doe"; // Replace with the actual name

            dashboard form = new dashboard(teacherID, teacherName);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance atten = new attendance();
            atten.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration student = new StudentRegistration();
            student.Show();
        }
    }
}
