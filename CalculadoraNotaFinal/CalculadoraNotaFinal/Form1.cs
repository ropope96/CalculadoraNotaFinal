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

			var menorControl = new int[] { c1, c2, c3, c4 }.Min();

			var promedioControles = (c1 + c2 + c3 + c4 - menorControl) / 3;

			label12.Text = "El promedio de Controles es :" + promedioControles;


			var l1 = Convert.ToInt32(textBox5.Text);
			var l2 = Convert.ToInt32(textBox8.Text);
			var l3 = Convert.ToInt32(textBox7.Text);
			var l4 = Convert.ToInt32(textBox6.Text);

			var promedioLaboratorios = (l1 + l2 + l3 + l4) / 4;

			label14.Text = "El promedio de Laboratorios es :" + promedioLaboratorios;

			var trabajo = Convert.ToInt32(textBox9.Text);

			var promedioEvaluaciones = (promedioLaboratorios + promedioControles + trabajo) / 3;

			label13.Text = "El promedio de Evaluaciones es :" + promedioEvaluaciones;

			var examParcial = Convert.ToInt32(textBox10.Text);

			var examFinal = Convert.ToInt32(textBox11.Text);

			var notaFinal = (2 * promedioEvaluaciones + examParcial + examFinal) / 4;

			label15.Text = "La Nota Final es :" + notaFinal;

		}


	}
}
