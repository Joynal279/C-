using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_ManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            string ConnectionString =@"Data Source=DESKTOP-G25F8TG\JOYNAL;Initial Catalog=Student Management_DB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            student aStudent = new student();
            aStudent.Id = Convert.ToInt32(textBoxId.Text);
            aStudent.Name = textBoxName.Text;
            aStudent.Dept = textBoxDept.Text;
            string query = "INSERT INTO Stu (Id,Name,Dept)values('"+aStudent.Id+"','"+aStudent.Name+"','"+aStudent.Dept+"')";
            SqlCommand command = new SqlCommand(query, connection);
            int row = command.ExecuteNonQuery();
            if (row>0)
            {
                MessageBox.Show("Inserted");
            }
        }
    }
}
