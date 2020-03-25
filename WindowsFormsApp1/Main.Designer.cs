namespace WindowsFormsApp1
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paySheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьВызачиЗарплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьПереводаНаКарточкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоПредприятиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодДолжностиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterpriseDataSet1 = new WindowsFormsApp1.EnterpriseDataSet();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодОтделаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new WindowsFormsApp1.EnterpriseDataSetTableAdapters.TableAdapterManager();
            this.должностиTableAdapter1 = new WindowsFormsApp1.EnterpriseDataSetTableAdapters.ДолжностиTableAdapter();
            this.отделенияTableAdapter1 = new WindowsFormsApp1.EnterpriseDataSetTableAdapters.ОтделенияTableAdapter();
            this.сотрудникиTableAdapter1 = new WindowsFormsApp1.EnterpriseDataSetTableAdapters.СотрудникиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКарточкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.больничныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.премияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нДФЛDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 20);
            this.toolStripMenuItem1.Text = "Работа с сотрудниками";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paySheetToolStripMenuItem,
            this.ведомостьВызачиЗарплатыToolStripMenuItem,
            this.ведомостьПереводаНаКарточкуToolStripMenuItem,
            this.отчетПоПредприятиюToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // paySheetToolStripMenuItem
            // 
            this.paySheetToolStripMenuItem.Name = "paySheetToolStripMenuItem";
            this.paySheetToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.paySheetToolStripMenuItem.Text = "Расчетный листок";
            this.paySheetToolStripMenuItem.Click += new System.EventHandler(this.paySheetToolStripMenuItem_Click);
            // 
            // ведомостьВызачиЗарплатыToolStripMenuItem
            // 
            this.ведомостьВызачиЗарплатыToolStripMenuItem.Name = "ведомостьВызачиЗарплатыToolStripMenuItem";
            this.ведомостьВызачиЗарплатыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.ведомостьВызачиЗарплатыToolStripMenuItem.Text = "Ведомость вызачи зар.платы";
            this.ведомостьВызачиЗарплатыToolStripMenuItem.Click += new System.EventHandler(this.payrollSheetToolStripMenuItem_Click);
            // 
            // ведомостьПереводаНаКарточкуToolStripMenuItem
            // 
            this.ведомостьПереводаНаКарточкуToolStripMenuItem.Name = "ведомостьПереводаНаКарточкуToolStripMenuItem";
            this.ведомостьПереводаНаКарточкуToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.ведомостьПереводаНаКарточкуToolStripMenuItem.Text = "Ведомость перевода на карточку";
            this.ведомостьПереводаНаКарточкуToolStripMenuItem.Click += new System.EventHandler(this.translationListToolStripMenuItem_Click);
            // 
            // отчетПоПредприятиюToolStripMenuItem
            // 
            this.отчетПоПредприятиюToolStripMenuItem.Name = "отчетПоПредприятиюToolStripMenuItem";
            this.отчетПоПредприятиюToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.отчетПоПредприятиюToolStripMenuItem.Text = "Отчет по предприятию";
            this.отчетПоПредприятиюToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудники";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДолжностиDataGridViewTextBoxColumn1,
            this.кодОтделаDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.должностиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(14, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(316, 253);
            this.dataGridView2.TabIndex = 4;
            // 
            // кодДолжностиDataGridViewTextBoxColumn1
            // 
            this.кодДолжностиDataGridViewTextBoxColumn1.DataPropertyName = "Код должности";
            this.кодДолжностиDataGridViewTextBoxColumn1.HeaderText = "Код должности";
            this.кодДолжностиDataGridViewTextBoxColumn1.Name = "кодДолжностиDataGridViewTextBoxColumn1";
            // 
            // кодОтделаDataGridViewTextBoxColumn
            // 
            this.кодОтделаDataGridViewTextBoxColumn.DataPropertyName = "Код отдела";
            this.кодОтделаDataGridViewTextBoxColumn.HeaderText = "Код отдела";
            this.кодОтделаDataGridViewTextBoxColumn.Name = "кодОтделаDataGridViewTextBoxColumn";
            this.кодОтделаDataGridViewTextBoxColumn.Visible = false;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.enterpriseDataSet1;
            // 
            // enterpriseDataSet1
            // 
            this.enterpriseDataSet1.DataSetName = "EnterpriseDataSet";
            this.enterpriseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодОтделаDataGridViewTextBoxColumn1,
            this.названиеОтделаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.отделенияBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(422, 309);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(301, 253);
            this.dataGridView3.TabIndex = 5;
            // 
            // кодОтделаDataGridViewTextBoxColumn1
            // 
            this.кодОтделаDataGridViewTextBoxColumn1.DataPropertyName = "Код отдела";
            this.кодОтделаDataGridViewTextBoxColumn1.HeaderText = "Код отдела";
            this.кодОтделаDataGridViewTextBoxColumn1.Name = "кодОтделаDataGridViewTextBoxColumn1";
            // 
            // названиеОтделаDataGridViewTextBoxColumn
            // 
            this.названиеОтделаDataGridViewTextBoxColumn.DataPropertyName = "Название отдела";
            this.названиеОтделаDataGridViewTextBoxColumn.HeaderText = "Название отдела";
            this.названиеОтделаDataGridViewTextBoxColumn.Name = "названиеОтделаDataGridViewTextBoxColumn";
            // 
            // отделенияBindingSource
            // 
            this.отделенияBindingSource.DataMember = "Отделения";
            this.отделенияBindingSource.DataSource = this.enterpriseDataSet1;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(827, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.enterpriseDataSet1;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.EnterpriseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ДолжностиTableAdapter = this.должностиTableAdapter1;
            this.tableAdapterManager1.ОтделенияTableAdapter = this.отделенияTableAdapter1;
            this.tableAdapterManager1.СотрудникиTableAdapter = this.сотрудникиTableAdapter1;
            // 
            // должностиTableAdapter1
            // 
            this.должностиTableAdapter1.ClearBeforeFill = true;
            // 
            // отделенияTableAdapter1
            // 
            this.отделенияTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn,
            this.номерКарточкиDataGridViewTextBoxColumn,
            this.кодДолжностиDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn,
            this.стажDataGridViewTextBoxColumn,
            this.больничныйDataGridViewTextBoxColumn,
            this.премияDataGridViewTextBoxColumn,
            this.нДФЛDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 244);
            this.dataGridView1.TabIndex = 7;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            this.кодСотрудникаDataGridViewTextBoxColumn.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // количествоОтработанныхДнейDataGridViewTextBoxColumn
            // 
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество отработанных дней";
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.HeaderText = "Количество отработанных дней";
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.Name = "количествоОтработанныхДнейDataGridViewTextBoxColumn";
            // 
            // номерКарточкиDataGridViewTextBoxColumn
            // 
            this.номерКарточкиDataGridViewTextBoxColumn.DataPropertyName = "Номер карточки";
            this.номерКарточкиDataGridViewTextBoxColumn.HeaderText = "Номер карточки";
            this.номерКарточкиDataGridViewTextBoxColumn.Name = "номерКарточкиDataGridViewTextBoxColumn";
            // 
            // кодДолжностиDataGridViewTextBoxColumn
            // 
            this.кодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код должности";
            this.кодДолжностиDataGridViewTextBoxColumn.HeaderText = "Код должности";
            this.кодДолжностиDataGridViewTextBoxColumn.Name = "кодДолжностиDataGridViewTextBoxColumn";
            // 
            // окладDataGridViewTextBoxColumn
            // 
            this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
            this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
            // 
            // стажDataGridViewTextBoxColumn
            // 
            this.стажDataGridViewTextBoxColumn.DataPropertyName = "Стаж";
            this.стажDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.стажDataGridViewTextBoxColumn.Name = "стажDataGridViewTextBoxColumn";
            // 
            // больничныйDataGridViewTextBoxColumn
            // 
            this.больничныйDataGridViewTextBoxColumn.DataPropertyName = "Больничный";
            this.больничныйDataGridViewTextBoxColumn.HeaderText = "Больничный";
            this.больничныйDataGridViewTextBoxColumn.Name = "больничныйDataGridViewTextBoxColumn";
            // 
            // премияDataGridViewTextBoxColumn
            // 
            this.премияDataGridViewTextBoxColumn.DataPropertyName = "Премия";
            this.премияDataGridViewTextBoxColumn.HeaderText = "Премия";
            this.премияDataGridViewTextBoxColumn.Name = "премияDataGridViewTextBoxColumn";
            // 
            // нДФЛDataGridViewTextBoxColumn
            // 
            this.нДФЛDataGridViewTextBoxColumn.DataPropertyName = "НДФЛ";
            this.нДФЛDataGridViewTextBoxColumn.HeaderText = "НДФЛ";
            this.нДФЛDataGridViewTextBoxColumn.Name = "нДФЛDataGridViewTextBoxColumn";
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.enterpriseDataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система для расчета заработной платы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paySheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьВызачиЗарплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьПереводаНаКарточкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоПредприятиюToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn надбавкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заработнаяПлатаDataGridViewTextBoxColumn;
        private EnterpriseDataSet enterpriseDataSet1;
        private EnterpriseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private EnterpriseDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter1;
        private EnterpriseDataSetTableAdapters.ОтделенияTableAdapter отделенияTableAdapter1;
        private EnterpriseDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОтделаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource отделенияBindingSource;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОтделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоОтработанныхДнейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКарточкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn больничныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn премияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нДФЛDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}