namespace diplom
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодстудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодгрупппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаСтудентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетГруппаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бдDataSet = new diplom.бдDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.бдDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетTableAdapter = new diplom.бдDataSetTableAdapters.ФакультетTableAdapter();
            this.группаTableAdapter = new diplom.бдDataSetTableAdapters.ГруппаTableAdapter();
            this.студентыTableAdapter = new diplom.бдDataSetTableAdapters.СтудентыTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.группаСтудентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаСтудентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетГруппаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бдDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бдDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаСтудентыBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources.next;
            this.pictureBox1.Location = new System.Drawing.Point(10, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодстудентаDataGridViewTextBoxColumn,
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.кодгрупппыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группаСтудентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 225);
            this.dataGridView1.TabIndex = 52;
            // 
            // кодстудентаDataGridViewTextBoxColumn
            // 
            this.кодстудентаDataGridViewTextBoxColumn.DataPropertyName = "Код_студента";
            this.кодстудентаDataGridViewTextBoxColumn.HeaderText = "Код_студента";
            this.кодстудентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодстудентаDataGridViewTextBoxColumn.Name = "кодстудентаDataGridViewTextBoxColumn";
            this.кодстудентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерзачетнойкнижкиDataGridViewTextBoxColumn
            // 
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn.DataPropertyName = "Номер_зачетной_книжки";
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn.HeaderText = "Номер_зачетной_книжки";
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn.Name = "номерзачетнойкнижкиDataGridViewTextBoxColumn";
            this.номерзачетнойкнижкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодгрупппыDataGridViewTextBoxColumn
            // 
            this.кодгрупппыDataGridViewTextBoxColumn.DataPropertyName = "Код_групппы";
            this.кодгрупппыDataGridViewTextBoxColumn.HeaderText = "Код_групппы";
            this.кодгрупппыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодгрупппыDataGridViewTextBoxColumn.Name = "кодгрупппыDataGridViewTextBoxColumn";
            this.кодгрупппыDataGridViewTextBoxColumn.Width = 125;
            // 
            // группаСтудентыBindingSource
            // 
            this.группаСтудентыBindingSource.DataMember = "ГруппаСтуденты";
            this.группаСтудентыBindingSource.DataSource = this.факультетГруппаBindingSource;
            // 
            // факультетГруппаBindingSource
            // 
            this.факультетГруппаBindingSource.DataMember = "ФакультетГруппа";
            this.факультетГруппаBindingSource.DataSource = this.факультетBindingSource;
            // 
            // факультетBindingSource
            // 
            this.факультетBindingSource.DataMember = "Факультет";
            this.факультетBindingSource.DataSource = this.бдDataSet;
            // 
            // бдDataSet
            // 
            this.бдDataSet.DataSetName = "бдDataSet";
            this.бдDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(19, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 26);
            this.label8.TabIndex = 61;
            this.label8.Text = "Факультет:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(498, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 94);
            this.panel3.TabIndex = 55;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox8.Location = new System.Drawing.Point(304, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 21);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox9.Location = new System.Drawing.Point(304, 35);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(145, 21);
            this.textBox9.TabIndex = 5;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox13.Location = new System.Drawing.Point(304, 6);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(145, 21);
            this.textBox13.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ортақ баға:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "Дипломдық жұмыс бағасы:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(3, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 26);
            this.label15.TabIndex = 4;
            this.label15.Text = "Емтихан бағасы:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DataSource = this.факультетГруппаBindingSource;
            this.comboBox2.DisplayMember = "Группа";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(621, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(339, 33);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.ValueMember = "Код_группы";
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox18);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(498, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 92);
            this.panel2.TabIndex = 58;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox4.Location = new System.Drawing.Point(116, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(334, 21);
            this.textBox4.TabIndex = 5;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.White;
            this.textBox18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox18.Location = new System.Drawing.Point(7, 29);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(443, 21);
            this.textBox18.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Оқытушы:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(3, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(327, 26);
            this.label19.TabIndex = 4;
            this.label19.Text = "Дипломға таңдалған тақырып:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.факультетBindingSource;
            this.comboBox1.DisplayMember = "Факультет";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 33);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.ValueMember = "Код_факультета";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(545, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Топ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(14, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 141);
            this.panel1.TabIndex = 54;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаСтудентыBindingSource, "Номер_зачетной_книжки", true));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox5.Location = new System.Drawing.Point(202, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(247, 21);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаСтудентыBindingSource, "Отчество", true));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox6.Location = new System.Drawing.Point(202, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(247, 21);
            this.textBox6.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаСтудентыBindingSource, "Имя", true));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Location = new System.Drawing.Point(202, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаСтудентыBindingSource, "Фамилия", true));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(202, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаСтудентыBindingSource, "Код_студента", true));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(202, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сынақ кітапшасы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Әкесінің аты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Аты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тегі:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 26);
            this.label11.TabIndex = 4;
            this.label11.Text = "Студент коды:";
            // 
            // бдDataSetBindingSource
            // 
            this.бдDataSetBindingSource.DataSource = this.бдDataSet;
            this.бдDataSetBindingSource.Position = 0;
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.группаСтудентыBindingSource;
            // 
            // группаСтудентыBindingSource1
            // 
            this.группаСтудентыBindingSource1.DataMember = "ГруппаСтуденты";
            this.группаСтудентыBindingSource1.DataSource = this.факультетГруппаBindingSource;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(830, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 37);
            this.button3.TabIndex = 64;
            this.button3.Text = "Жою";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(660, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 37);
            this.button2.TabIndex = 63;
            this.button2.Text = "Өзгерту";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(498, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 62;
            this.button1.Text = "Қосу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::diplom.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(984, 555);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенттер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаСтудентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетГруппаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бдDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бдDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаСтудентыBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource бдDataSetBindingSource;
        private бдDataSet бдDataSet;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private бдDataSetTableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private System.Windows.Forms.BindingSource факультетГруппаBindingSource;
        private бдDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource группаСтудентыBindingSource;
        private бдDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодстудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзачетнойкнижкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгрупппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource группаСтудентыBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}