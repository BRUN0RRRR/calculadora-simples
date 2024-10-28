using System.Configuration;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1, valor2;

            if (float.TryParse(textBox1.Text, out valor1) && float.TryParse(textBox2.Text, out valor2))
            {
                if (radioButton1.Checked == true)
                {
                    float resultados = valor1 + valor2;
                    textBox3.Text = resultados.ToString();
                    resultados = 0;

                }
                else if (radioButton2.Checked == true)
                {
                    float resultados = valor1 - valor2;
                    textBox3.Text = resultados.ToString();
                    resultados = 0;

                }
                else if (radioButton3.Checked == true)
                {
                    float resultados = valor1 * valor2;
                    textBox3.Text = resultados.ToString();
                    resultados = 0;
                }
                else if (radioButton4.Checked == true)
                {
                    float resultados = valor1 / valor2;
                    textBox3.Text = resultados.ToString();
                    resultados = 0;
                }


            }
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

