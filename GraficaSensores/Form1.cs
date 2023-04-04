using GraficaSensores.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficaSensores
{
    public partial class Form1 : Form
    {
        FuncionPertenencia congelado = new FuncionPertenencia(-5, 0);
        FuncionPertenencia fresco = new FuncionPertenencia(-5, 0, 10);
        FuncionPertenencia agradable = new FuncionPertenencia(0, 10, 20);
        FuncionPertenencia calido = new FuncionPertenencia(10, 20, 30);
        FuncionPertenencia caluroso = new FuncionPertenencia(20, 30, 40);
        FuncionPertenencia abrasador = new FuncionPertenencia(40, 50);

        List<String> temperatura = new List<String>();

        FuncionPertenencia ambienteSeco = new FuncionPertenencia(10, 30);
        FuncionPertenencia ambienteConfortable = new FuncionPertenencia(10, 30, 50);
        FuncionPertenencia ambienteHumedo = new FuncionPertenencia(30, 50, 70);
        FuncionPertenencia ambienteMuyHumedo = new FuncionPertenencia(70, 100);

        List<String> humedad = new List<String>();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            temperatura.Add("Congelado");
            temperatura.Add("Fresco");
            temperatura.Add("Agradable");
            temperatura.Add("Calido");
            temperatura.Add("Caluroso");
            temperatura.Add("Abrasador");

            humedad.Add("Seco");
            humedad.Add("Confortable");
            humedad.Add("Humedo");
            humedad.Add("Muy Humedo");

            graficaHumedad();
            graficaTemperatura();

            serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort puerto = (SerialPort)sender;

            string datoLeidoHumedad = puerto.ReadLine().Trim();
            string datoLeidoTemperatura = puerto.ReadLine().Trim();
            double xHumedad = double.Parse(datoLeidoHumedad);
            double xTemperatura = double.Parse(datoLeidoTemperatura);

            List<double> yHumedad = new List<double>
            {
                ambienteSeco.funcionHombro(xHumedad),
                ambienteConfortable.funcionTriangular(xHumedad),
                ambienteHumedo.funcionTriangular(xHumedad),
                ambienteMuyHumedo.funcionSaturacion(xHumedad)
            };

            List<double> yTemperatura = new List<double>{
                congelado.funcionHombro(xTemperatura),
                fresco.funcionTriangular(xTemperatura),
                agradable.funcionTriangular(xTemperatura),
                calido.funcionTriangular(xTemperatura),
                caluroso.funcionTriangular(xTemperatura),
                abrasador.funcionSaturacion(xTemperatura)
            };

            double max = yHumedad.Max();
            int aux = 0;
            int indiceMax = 0;

            foreach (double v in yHumedad)
            {
                if (yHumedad[aux] == max)
                    indiceMax = aux;
                aux++;
            }

            lblVariableHumedad.Text = "Variable Linguistica: " + humedad[indiceMax];
            lblHumedad.Text = "Humedad: " + datoLeidoHumedad;

            max = 0;
            aux = 0;
            indiceMax = 0;
            max = yTemperatura.Max();
            
            foreach (double v in yTemperatura)
            {
                if (yTemperatura[aux] == max)
                    indiceMax = aux;
                aux++;
            }

            lblVariableTemperatura.Text = "Variable Linguistica: " + temperatura[indiceMax];
            lblTemperatura.Text = "Temperatura: " + datoLeidoTemperatura;
        }

        private void graficaTemperatura()
        {
            double y = 0;
            for (int x = 0; x <= 50; x++)
            {
                y = congelado.funcionHombro(x);
                chartTemperatura.Series[0].Points.AddXY(x, y);

                y = fresco.funcionTriangular(x);
                chartTemperatura.Series[1].Points.AddXY(x, y);

                y = agradable.funcionTriangular(x);
                chartTemperatura.Series[2].Points.AddXY(x, y);

                y = calido.funcionTriangular(x);
                chartTemperatura.Series[3].Points.AddXY(x, y);

                y = caluroso.funcionTriangular(x);
                chartTemperatura.Series[4].Points.AddXY(x, y);

                y = abrasador.funcionSaturacion(x);
                chartTemperatura.Series[5].Points.AddXY(x, y);
            }
        }

        private void graficaHumedad()
        {
            double y = 0;
            for (int x = 0; x <= 100; x++)
            {
                y = ambienteSeco.funcionHombro(x);
                chartHumedad.Series[0].Points.AddXY(x, y);

                y = ambienteConfortable.funcionTriangular(x);
                chartHumedad.Series[1].Points.AddXY(x, y);

                y = ambienteHumedo.funcionTriangular(x);
                chartHumedad.Series[2].Points.AddXY(x, y);

                y = ambienteMuyHumedo.funcionSaturacion(x);
                chartHumedad.Series[3].Points.AddXY(x, y);
            }
        }
    }
}
