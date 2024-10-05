using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesosGUIFramework
{
    public partial class Form1 : Form
    {
        private ColaDeProcesos ColaDeProcesos;
        private Grafica _Grafica;
        private int IDActual = 6000;        
        private int busy = 0;
        private int idle = 0;

        public Form1(ColaDeProcesos colaDeProcesos)
        {
            InitializeComponent();
            ColaDeProcesos = colaDeProcesos;
            _Grafica = new Grafica(chartProcesos, colaDeProcesos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Generar proceso aleatorio
            Proceso procesoGenerado = GeneradorDeProcesos.RandomProcess(ref IDActual);
            procesoGenerado.TiempoDeLlegada = Tiempo.TiempoActual;

            // Aniadir a la cola
            ColaDeProcesos.procesos.Enqueue(procesoGenerado);

            // Aniadir a la grafica
            _Grafica.Agregar(procesoGenerado);
        }

        public void ActualizarDataCPU()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarDataCPU()));
            }
            else
            {
                lblCPU.Text = Tiempo.TiempoActual.ToString();
                if (ColaDeProcesos.procesoActivo != null)
                    busy++;
                else
                    idle++;

                lblIdle.Text = idle.ToString();
                lblBusy.Text = busy.ToString();
            }           
        }
    }
}
