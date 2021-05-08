namespace DashboardUI.ControlUsuario
{
    partial class FacturacionUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelDet = new System.Windows.Forms.Label();
            this.toolTipFac = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartFct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FACTURACIÓN ANUAL POR EMPRESAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartFct
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFct.Legends.Add(legend1);
            this.chartFct.Location = new System.Drawing.Point(22, 71);
            this.chartFct.Name = "chartFct";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFct.Series.Add(series1);
            this.chartFct.Size = new System.Drawing.Size(887, 391);
            this.chartFct.TabIndex = 2;
            this.chartFct.Text = "chart1";
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDet.Location = new System.Drawing.Point(822, 31);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(72, 20);
            this.labelDet.TabIndex = 3;
            this.labelDet.Text = "Detalle ?";
            this.labelDet.Click += new System.EventHandler(this.Detalle_Click);
            // 
            // FacturacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDet);
            this.Controls.Add(this.chartFct);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacturacionUC";
            this.Size = new System.Drawing.Size(936, 480);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FacturacionUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chartFct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFct;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.ToolTip toolTipFac;
    }
}
