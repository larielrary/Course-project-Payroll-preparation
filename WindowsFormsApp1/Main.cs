using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделенияTableAdapter1.Fill(this.enterpriseDataSet1.Отделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter1.Fill(this.enterpriseDataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.enterpriseDataSet1.Сотрудники);

        }
      

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _ = new AddWorker(this, e); // создать форму


        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new DeleteWorker(this, e); // создать форму

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new EditWorker(this, e); // создать форму


        }
        private void paySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaySheet formPaySheet = new PaySheet(this);
            formPaySheet.ShowDialog();
        }
        private void payrollSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollSheet formPayrollSheet = new PayrollSheet(this);
            formPayrollSheet.ShowDialog();
        }
        private void translationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranslationList formTranslationList = new TranslationList(this);
            formTranslationList.ShowDialog();
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterpriceReport formEnterpriceReport = new EnterpriceReport(this);
            formEnterpriceReport.ShowDialog();
        }
        public double CalculateSalary (double rate, double experience, double sickLeave, double premium, double tax, int numberOfWorkDays)
        {
            return rate * (numberOfWorkDays / 30) + experience + sickLeave + premium - tax;
        }
    }
}
