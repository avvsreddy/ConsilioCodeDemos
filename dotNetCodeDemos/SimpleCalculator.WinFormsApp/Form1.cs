namespace SimpleCalculator.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fno = int.Parse(textBox1.Text);
            int sno = int.Parse(textBox2.Text);
            SimpleCalculator.ClassLibrary.Calculator calc = new ClassLibrary.Calculator();
            int sum = calc.FindSum(fno, sno);
            MessageBox.Show($"the sum of {fno} and {sno} is {sum}");
        }
    }
}
