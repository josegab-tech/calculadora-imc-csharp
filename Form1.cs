namespace WinFormsIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, peso, resultado;

            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);

            resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                txtResult.ForeColor = Color.Green;
            }
            else if ( resultado > 18.5 && resultado < 24.99)
            {
                txtResult.ForeColor = Color.GreenYellow;
            }
            else if(resultado > 25 && resultado < 29.99)
            {
                txtResult.ForeColor = Color.Orange;
            }
            else
            {
                txtResult.ForeColor = Color.Red;
            }
                txtResult.Text = ($"Resultado: {resultado:F2}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
