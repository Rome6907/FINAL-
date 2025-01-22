using DGVPrinterHelper;
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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void Class_Data()
        {
            dgvClass.Rows.Clear();
            dgvClass.Rows.Add("GC-27412", "3C" , "Jelmer Soria", "Male");
            dgvClass.Rows.Add("GC-27412", "3C", "Jelmer Soria", "Male");
            dgvClass.Rows.Add("GC-27412", "3C", "Jelmer Soria", "Male");
            dgvClass.Rows.Add("GC-27412", "3C", "Jelmer Soria", "Male");
        }

        private void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Attendance Sheet";
            if (txtBoxInstructorName.Text.Trim() == string.Empty)
                printer.SubTitle = dtpCurrentDate.Text + "\n";
            else
                printer.SubTitle = txtBoxInstructorName.Text.Trim() + "\n" + dtpCurrentDate.Text + "\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(dgvClass);

        }

        private void attendance_Load(object sender, EventArgs e)
        {
            Class_Data();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Print();
        }

       

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            int teacherID = 123; // Replace with the actual ID
            string teacherName = "John Doe"; // Replace with the actual name

            dashboard form = new dashboard(teacherID, teacherName);
            form.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration student = new StudentRegistration();
            student.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
