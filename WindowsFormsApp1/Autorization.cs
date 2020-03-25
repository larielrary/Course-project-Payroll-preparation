using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace WindowsFormsApp1
{
    public partial class Autorization : Form
    {
        public void Main()
        {
            
        }
        public Autorization()
        {
            InitializeComponent();
            
        }
        private void OKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool checkAutorization = false;
            using (TextFieldParser textFieldParser = new TextFieldParser("users.csv"))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(",");

                while (!textFieldParser.EndOfData)
                {
                    string[] fields = textFieldParser.ReadFields();
                    if (login == fields[0] && password == fields[1])
                    {
                        checkAutorization = true;
                        Main form1 = new Main();
                        form1.ShowDialog(this);

                        Hide();
                        var formAutorization = new Autorization();
                        formAutorization.Closed += (s, args) => Close();
                        formAutorization.Show();
                    }
                }
                if(!checkAutorization)
                {
                    ErroeAutorization erroeAutorization = new ErroeAutorization();
                    erroeAutorization.ShowDialog();
                    if (DialogResult == DialogResult.OK) erroeAutorization.Close();
                }

            }

        }
        private void CancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
