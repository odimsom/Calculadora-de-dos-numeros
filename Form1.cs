namespace Calculadora_de_dos_numeros
{
    public partial class Form1 : Form
    {
        public string Value { get; set; }

        public Form1()
        {
            InitializeComponent();
            Value = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string num8 = "8";
            textBox1.Text = Value + num8;
            Value = Value + num8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Value = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Value + "x";
            Value = Value + "x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num1 = "1";
            textBox1.Text = Value + num1;
            Value = Value + num1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num2 = "2";
            textBox1.Text = Value + num2;
            Value = Value + num2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num3 = "3";
            textBox1.Text = Value + num3;
            Value = Value + num3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num4 = "4";
            textBox1.Text = Value + num4;
            Value = Value + num4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num5 = "5";
            textBox1.Text = Value + num5;
            Value = Value + num5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string num6 = "6";
            textBox1.Text = Value + num6;
            Value = Value + num6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string num7 = "7";
            textBox1.Text = Value + num7;
            Value = Value + num7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string num9 = "9";
            textBox1.Text = Value + num9;
            Value = Value + num9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string num0 = "0";
            textBox1.Text = Value + num0;
            Value = Value + num0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            (string inicio, string final) = DividirString(Value, 'x');
            int primerValor = Convert.ToInt32(inicio);
            int segundoValor = Convert.ToInt32(final);
            for (int i = 1; i < primerValor; i++)
            {
                segundoValor += primerValor;
            }

            string resultado = Convert.ToString(segundoValor);
            Value = resultado;
            textBox1.Text = Value;
        }

        static (string, string) DividirString(string texto, char valor)
        {
            int indice = texto.IndexOf(valor);

            if (indice != -1)
            {
                string antes = texto.Substring(0, indice);
                string despues = texto.Substring(indice + 1);
                return (antes, despues);
            }
            else
            {
                return (texto, "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
