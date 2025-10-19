using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Examen01_Ti_Escobar_Solano.Logica_.Interfaces;
using Examen01_Ti_Escobar_Solano.Logica_.Operaciones;
using Examen01_Ti_Escobar_Solano.Logica_.Salidas;

namespace Examen01_Ti_Escobar_Solano.UI
{
    public partial class Form1 : Form
    {
        private readonly ImpresorResultadosESCO impresor = new ImpresorResultadosESCO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            IOperacionESCO sumar = new SumarESCO();
            string resultado = sumar.Ejecutar(txtNumA.Text, txtNumB.Text);
            lblResultado.Text = $"Suma: {resultado}";
            impresor.Mostrar($"Resultado Suma: {resultado}");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            IOperacionESCO restar = new RestarESCO();
            string resultado = restar.Ejecutar(txtNumA.Text, txtNumB.Text);
            lblResultado.Text = $"Resta: {resultado}";
            impresor.Mostrar($"Resultado Resta: {resultado}");
        }
    }
}
