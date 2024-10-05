using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcesosGUIFramework
{
    public class Grafica
    {
        private Chart _chart;
        public readonly ColaDeProcesos _colaDeProcesos;

        public Grafica(Chart chart, ColaDeProcesos colaDeProcesos)
        {
            _chart = chart;
            _colaDeProcesos = colaDeProcesos;    
            
            // Establecer el valor máximo y minimos de Y
            _chart.ChartAreas[0].AxisY.Maximum = 10;
            _chart.ChartAreas[0].AxisY.Minimum = 0;

        }

        public void Agregar(Proceso proceso)
        {
            if (_chart.InvokeRequired)
            {
                _chart.Invoke(new Action(() => Agregar(proceso)));
            }
            else
            {
                if (_chart.Series.FindByName(proceso.ID.ToString()) == null)
                {
                    Series series = _chart.Series.Add(proceso.ID.ToString());
                    series.Points.AddY(0); // Inicializa la barra vacía                    
                }
            }
        }

        public void Actualizar(int tiempoTranscurrido)
        {
            if (_chart.InvokeRequired)
            {
                _chart.Invoke(new Action(() => Actualizar(tiempoTranscurrido)));
            }
            else
            {
                var procesoActivo = _colaDeProcesos.procesoActivo;

                // Verificar que el proceso activo no sea nulo
                if (procesoActivo != null)
                {
                    Series series = _chart.Series.FindByName(procesoActivo.ID.ToString());

                    // Verificar que la serie existe antes de intentar actualizar
                    if (series != null)
                    {
                        series.Points[0].YValues[0] = tiempoTranscurrido;
                        _chart.Invalidate();
                    }
                    else
                    {
                        Console.WriteLine("Error: No se encontró la serie para el proceso activo.");
                    }
                }
            }
        }
    }

}
