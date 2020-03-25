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
    public partial class EnterpriceReport : Form
    {
        private Main form1;
        public EnterpriceReport()
        {
            InitializeComponent();
        }
        public EnterpriceReport(Main form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
        }
        private void FormEnterpriceReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            должностиTableAdapter.Fill(this.enterpriseDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            сотрудникиTableAdapter.Fill(this.enterpriseDataSet.Сотрудники);
            double sumRate = 0;
            double sumExperience = 0;
            double sumSickLeave = 0;
            double sumPremium = 0;
            double sumTax = 0;
               
            for (int i = 0; i < form1.dataGridView1.RowCount-1; i++)
            {
                // int index = form1.dataGridView1.CurrentRow.Index;
                int numberOfWorkDays = Convert.ToInt32(form1.dataGridView1[4, i].Value);
                double rate = Convert.ToDouble(form1.dataGridView1[7, i].Value);
                double experience = Convert.ToDouble(form1.dataGridView1[8, i].Value);
                double sickLeave = Convert.ToDouble(form1.dataGridView1[9, i].Value);
                double premium = Convert.ToDouble(form1.dataGridView1[10, i].Value);
                double tax = Convert.ToDouble(form1.dataGridView1[11, i].Value);
                sumRate += (rate*(numberOfWorkDays/30));
                sumExperience += experience;
                sumSickLeave += sickLeave;
                sumPremium += premium;
                sumTax += tax;

                double salary = sumRate + sumExperience + sumSickLeave + sumPremium - sumTax;

                label7.Text = sumRate.ToString();
                label8.Text = sumExperience.ToString();
                label9.Text = sumSickLeave.ToString();
                label10.Text = sumPremium.ToString();
                label15.Text = sumTax.ToString();
                label16.Text = salary.ToString();
            }
            
        }
    }
}
