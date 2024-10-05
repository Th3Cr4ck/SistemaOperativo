namespace ProcesosGUIFramework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartProcesos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblIdle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBusy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcesos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartProcesos
            // 
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartProcesos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProcesos.Legends.Add(legend1);
            this.chartProcesos.Location = new System.Drawing.Point(3, 34);
            this.chartProcesos.Name = "chartProcesos";
            this.chartProcesos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chartProcesos.Size = new System.Drawing.Size(785, 268);
            this.chartProcesos.TabIndex = 0;
            this.chartProcesos.Text = "Procesos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(69, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 48);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblBusy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblIdle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCPU);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(340, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 106);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(89, 18);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(39, 13);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "lblCPU";
            // 
            // lblIdle
            // 
            this.lblIdle.AutoSize = true;
            this.lblIdle.Location = new System.Drawing.Point(89, 43);
            this.lblIdle.Name = "lblIdle";
            this.lblIdle.Size = new System.Drawing.Size(34, 13);
            this.lblIdle.TabIndex = 4;
            this.lblIdle.Text = "lblIdle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDLE";
            // 
            // lblBusy
            // 
            this.lblBusy.AutoSize = true;
            this.lblBusy.Location = new System.Drawing.Point(89, 68);
            this.lblBusy.Name = "lblBusy";
            this.lblBusy.Size = new System.Drawing.Size(40, 13);
            this.lblBusy.TabIndex = 6;
            this.lblBusy.Text = "lblBusy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "BUSY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chartProcesos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartProcesos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProcesos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBusy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIdle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label2;
    }
}

