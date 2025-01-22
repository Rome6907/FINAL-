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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Attendance
{
    public partial class StudentRegistration : Form
    {
        int index;
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Add
        {
            if (ValidateInput() && ValidateCourse())
            {
                dgvTable.Rows.Add(studentid.Text, fname.Text, lname.Text, section.Text, course.Text);
                ClearFields();
            } 
            else if (!ValidateCourse())
            {
                MessageBox.Show("Please enter a valid course. Allowed courses are BSCRIM, BSA, BSTM, BSIT, BSCS, BSED, BEED, BSBA, BSISM, with a maximum of 6 characters.",
                                "Course Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please fill out all fields before adding a record.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Update
        {
            if (index >= 0 && ValidateInput() && ValidateCourse())
            {
                DataGridViewRow newdata = dgvTable.Rows[index];
                newdata.Cells[0].Value = studentid.Text;
                newdata.Cells[1].Value = fname.Text;
                newdata.Cells[2].Value = lname.Text;
                newdata.Cells[3].Value = section.Text;
                newdata.Cells[4].Value = course.Text;
                ClearFields();
            }
            else if (index < 0)
            {
                MessageBox.Show("Please select a record to update.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateCourse())
            {
                MessageBox.Show("Please enter a valid course. Allowed courses are BSCRIM, BSA, BSTM, BSIT, BSCS, BSED, BEED, BSBA, BSISM, with a maximum of 6 characters.",
                                "Course Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please fill out all fields before updating a record.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Delete
        {
            if (index >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvTable.Rows.RemoveAt(index);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                DataGridViewRow row = dgvTable.Rows[index];
                studentid.Text = row.Cells[0].Value?.ToString();
                fname.Text = row.Cells[1].Value?.ToString();
                lname.Text = row.Cells[2].Value?.ToString();
                section.Text = row.Cells[3].Value?.ToString();
                course.Text = row.Cells[4].Value?.ToString();
            }
        }
        private bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(studentid.Text) &&
                   !string.IsNullOrWhiteSpace(fname.Text) &&
                   !string.IsNullOrWhiteSpace(lname.Text) &&
                   !string.IsNullOrWhiteSpace(section.Text) &&
                   !string.IsNullOrWhiteSpace(course.Text);
        }

        // Helper Method for Course Validation
        private bool ValidateCourse()
        {
            List<string> validCourses = new List<string> { "BSCRIM", "BSA", "BSTM", "BSIT", "BSCS", "BSED", "BEED", "BSBA", "BSISM" }; // Valid courses
            string courseInput = course.Text.Trim().ToUpper(); // Normalize input to uppercase
            return courseInput.Length <= 6 && validCourses.Contains(courseInput);
        }

        // Helper Method to Clear Input Fields
        private void ClearFields()
        {
            studentid.Text = string.Empty;
            fname.Text = string.Empty;
            lname.Text = string.Empty;
            section.Text = string.Empty;
            course.Text = string.Empty;
            index = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance atten = new attendance();
            atten.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            int teacherID = 123; // Replace with the actual ID
            string teacherName = "John Doe"; // Replace with the actual name

            dashboard form = new dashboard(teacherID, teacherName);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}