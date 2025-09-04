using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Impuesto
{
    public partial class frmImpuesto : Form
    {
        // Matriz de rangos: desde, hasta, precio, adicional
        double[,] tabla = new double[,]
        {
     {0.01, 500, 1.5, 0},
     {500.01, 1000, 1.5, 3},
     {1000.01, 2000, 3, 3},
     {2000.01, 3000, 6, 3},
     {3000.01, 6000, 9, 2},
     {8000.01, 18000, 15, 2},
     {18000.01, 30000, 39, 2},
     {30000.01, 60000, 63, 1},
     {60000.01, 100000, 93, 0.8},
     {100000.01, 200000, 125, 0.7},
     {200000.01, 300000, 195, 0.6},
     {300000.01, 400000, 255, 0.45},
     {400000.01, 500000, 300, 0.4},
     {500000.01, 1000000, 340, 0.3},
     {1000000.01, 99999999, 490, 0.18}
        };
        public frmImpuesto()
        {
            InitializeComponent();
        }

        private void frmImpuesto_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(txtMonto.Text);
                double impuesto = CalcularImpuesto(monto);
                lblImpuesto.Text = $"${impuesto:F2}";
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double CalcularImpuesto(double monto)
        {
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                double desde = tabla[i, 0];
                double hasta = tabla[i, 1];
                double precio = tabla[i, 2];
                double adicional = tabla[i, 3];

                if (monto >= desde && monto <= hasta)
                {
                    double baseMonto = monto - desde;
                    double impuesto = (baseMonto / 1000) * adicional + precio;
                    return impuesto;
                }
            }

            return 0; // Si no cae en ningún rango

        }
    }
}
