namespace GraficaSensores
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblVariableTemperatura = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblVariableHumedad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHumedad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumedad)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // lblVariableTemperatura
            // 
            this.lblVariableTemperatura.AutoSize = true;
            this.lblVariableTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblVariableTemperatura.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableTemperatura.Location = new System.Drawing.Point(602, 449);
            this.lblVariableTemperatura.Name = "lblVariableTemperatura";
            this.lblVariableTemperatura.Size = new System.Drawing.Size(122, 15);
            this.lblVariableTemperatura.TabIndex = 6;
            this.lblVariableTemperatura.Text = "Variable Linguistica:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperatura.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(1024, 379);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(81, 15);
            this.lblTemperatura.TabIndex = 7;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedad.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(428, 379);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(64, 15);
            this.lblHumedad.TabIndex = 9;
            this.lblHumedad.Text = "Humedad:";
            // 
            // lblVariableHumedad
            // 
            this.lblVariableHumedad.AutoSize = true;
            this.lblVariableHumedad.BackColor = System.Drawing.Color.Transparent;
            this.lblVariableHumedad.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableHumedad.Location = new System.Drawing.Point(13, 449);
            this.lblVariableHumedad.Name = "lblVariableHumedad";
            this.lblVariableHumedad.Size = new System.Drawing.Size(122, 15);
            this.lblVariableHumedad.TabIndex = 8;
            this.lblVariableHumedad.Text = "Variable Linguistica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Humedad";
            // 
            // chartTemperatura
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemperatura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperatura.Legends.Add(legend1);
            this.chartTemperatura.Location = new System.Drawing.Point(605, 67);
            this.chartTemperatura.Name = "chartTemperatura";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Congelado";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Fresco";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Agradable";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Calido";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Caluroso";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Abrasador";
            this.chartTemperatura.Series.Add(series1);
            this.chartTemperatura.Series.Add(series2);
            this.chartTemperatura.Series.Add(series3);
            this.chartTemperatura.Series.Add(series4);
            this.chartTemperatura.Series.Add(series5);
            this.chartTemperatura.Series.Add(series6);
            this.chartTemperatura.Size = new System.Drawing.Size(551, 368);
            this.chartTemperatura.TabIndex = 14;
            this.chartTemperatura.Text = "Temperatura";
            // 
            // chartHumedad
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHumedad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHumedad.Legends.Add(legend2);
            this.chartHumedad.Location = new System.Drawing.Point(16, 67);
            this.chartHumedad.Name = "chartHumedad";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Seco";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Confortable";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Humedo";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Muy Humedo";
            this.chartHumedad.Series.Add(series7);
            this.chartHumedad.Series.Add(series8);
            this.chartHumedad.Series.Add(series9);
            this.chartHumedad.Series.Add(series10);
            this.chartHumedad.Size = new System.Drawing.Size(551, 368);
            this.chartHumedad.TabIndex = 15;
            this.chartHumedad.Text = "Humedad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHumedad);
            this.Controls.Add(this.lblVariableHumedad);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblVariableTemperatura);
            this.Controls.Add(this.chartTemperatura);
            this.Controls.Add(this.chartHumedad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblVariableTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblVariableHumedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumedad;
    }
}

