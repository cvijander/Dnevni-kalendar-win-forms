namespace Moj_dnevnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PostaviPraznuAgendu();
        }

        private void btnUpis_Click(object sender, EventArgs e)
        {
            string upis = "";
            upis += "Datum: " + monthCalendar1.SelectionStart.ToLongDateString();
            upis += "\n\n";
            upis += richTextBox1.Text;
            string stariSadrzaj = File.ReadAllText("dnevnik.txt");
            string noviSadrzaj = stariSadrzaj + "\n------------------\n" + upis;
            File.WriteAllText("dnevnik.txt", noviSadrzaj);
            PostaviPraznuAgendu();

            MessageBox.Show("Dogadjaj je uspesno sacuvan");
        }

        private void PostaviPraznuAgendu()
        {
            DateTime danasnjiDan = DateTime.Now;
            monthCalendar1.SelectionStart = danasnjiDan.AddDays(1);
            richTextBox1.Text = "Opis dnevnih aktivnosti:";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "\n" + "08:00 - ";
            richTextBox1.Text += "\n" + "09:00 - ";
            for (int i = 10; i < 22; i++)
            {
                richTextBox1.Text += "\n" + i + ":00 - ";
            }
        }
    }
}