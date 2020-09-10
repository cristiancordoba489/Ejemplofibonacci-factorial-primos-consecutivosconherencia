namespace Ejemplofibonacciconherencia
{
    partial class btnidentificarprimos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnverserie = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcularfactorial = new System.Windows.Forms.Button();
            this.lblfactorial = new System.Windows.Forms.Label();
            this.btnprimoidentificar = new System.Windows.Forms.Button();
            this.btnlistarconsecutivos = new System.Windows.Forms.Button();
            this.dtnumeros = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtnumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie Fibonacci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un numero:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(250, 130);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            // 
            // btnverserie
            // 
            this.btnverserie.Location = new System.Drawing.Point(390, 127);
            this.btnverserie.Name = "btnverserie";
            this.btnverserie.Size = new System.Drawing.Size(75, 23);
            this.btnverserie.TabIndex = 3;
            this.btnverserie.Text = "Ver serie";
            this.btnverserie.UseVisualStyleBackColor = true;
            this.btnverserie.Click += new System.EventHandler(this.btnverserie_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(641, 115);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(81, 264);
            this.lb1.TabIndex = 4;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(390, 241);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcularfactorial
            // 
            this.btncalcularfactorial.Location = new System.Drawing.Point(500, 127);
            this.btncalcularfactorial.Name = "btncalcularfactorial";
            this.btncalcularfactorial.Size = new System.Drawing.Size(98, 23);
            this.btncalcularfactorial.TabIndex = 6;
            this.btncalcularfactorial.Text = "Calcular factorial";
            this.btncalcularfactorial.UseVisualStyleBackColor = true;
            this.btncalcularfactorial.Click += new System.EventHandler(this.btncalcularfactorial_Click);
            // 
            // lblfactorial
            // 
            this.lblfactorial.AutoSize = true;
            this.lblfactorial.Location = new System.Drawing.Point(124, 246);
            this.lblfactorial.Name = "lblfactorial";
            this.lblfactorial.Size = new System.Drawing.Size(90, 13);
            this.lblfactorial.TabIndex = 7;
            this.lblfactorial.Text = "resultado factorial";
            this.lblfactorial.Visible = false;
            // 
            // btnprimoidentificar
            // 
            this.btnprimoidentificar.Location = new System.Drawing.Point(390, 179);
            this.btnprimoidentificar.Name = "btnprimoidentificar";
            this.btnprimoidentificar.Size = new System.Drawing.Size(75, 41);
            this.btnprimoidentificar.TabIndex = 8;
            this.btnprimoidentificar.Text = "Identificar primos";
            this.btnprimoidentificar.UseVisualStyleBackColor = true;
            this.btnprimoidentificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlistarconsecutivos
            // 
            this.btnlistarconsecutivos.Location = new System.Drawing.Point(500, 179);
            this.btnlistarconsecutivos.Name = "btnlistarconsecutivos";
            this.btnlistarconsecutivos.Size = new System.Drawing.Size(98, 41);
            this.btnlistarconsecutivos.TabIndex = 9;
            this.btnlistarconsecutivos.Text = "Listar consecutivos";
            this.btnlistarconsecutivos.UseVisualStyleBackColor = true;
            this.btnlistarconsecutivos.Click += new System.EventHandler(this.btnlistarconsecutivos_Click);
            // 
            // dtnumeros
            // 
            this.dtnumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtnumeros.Location = new System.Drawing.Point(390, 303);
            this.dtnumeros.Name = "dtnumeros";
            this.dtnumeros.Size = new System.Drawing.Size(182, 150);
            this.dtnumeros.TabIndex = 10;
            this.dtnumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtnumeros_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Consecutivos";
            // 
            // btnidentificarprimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtnumeros);
            this.Controls.Add(this.btnlistarconsecutivos);
            this.Controls.Add(this.btnprimoidentificar);
            this.Controls.Add(this.lblfactorial);
            this.Controls.Add(this.btncalcularfactorial);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnverserie);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btnidentificarprimos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtnumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnverserie;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcularfactorial;
        private System.Windows.Forms.Label lblfactorial;
        private System.Windows.Forms.Button btnprimoidentificar;
        private System.Windows.Forms.Button btnlistarconsecutivos;
        private System.Windows.Forms.DataGridView dtnumeros;
        private System.Windows.Forms.Label label3;
    }
}

