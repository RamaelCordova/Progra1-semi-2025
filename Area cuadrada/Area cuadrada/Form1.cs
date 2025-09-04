using System;
using System.Windows.Forms;

namespace Area_cuadrada
{
    public partial class Form1 : Form
    {
        string[] unidades = { "Metro²", "Pie²", "Vara²", "Yarda²", "Tarea", "Manzana", "Hectárea" };
        double[] factores = { 1, 0.092903, 0.6987, 0.836127, 628.86, 6987.4, 10000 };
        double[,] matrizConversion = new double[7, 7];

        public Form1()
        {
            InitializeComponent();
            InicializarUnidades();
            CrearMatriz();
        }

        private void InicializarUnidades()
        {
            cmbOrigen.Items.AddRange(unidades);
            cmbDestino.Items.AddRange(unidades);
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;
        }

        private void CrearMatriz()
        {
            for (int i = 0; i < unidades.Length; i++)
            {
                for (int j = 0; j < unidades.Length; j++)
                {
                    matrizConversion[i, j] = factores[i] / factores[j];
                }
            }
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex == -1 || cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona unidades de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Por favor ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int origen = cmbOrigen.SelectedIndex;
            int destino = cmbDestino.SelectedIndex;

            double resultado = valor * matrizConversion[origen, destino];
            lblResultado.Text = $"{valor} {unidades[origen]} = {resultado:F4} {unidades[destino]}";
        }
    }
}

