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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=бд.mdb";
        private OleDbConnection myConnection;
        public Form3()
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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Тема_работы " +
                " FROM Студенты INNER JOIN Темы ON Студенты.Код_студента = Темы.Код_студента " +
                " WHERE Фамилия = '" + textBox2.Text + "';";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox18.Text = command.ExecuteScalar().ToString();

            string quer = "SELECT Преподаватели.Фамилия " +
                "FROM Студенты INNER JOIN(Преподаватели INNER JOIN Темы ON Преподаватели.Код_преподавателя = Темы.Код_преподователя) ON Студенты.Код_студента = Темы.Код_студента " +
                "WHERE Студенты.Фамилия = '" + textBox2.Text + "';";
            OleDbCommand comman = new OleDbCommand(quer, myConnection);
            textBox4.Text = comman.ExecuteScalar().ToString();

            string que = "SELECT Оценка_диплом " +
                "FROM Студенты INNER JOIN Оценки ON Студенты.Код_студента = Оценки.Код_студента " +
                "WHERE Фамилия = '" + textBox2.Text + "';";
            OleDbCommand comma = new OleDbCommand(que, myConnection);
            textBox13.Text = comma.ExecuteScalar().ToString();

            string qu = "SELECT Оценка_гос " +
                "FROM Студенты INNER JOIN Оценки ON Студенты.Код_студента = Оценки.Код_студента " +
                "WHERE Фамилия = '" + textBox2.Text + "';";
            OleDbCommand comm = new OleDbCommand(qu, myConnection);
            textBox9.Text = comm.ExecuteScalar().ToString();

            textBox8.Text = Convert.ToString((Convert.ToInt32(textBox13.Text) + Convert.ToInt32(textBox9.Text)) / 2);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.бдDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.бдDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.бдDataSet.Факультет);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
        public void My_Execute_Non_Query(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             int index;
            string ID;
            string CommandText;

            index = dataGridView1.CurrentRow.Index; // № по порядку в таблице 
            ID = Convert.ToString(dataGridView1[0, index].Value); // ID подаем в запрос как строку
            if (dataGridView1.RowCount != 0)
            {
                DialogResult d;
                d = MessageBox.Show("Жою керек пе?", "Жазба жою", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    CommandText = "DELETE FROM Студенты WHERE Студент_коды = " + ID + "";
                    My_Execute_Non_Query(CommandText);
                }
            }
            */
        }
    }
}
