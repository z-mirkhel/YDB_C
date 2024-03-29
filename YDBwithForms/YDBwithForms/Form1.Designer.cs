namespace YDBwithForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            label5 = new Label();
            buttonCreateOreder = new Button();
            textBoxPriceAll = new TextBox();
            textBoxCountAll = new TextBox();
            groupBox3 = new GroupBox();
            buttonDelete = new Button();
            buttonAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPrice = new TextBox();
            textBoxCount = new TextBox();
            dataGridView1 = new DataGridView();
            comboBoxProduct = new ComboBox();
            groupBox2 = new GroupBox();
            buttonUpdate = new Button();
            label1 = new Label();
            comboBoxFIO = new ComboBox();
            groupBox1 = new GroupBox();
            buttonCreate = new Button();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            buttonDate = new Button();
            dataGridView3 = new DataGridView();
            buttonForm = new Button();
            comboBoxAfter = new ComboBox();
            comboBoxBefore = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(934, 645);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(926, 607);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Новый заказ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkedListBox1);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(buttonCreateOreder);
            groupBox4.Controls.Add(textBoxPriceAll);
            groupBox4.Controls.Add(textBoxCountAll);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(3, 501);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(920, 102);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Итого";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "доставка", "самовывоз" });
            checkedListBox1.Location = new Point(440, 34);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 56);
            checkedListBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 70);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 6;
            label6.Text = "Сумма:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 34);
            label5.Name = "label5";
            label5.Size = new Size(197, 25);
            label5.TabIndex = 5;
            label5.Text = "Общее кол-во товара:";
            // 
            // buttonCreateOreder
            // 
            buttonCreateOreder.BackColor = SystemColors.GradientActiveCaption;
            buttonCreateOreder.Location = new Point(638, 43);
            buttonCreateOreder.Margin = new Padding(3, 4, 3, 4);
            buttonCreateOreder.Name = "buttonCreateOreder";
            buttonCreateOreder.Size = new Size(234, 38);
            buttonCreateOreder.TabIndex = 4;
            buttonCreateOreder.Text = "Оформить заказ";
            buttonCreateOreder.UseVisualStyleBackColor = false;
            buttonCreateOreder.Click += buttonCreateOreder_Click;
            // 
            // textBoxPriceAll
            // 
            textBoxPriceAll.Location = new Point(234, 66);
            textBoxPriceAll.Margin = new Padding(3, 4, 3, 4);
            textBoxPriceAll.Name = "textBoxPriceAll";
            textBoxPriceAll.ReadOnly = true;
            textBoxPriceAll.Size = new Size(151, 31);
            textBoxPriceAll.TabIndex = 3;
            // 
            // textBoxCountAll
            // 
            textBoxCountAll.Location = new Point(234, 30);
            textBoxCountAll.Margin = new Padding(3, 4, 3, 4);
            textBoxCountAll.Name = "textBoxCountAll";
            textBoxCountAll.ReadOnly = true;
            textBoxCountAll.Size = new Size(151, 31);
            textBoxCountAll.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonDelete);
            groupBox3.Controls.Add(buttonAdd);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBoxPrice);
            groupBox3.Controls.Add(textBoxCount);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(comboBoxProduct);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 172);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(920, 348);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выбрать товар";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(804, 25);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(111, 38);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(692, 26);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 38);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 34);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 7;
            label4.Text = "Цена:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 34);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 6;
            label3.Text = "Кол-во:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 36);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Товар:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(592, 29);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(78, 31);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(428, 28);
            textBoxCount.Margin = new Padding(3, 4, 3, 4);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(76, 31);
            textBoxCount.TabIndex = 3;
            textBoxCount.KeyPress += textBoxCount_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(906, 241);
            dataGridView1.TabIndex = 2;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Items.AddRange(new object[] { "Ручка шариковая", "Блокнот А4", "Тетрадь 48 л. клетка", "Карандаши цветные 12 цв." });
            comboBoxProduct.Location = new Point(77, 30);
            comboBoxProduct.Margin = new Padding(3, 4, 3, 4);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(243, 33);
            comboBoxProduct.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonUpdate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxFIO);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 92);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(920, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выбрать клиента";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(393, 22);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(278, 38);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Обновить список клиентов";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 2;
            label1.Text = "ФИО:";
            // 
            // comboBoxFIO
            // 
            comboBoxFIO.FormattingEnabled = true;
            comboBoxFIO.Items.AddRange(new object[] { "Иванов Иван Иванович", "Максимов Максим Александрович", "Александров Антон Эдуардович", "Петров Петр Петрович" });
            comboBoxFIO.Location = new Point(66, 25);
            comboBoxFIO.Margin = new Padding(3, 4, 3, 4);
            comboBoxFIO.Name = "comboBoxFIO";
            comboBoxFIO.Size = new Size(254, 33);
            comboBoxFIO.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCreate);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(920, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новый клиент";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(3, 31);
            buttonCreate.Margin = new Padding(3, 4, 3, 4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(221, 38);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(926, 607);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 4);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 28;
            dataGridView2.Size = new Size(920, 599);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonDate);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(buttonForm);
            tabPage3.Controls.Add(comboBoxAfter);
            tabPage3.Controls.Add(comboBoxBefore);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(926, 607);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Отчеты";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDate
            // 
            buttonDate.Location = new Point(318, 28);
            buttonDate.Margin = new Padding(3, 4, 3, 4);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(278, 38);
            buttonDate.TabIndex = 6;
            buttonDate.Text = "Обновить даты";
            buttonDate.UseVisualStyleBackColor = true;
            buttonDate.Click += buttonDate_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(0, 311);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 28;
            dataGridView3.Size = new Size(926, 296);
            dataGridView3.TabIndex = 5;
            // 
            // buttonForm
            // 
            buttonForm.Location = new Point(371, 242);
            buttonForm.Margin = new Padding(3, 4, 3, 4);
            buttonForm.Name = "buttonForm";
            buttonForm.Size = new Size(172, 38);
            buttonForm.TabIndex = 4;
            buttonForm.Text = "Сформировать";
            buttonForm.UseVisualStyleBackColor = true;
            buttonForm.Click += buttonForm_Click;
            // 
            // comboBoxAfter
            // 
            comboBoxAfter.FormattingEnabled = true;
            comboBoxAfter.Location = new Point(486, 179);
            comboBoxAfter.Margin = new Padding(3, 4, 3, 4);
            comboBoxAfter.Name = "comboBoxAfter";
            comboBoxAfter.Size = new Size(188, 33);
            comboBoxAfter.TabIndex = 3;
            // 
            // comboBoxBefore
            // 
            comboBoxBefore.FormattingEnabled = true;
            comboBoxBefore.Location = new Point(236, 179);
            comboBoxBefore.Margin = new Padding(3, 4, 3, 4);
            comboBoxBefore.Name = "comboBoxBefore";
            comboBoxBefore.Size = new Size(188, 33);
            comboBoxBefore.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(526, 98);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 1;
            label8.Text = "ДО:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 98);
            label7.Name = "label7";
            label7.Size = new Size(39, 25);
            label7.TabIndex = 0;
            label7.Text = "ОТ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 645);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Variant-4";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button buttonCreate;
        private Button buttonCreateOreder;
        private TextBox textBoxPriceAll;
        private TextBox textBoxCountAll;
        private ComboBox comboBoxProduct;
        private ComboBox comboBoxFIO;
        private DataGridView dataGridView1;
        private TextBox textBoxPrice;
        private TextBox textBoxCount;
        private Label label6;
        private Label label5;
        private Button buttonDelete;
        private Button buttonAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        // private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private DataGridView dataGridView2;
        private ComboBox comboBoxBefore;
        private Label label8;
        private Label label7;
        private Button buttonForm;
        private ComboBox comboBoxAfter;
        private Button buttonUpdate;
        private DataGridView dataGridView3;
        private Button buttonDate;
        private CheckedListBox checkedListBox1;
    }
}