using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcesosGUIFramework
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ColaDeProcesos colaDeProcesos = new ColaDeProcesos();  
            Form1 form = new Form1(colaDeProcesos);
            Chart chart = form.Controls.Find("ChartProcesos", true).First() as Chart;
            Grafica grafica = new Grafica(chart, colaDeProcesos);

            Thread timer = new Thread(() => ThreadWork.TimeCount(colaDeProcesos, grafica, form));
            timer.Start();
            
            Application.Run(form);
        }
  
    }

    public class ThreadWork
    {
        public static void TimeCount(ColaDeProcesos colaDeProcesos, Grafica grafica, Form1 form)
        {                        
            while (true)
            {
                Console.WriteLine("Tiempo Actual: " + Tiempo.TiempoActual++);
                
                if (colaDeProcesos.procesoActivo != null)
                {
                    int tiempoTranscurrido = Tiempo.TiempoActual - colaDeProcesos.procesoActivo.TiempoDeInicio;

                    grafica.Actualizar(tiempoTranscurrido);                    

                    if (tiempoTranscurrido == colaDeProcesos.procesoActivo.TiempoDeEjecucion)
                    {
                        Console.WriteLine("Terminando el proceso " + colaDeProcesos.procesoActivo.ID);
                        colaDeProcesos.procesoActivo.TiempoDeFin = Tiempo.TiempoActual;
                        colaDeProcesos.procesoActivo.TiempoEnCola = Tiempo.TiempoActual - colaDeProcesos.procesoActivo.TiempoDeLlegada;
                        colaDeProcesos.procesoActivo.Espera = colaDeProcesos.procesoActivo.TiempoDeInicio - colaDeProcesos.procesoActivo.TiempoDeLlegada;
                        colaDeProcesos.procesoActivo = null;
                    }
                }

                if (colaDeProcesos.procesoActivo == null)
                    Kernel(colaDeProcesos);


                form.ActualizarDataCPU();
                Thread.Sleep(100);
            }
        }

        public static void Kernel(ColaDeProcesos colaDeProcesos)
        {
            // Dar inicio a un proceso de la cola de procesos
            if (colaDeProcesos.procesos.Count > 0)
            {
                colaDeProcesos.procesoActivo = colaDeProcesos.procesos.Dequeue();
                colaDeProcesos.procesoActivo.TiempoDeInicio = Tiempo.TiempoActual;                
                Console.WriteLine("Iniciando el proceso " + colaDeProcesos.procesoActivo.ID);
            }
        }
    }
}
