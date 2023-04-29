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
using exportWord = Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace diplom
{
    public partial class Form6 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=бд.mdb";
        private OleDbConnection myConnection;
        public Form6()
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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet._3". При необходимости она может быть перемещена или удалена.
            this._3TableAdapter.Fill(this.бдDataSet._3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet._2". При необходимости она может быть перемещена или удалена.
            this._2TableAdapter.Fill(this.бдDataSet._2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet._1". При необходимости она может быть перемещена или удалена.
            this._1TableAdapter.Fill(this.бдDataSet._1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.бдDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бдDataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.бдDataSet.Факультет);

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            string quer = "SELECT Фамилия, Имя, Отчество, Оценка_гос, Оценка_диплом, Avg((Оценка_диплом + Оценка_гос) / 2) AS [Орташа баға] " +
                "FROM(Группа INNER JOIN Студенты ON Группа.Код_группы = Студенты.Код_групппы) INNER JOIN Оценки ON Студенты.Код_студента = Оценки.Код_студента " +
                "GROUP BY Группа, Фамилия, Имя, Отчество, Оценка_гос, Оценка_диплом " +
                "HAVING Группа = '" +  comboBox2.Text + "';";
            OleDbDataAdapter da = new OleDbDataAdapter(quer, connectString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            string query = "SELECT Avg(Оценки.Оценка_гос) " +
                "FROM(Группа INNER JOIN Студенты ON Группа.Код_группы = Студенты.Код_групппы) INNER JOIN Оценки ON Студенты.Код_студента = Оценки.Код_студента " +
                "GROUP BY Группа, Студенты.Код_студента " +
                "HAVING Группа = '" + comboBox2.Text + "';";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox2.Text = command.ExecuteScalar().ToString();

            string que = "SELECT Avg(Оценки.Оценка_диплом) " +
                "FROM(Группа INNER JOIN Студенты ON Группа.Код_группы = Студенты.Код_групппы) INNER JOIN Оценки ON Студенты.Код_студента = Оценки.Код_студента " +
                "GROUP BY Группа, Студенты.Код_студента " +
                "HAVING Группа = '" + comboBox2.Text + "';";
            OleDbCommand comma = new OleDbCommand(que, myConnection);
            textBox1.Text = comma.ExecuteScalar().ToString();

            textBox3.Text = Convert.ToString((Convert.ToInt32(textBox1.Text)+Convert.ToInt32(textBox2.Text))/2);
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 11;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = label1.Text;
                    headerRange.Font.Size = 14;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "Студенттердің үлгерімі бойынша есеп.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
                Export_Data_To_Word(dataGridView1, sfd.FileName);
        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = comboBox2.Text + " тобының студенттерінің үлгерімі бойынша есеп";
        }
    }
}
