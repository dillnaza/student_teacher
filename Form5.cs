using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace diplom
{
    public partial class Form5 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=бд.mdb";
        private OleDbConnection myConnection;

        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
            //Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Код_преподователя " +
               "FROM Преподаватели INNER JOIN Темы ON Преподаватели.Код_преподавателя = Темы.Код_преподователя " +
               "GROUP BY Фамилия, Код_преподователя " +
               "HAVING Фамилия = '" + comboBox1.Text + "';";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox18.Text = command.ExecuteScalar().ToString();

            string quer = "SELECT Тема_работы " +
                "FROM Преподаватели INNER JOIN Темы ON Преподаватели.Код_преподавателя = Темы.Код_преподователя " +
                "GROUP BY Фамилия, Тема_работы " +
                "HAVING Фамилия = '" + comboBox1.Text + "';";
            OleDbCommand comman = new OleDbCommand(quer, myConnection);
            OleDbDataReader reader = comman.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
                listBox1.Items.Add(reader[0].ToString() + " ");
            reader.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.бдDataSet.Преподаватели);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
