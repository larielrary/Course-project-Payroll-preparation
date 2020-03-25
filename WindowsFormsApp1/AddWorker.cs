using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class AddWorker : Form
    {
        public Main form1;
        public AddWorker()
        {
            InitializeComponent();
        }
        public AddWorker(Main form1, EventArgs e)
        {
            InitializeComponent();
            this.form1 = form1;
            this.ShowDialog();
            FormAddWorker_Load(this, e);

        }
        public void FormAddWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            сотрудникиTableAdapter1.Fill(this.enterpriseDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "enterpriseDataSet.Должности". При необходимости она может быть перемещена или удалена.
            должностиTableAdapter1.Fill(this.enterpriseDataSet1.Должности);

            bool checkData = false;

            do
            {
                if (DialogResult == DialogResult.OK)
                {
                    string patternNumber = "^[0-9]";
                    string patternText = "^[а-яА-я]";

                    string workerSurname = textBox1.Text;
                    string workerName = textBox2.Text;
                    string workerPatronymic = textBox3.Text;
                    int numberOfWorkDays = Convert.ToInt32(textBox6.Text);
                    int cardNumber = Convert.ToInt32(textBox5.Text);
                    int positionID = Convert.ToInt32(textBox6.Text);
                    int rate = Convert.ToInt32(textBox7.Text);
                    int experience = Convert.ToInt32(textBox4.Text);
                    int sickLeave = Convert.ToInt32(textBox10.Text);
                    int premium = Convert.ToInt32(textBox11.Text);
                    int tax = Convert.ToInt32(textBox12.Text);
                    int workerID = Convert.ToInt32(textBox8.Text);
                    Worker worker = new Worker(workerID, workerSurname, workerName, workerPatronymic, numberOfWorkDays, cardNumber, positionID, rate, experience, sickLeave, premium, tax);
                    // работает
                    Regex regex1 = new Regex(patternNumber);
                    Match match1 = regex1.Match(numberOfWorkDays.ToString());
                    Match match2 = regex1.Match(cardNumber.ToString());
                    Match match3 = regex1.Match(positionID.ToString());
                    Match match4 = regex1.Match(rate.ToString());
                    Match match5 = regex1.Match(experience.ToString());
                    Match match6 = regex1.Match(sickLeave.ToString());
                    Match match7 = regex1.Match(premium.ToString());
                    Match match8 = regex1.Match(tax.ToString());

                    Regex regex2 = new Regex(patternText);
                    Match match9 = regex2.Match(workerSurname);
                    Match match10 = regex2.Match(workerName);
                    Match match11 = regex2.Match(workerPatronymic);
                    if (!match1.Success && !match2.Success && !match3.Success && !match4.Success &&
                        !match5.Success && !match6.Success && !match7.Success && !match8.Success &&
                        !match9.Success && !match10.Success && !match11.Success)
                    {
                        checkData = true;
                        сотрудникиTableAdapter1.Insert(rate, experience, sickLeave, premium, workerID, workerSurname, workerName, workerPatronymic, numberOfWorkDays, cardNumber, positionID, tax); // вставка
                        сотрудникиTableAdapter1.Fill(enterpriseDataSet1.Сотрудники); // отображение
                    }
                    else
                    {
                        ErrorData errorData = new ErrorData();
                        errorData.ShowDialog();
                        if (DialogResult == DialogResult.OK) errorData.Close();
                        this.ShowDialog();
                    }
                }
            } while (checkData);
        }
    }
}
