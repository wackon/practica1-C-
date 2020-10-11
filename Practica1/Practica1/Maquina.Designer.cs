namespace Practica1
{
    partial class Maquina
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
            this.label1 = new System.Windows.Forms.Label();
            this.txValorRetiro = new System.Windows.Forms.TextBox();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Valor a Retirar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txValorRetiro
            // 
            this.txValorRetiro.Location = new System.Drawing.Point(213, 61);
            this.txValorRetiro.Name = "txValorRetiro";
            this.txValorRetiro.Size = new System.Drawing.Size(100, 20);
            this.txValorRetiro.TabIndex = 1;
            this.txValorRetiro.TextChanged += new System.EventHandler(this.txValorRetiro_TextChanged);
            // 
            // txSalida
            // 
            this.txSalida.Location = new System.Drawing.Point(6, 19);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.Size = new System.Drawing.Size(331, 123);
            this.txSalida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "La cantidad minima de billetes a entregar por denominacion es :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(338, 61);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(341, 75);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(59, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txSalida);
            this.gbResultado.Controls.Add(this.btSalir);
            this.gbResultado.Enabled = false;
            this.gbResultado.Location = new System.Drawing.Point(13, 149);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(406, 154);
            this.gbResultado.TabIndex = 7;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // Maquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 315);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txValorRetiro);
            this.Controls.Add(this.label1);
            this.Name = "Maquina";
            this.Text = "Maquina";
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txValorRetiro;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox gbResultado;
    }
}