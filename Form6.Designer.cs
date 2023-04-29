namespace diplom
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.факультетГруппаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бдDataSet = new diplom.бдDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.факультетTableAdapter = new diplom.бдDataSetTableAdapters.ФакультетTableAdapter();
            this.группаTableAdapter = new diplom.бдDataSetTableAdapters.ГруппаTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._1TableAdapter = new diplom.бдDataSetTableAdapters._1TableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._2TableAdapter = new diplom.бдDataSetTableAdapters._2TableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._3TableAdapter = new diplom.бдDataSetTableAdapters._3TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетГруппаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бдDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources.next;
            this.pictureBox1.Location = new System.Drawing.Point(10, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(237, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = " тобының студенттерінің үлгерімі бойынша есеп";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 252);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(382, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 30);
            this.textBox2.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(31, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 26);
            this.label3.TabIndex = 68;
            this.label3.Text = "Топтың емтихан орта бағасы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(31, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 26);
            this.label8.TabIndex = 73;
            this.label8.Text = "Факультет:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DataSource = this.факультетГруппаBindingSource;
            this.comboBox2.DisplayMember = "Группа";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(664, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 33);
            this.comboBox2.TabIndex = 72;
            this.comboBox2.ValueMember = "Код_группы";
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.факультетBindingSource;
            this.comboBox1.DisplayMember = "Факультет";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 33);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "Код_факультета";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(591, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 70;
            this.label2.Text = "Топ:";
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "1";
            this.bindingSource1.DataSource = this.бдDataSet;
            // 
            // _1TableAdapter
            // 
            this._1TableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "2";
            this.bindingSource2.DataSource = this.бдDataSet;
            // 
            // _2TableAdapter
            // 
            this._2TableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "3";
            this.bindingSource3.DataSource = this.бдDataSet;
            // 
            // _3TableAdapter
            // 
            this._3TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(705, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 43);
            this.button1.TabIndex = 74;
            this.button1.Text = "MS Word-қа экспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(382, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 30);
            this.textBox1.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(31, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 26);
            this.label4.TabIndex = 75;
            this.label4.Text = "Топтың диплом орта бағасы:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(382, 432);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 30);
            this.textBox3.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(31, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Топтың орта бағасы:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::diplom.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(984, 555);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенттердің улгерімі туралы есеп";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетГруппаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бдDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private бдDataSet бдDataSet;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private бдDataSetTableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private System.Windows.Forms.BindingSource факультетГруппаBindingSource;
        private бдDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private бдDataSetTableAdapters._1TableAdapter _1TableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private бдDataSetTableAdapters._2TableAdapter _2TableAdapter;
        private System.Windows.Forms.BindingSource bindingSource3;
        private бдDataSetTableAdapters._3TableAdapter _3TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}