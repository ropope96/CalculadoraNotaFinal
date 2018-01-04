using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraNotaFinal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			var c1 = Convert.ToInt32(textBox1.Text);
			var c2 = Convert.ToInt32(textBox2.Text);
			var c3 = Convert.ToInt32(textBox3.Text);
			var c4 = Convert.ToInt32(textBox4.Text);

			//El .Min no soporta más de dos valores, por lo que ponemos todos los valores en un 
			// arreglo y luego invocamos a .Min
			var menorControl = new int[] { c1, c2, c3, c4 }.Min();

			var promedioControles = (c1 + c2 + c3 + c4 - menorControl) / 3;

			MessageBox.Show("El promedio de controles es :" + promedioControles);
		}
	}
}
