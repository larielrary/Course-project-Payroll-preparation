using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class EditWorker : Form
    {
        public Main form1;
        public EditWorker()
        {
            InitializeComponent();
        }
        public EditWorker(Main form1, EventArgs e)
        {
            InitializeComponent();
            this.form1 = form1;
            ShowDialog();
            FormEditWorker_Load(this, e);

        }
        public void FormEditWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            сотрудникиTableAdapter1.Fill(enterpriseDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            должностиTableAdapter1.Fill(enterpriseDataSet1.Должности);

            int index;

            if (form1.dataGridView1.RowCount <= 1) return;

            // получить позицию выделенной строки в dataGridView1
            index = form1.dataGridView1.CurrentRow.Index;

            if (index == form1.dataGridView1.RowCount - 1) return; //

            // получить данные строки
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
            // заполнить поля формы f
            textBox1.Text = workerSurname;
            textBox2.Text = workerName;
            textBox3.Text = workerPatronymic;
            textBox9.Text = numberOfWorkDays.ToString();
            textBox5.Text = cardNumber.ToString();
            textBox6.Text = positionID.ToString();
            textBox7.Text = rate.ToString();
            textBox4.Text = experience.ToString();
            textBox10.Text = sickLeave.ToString();
            textBox11.Text = premium.ToString();
            textBox12.Text = tax.ToString();
            textBox8.Text = workerID.ToString();




            bool checkData = false;

            do
            {
                if (DialogResult == DialogResult.OK) // вызвать форму FormEditWorker
                {
                    // получить новые (измененные) значения из формы
                    string patternNumber = "^[0-9]";
                    string patternText = "^[а-яА-я]";

                    string newWorkerSurname = textBox1.Text;
                    string newWorkerName = textBox2.Text;
                    string newWorkerPatronymic = textBox3.Text;
                    int newNumberOfWorkDays = Convert.ToInt32(textBox9.Text);
                    int newCardNumber = Convert.ToInt32(textBox5.Text);
                    int newPositionID = Convert.ToInt32(textBox6.Text);
                    int newRate = Convert.ToInt32(textBox7.Text);
                    int newExperience = Convert.ToInt32(textBox4.Text);
                    int newSickLeave = Convert.ToInt32(textBox10.Text);
                    int newPremium = Convert.ToInt32(textBox11.Text);
                    int newTax = Convert.ToInt32(textBox12.Text);

                    Regex regex1 = new Regex(patternNumber);
                    Match match1 = regex1.Match(newNumberOfWorkDays.ToString());
                    Match match2 = regex1.Match(newCardNumber.ToString());
                    Match match3 = regex1.Match(newPositionID.ToString());
                    Match match4 = regex1.Match(newRate.ToString());
                    Match match5 = regex1.Match(newExperience.ToString());
                    Match match6 = regex1.Match(newSickLeave.ToString());
                    Match match7 = regex1.Match(newPremium.ToString());
                    Match match8 = regex1.Match(newTax.ToString());

                    Regex regex2 = new Regex(patternText);
                    Match match9 = regex2.Match(newWorkerSurname);
                    Match match10 = regex2.Match(newWorkerName);
                    Match match11 = regex2.Match(newWorkerPatronymic);

                    if (!match1.Success && !match2.Success && !match3.Success && !match4.Success &&
                        !match5.Success && !match6.Success && !match7.Success && !match8.Success &&
                        !match9.Success && !match10.Success && !match11.Success)
                    {
                        checkData = true;
                        // сделать изменения в адаптере
                        сотрудникиTableAdapter1.Update(newRate, newExperience, newSickLeave, newPremium, workerID, newWorkerSurname, newWorkerName, newWorkerPatronymic, newNumberOfWorkDays, newCardNumber, newPositionID, newTax, rate, experience, sickLeave, premium, workerID, workerSurname, workerName, workerPatronymic, numberOfWorkDays, cardNumber, positionID, tax);
                        сотрудникиTableAdapter1.Fill(enterpriseDataSet1.Сотрудники);
                    }
                    else
                    {
                        ErrorData errorData = new ErrorData();
                        errorData.ShowDialog();
                        if (DialogResult == DialogResult.OK) errorData.Close();
                        this.ShowDialog();
                    }

                    
                }
            }
            while (checkData);
        }
    }
}
