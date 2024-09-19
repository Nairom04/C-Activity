namespace studentregistrationapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
            {
                comboDay.Items.Add(i);
            }

            
            for (int i = 1; i <= 12; i++)
            {
                comboMonth.Items.Add(i);
            }

            
            int currentYear = DateTime.Now.Year;
            for (int i = 1900; i <= currentYear; i++)
            {
                comboYear.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lastname = lastName.Text;
            String firstname = firstName.Text;
            String middlename = middleName.Text;
            string day = comboDay.SelectedItem.ToString();
            string month = comboMonth.SelectedItem.ToString();
            string year = comboYear.SelectedItem.ToString();
            string gender = radioMale.Checked ? "Male" : "Female";

            string message = $"Student name: {firstname} {middlename} {lastname}\n" +
                             $"Gender: {gender}\n" +
                             $"Date of Birth: {day}/{month}/{year}";

            MessageBox.Show(message);
            
        }
    }
}
