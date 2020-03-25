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
    public partial class PayrollSheet : Form
    {
        private Main form1;
        public PayrollSheet()
        {
            InitializeComponent();
        }
        public PayrollSheet(Main form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }
        private void FormPayrollSheet_Load(object sender, EventArgs e)
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
            int numberOfWorkDays = Convert.ToInt32(form1.dataGridView1[4, index].Value);
            double rate = Convert.ToDouble(form1.dataGridView1[7, index].Value);
            double experience = Convert.ToDouble(form1.dataGridView1[8, index].Value);
            double sickLeave = Convert.ToDouble(form1.dataGridView1[9, index].Value);
            double premium = Convert.ToDouble(form1.dataGridView1[10, index].Value);
            double tax = Convert.ToDouble(form1.dataGridView1[11, index].Value);
            double salary = form1.CalculateSalary(rate, experience, sickLeave, premium, tax, numberOfWorkDays);
            string position = Convert.ToString(form1.dataGridView2[2, index].Value);

            label5.Text = workerSurname;
            label6.Text = position;
            label7.Text = salary.ToString();
        }
    }
}
