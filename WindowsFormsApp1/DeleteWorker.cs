using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DeleteWorker : Form
    {
        public Main form1;
        public DeleteWorker()
        {
            InitializeComponent();
        }
        public DeleteWorker(Main form1, EventArgs e)
        {
            InitializeComponent();
            this.form1 = form1;
            ShowDialog();
            FormDeleteWorker_Load(this, e);

        }
        public void FormDeleteWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            сотрудникиTableAdapter1.Fill(this.enterpriseDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            должностиTableAdapter1.Fill(this.enterpriseDataSet1.Должности);

            int index;

            // взять номер текущей (выделенной) строки в dataGridView1
            index = form1.dataGridView1.CurrentRow.Index;

            // заполнить внутренние переменные из текущей строки dataGridView1
            int workerID = Convert.ToInt32(form1.dataGridView1[0, index].Value);
            string workerSurname = Convert.ToString(form1.dataGridView1[1, index].Value); ;
            string workerName = Convert.ToString(form1.dataGridView1[2, index].Value);
            string workerPatronymic = Convert.ToString(form1.dataGridView1[3, index].Value);
            int numberOfWorkDays = Convert.ToInt32(form1.dataGridView1[4, index].Value);
            int cardNumber = Convert.ToInt32(form1.dataGridView1[5, index].Value);
            int positionID = Convert.ToInt32(form1.dataGridView1[6, index].Value);
            int rate = Convert.ToInt32(form1.dataGridView1[7, index].Value);
            int experience = Convert.ToInt32(form1.dataGridView1[8, index].Value);
            int sickLeave = Convert.ToInt32(form1.dataGridView1[9, index].Value);
            int premium = Convert.ToInt32(form1.dataGridView1[10, index].Value);
            int tax = Convert.ToInt32(form1.dataGridView1[11, index].Value);
            Worker worker = new Worker(workerID, workerSurname, workerName, workerPatronymic, numberOfWorkDays, cardNumber, positionID, rate, experience, sickLeave, premium, tax);

            // сформировать информационную строку
            label2.Text = workerSurname + " " + workerName;

            if (DialogResult == DialogResult.OK)
            {
                сотрудникиTableAdapter1.Delete(rate, experience, sickLeave, premium, workerID, workerSurname, workerName, workerPatronymic, numberOfWorkDays, cardNumber, positionID, tax); // метод Delete
                сотрудникиTableAdapter1.Fill(enterpriseDataSet1.Сотрудники);
            }
        }
    }
}