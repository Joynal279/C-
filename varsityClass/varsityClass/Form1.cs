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

namespace varsityClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-G25F8TG\JOYNAL;Initial Catalog=joynal;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            student stu = new student();
            stu.Email = emailTextBox.Text;
            stu.Password = passwordTextBox.Text;
            string query = "insert into Users (Email,Password)values('"+stu.Email+"','"+stu.Password+"')";
            SqlCommand command = new SqlCommand(query,connection);
            int row=command.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("inserted");
            }
            connection.Close();

        }
    }
}
