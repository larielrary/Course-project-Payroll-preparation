using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PaySheet : Form
    {
        private Main form1;
        public PaySheet()
        {
            InitializeComponent();
        }

        public PaySheet(Main form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void FormPaySheet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.enterpriseDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.enterpriseDataSet.Должности);

            int index;

            // взять номер текущей (выделенной) строки в dataGridView1
            index = form1.dataGridView1.CurrentRow.Index;

            // заполнить внутренние переменные из текущей строки dataGridView1
            string workerSurname = Convert.ToString(form1.dataGridView1[1, index].Value);
            string workerName = Convert.ToString(form1.dataGridView1[2, index].Value);
            int numberOfWorkDays = Convert.ToInt32(form1.dataGridView1[4, index].Value);
            double rate = Convert.ToDouble(form1.dataGridView1[7, index].Value);
            double experience = Convert.ToDouble(form1.dataGridView1[8, index].Value);
            double sickLeave = Convert.ToDouble(form1.dataGridView1[9, index].Value);
            double premium = Convert.ToDouble(form1.dataGridView1[10, index].Value);
            double tax = Convert.ToDouble(form1.dataGridView1[11, index].Value);

            label12.Text = rate.ToString();
            label13.Text = experience.ToString();
            label14.Text = sickLeave.ToString();
            label15.Text = premium.ToString();
            label16.Text = tax.ToString();
            label17.Text = form1.CalculateSalary(rate, experience, sickLeave, premium, tax, numberOfWorkDays).ToString();

            label6.Text = workerSurname + " " + workerName;
        }
    }
}
