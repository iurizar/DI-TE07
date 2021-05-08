using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasVOUtilidades;
using System.Windows.Forms.DataVisualization.Charting;
using DashboardUI.Formularios;

namespace DashboardUI.ControlUsuario
{
    public partial class FacturacionUC : UserControl
    {
        private VentasVO[] ventas;
        private Chart tabla;

        public FacturacionUC(VentasVO[] ventas)
        {
            InitializeComponent();
            this.ventas = ventas;
            this.tabla = chartFct;
            this.toolTipFac.SetToolTip(tabla, "Gráfico que detalla la facturación total de cada empresa");
            this.toolTipFac.SetToolTip(label1, "En miles de €");
            this.toolTipFac.SetToolTip(labelDet, "Pulsa para abrir una ventana con facturación detallada");
        }

        private void FacturacionUC_Paint(object sender, PaintEventArgs e)
        {
            List<string> empresas = new List<string>(new string[]{"Empresa 1", "Empresa 2" });
            List<double[]> ventasTotal = new List<double[]>();
            for(int i = 0; i< ventas.Length; i++)
            {
                double[] valueArray = new double[ventas.Length];
                valueArray[i] = ventas[i].FacturacionTotal;
                ventasTotal.Add(valueArray);
            }
            tabla.Series[0].Name = "Empresa 1";
            Series serie2 = new Series("Empresa 2");
            tabla.Series.Add(serie2);
            tabla.Series[0].Points.DataBindXY(empresas, ventasTotal[0]);
            tabla.Series[1].Points.DataBindXY(empresas, ventasTotal[1]);
            tabla.Series[0].IsValueShownAsLabel = true;
            tabla.Series[1].IsValueShownAsLabel = true;


        }

        private void Detalle_Click(object sender, EventArgs e)
        {
            PopupUI detallePopup = new PopupUI(ventas);
            detallePopup.Show();
        }
    }
}
