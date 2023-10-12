namespace uçak_bilet_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
            listBox1.Items.Add("TC:" + maskedTextBox1.Text);
            listBox1.Items.Add("Telefom:" + maskedTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden:" + comboBox1.Text);
            listBox1.Items.Add("Nereye:" + comboBox2.Text);
            listBox1.Items.Add("Tarih:" + dateTimePicker1.Text);
            listBox1.Items.Add("Kalkış Saati:" + maskedTextBox3.Text);
            listBox1.Items.Add("İniş Saati:" + maskedTextBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label6.Text;
        }
    }
}