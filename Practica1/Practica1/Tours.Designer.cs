namespace Practica1
{
    partial class Tours
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
            this.gbTipoCama = new System.Windows.Forms.GroupBox();
            this.rbEconomco = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbLujo = new System.Windows.Forms.RadioButton();
            this.gbTipoHab = new System.Windows.Forms.GroupBox();
            this.rbHabNorm = new System.Windows.Forms.RadioButton();
            this.rbSuite = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txNom = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txDest = new System.Windows.Forms.TextBox();
            this.txDestino = new System.Windows.Forms.Label();
            this.txCed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txDiasDViaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txDiasEstadia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTranspB = new System.Windows.Forms.GroupBox();
            this.txTransMu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbTransAv = new System.Windows.Forms.GroupBox();
            this.txTransAe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txTasaAero = new System.Windows.Forms.TextBox();
            this.txValMil = new System.Windows.Forms.TextBox();
            this.txValMillas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txMillasCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbTipoCama.SuspendLayout();
            this.gbTipoHab.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.gbTranspB.SuspendLayout();
            this.gbTransAv.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Camarote :";
            // 
            // gbTipoCama
            // 
            this.gbTipoCama.Controls.Add(this.rbEconomco);
            this.gbTipoCama.Controls.Add(this.rbNormal);
            this.gbTipoCama.Controls.Add(this.rbLujo);
            this.gbTipoCama.Controls.Add(this.label1);
            this.gbTipoCama.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTipoCama.Location = new System.Drawing.Point(12, 206);
            this.gbTipoCama.Name = "gbTipoCama";
            this.gbTipoCama.Size = new System.Drawing.Size(479, 64);
            this.gbTipoCama.TabIndex = 1;
            this.gbTipoCama.TabStop = false;
            this.gbTipoCama.Text = "Tipo de Camarote";
            this.gbTipoCama.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbEconomco
            // 
            this.rbEconomco.AutoSize = true;
            this.rbEconomco.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbEconomco.Location = new System.Drawing.Point(346, 38);
            this.rbEconomco.Name = "rbEconomco";
            this.rbEconomco.Size = new System.Drawing.Size(103, 20);
            this.rbEconomco.TabIndex = 3;
            this.rbEconomco.Text = "Economico";
            this.rbEconomco.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbNormal.Location = new System.Drawing.Point(251, 36);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(76, 20);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbLujo
            // 
            this.rbLujo.AutoSize = true;
            this.rbLujo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbLujo.Location = new System.Drawing.Point(179, 34);
            this.rbLujo.Name = "rbLujo";
            this.rbLujo.Size = new System.Drawing.Size(55, 20);
            this.rbLujo.TabIndex = 1;
            this.rbLujo.Text = "Lujo";
            this.rbLujo.UseVisualStyleBackColor = true;
            // 
            // gbTipoHab
            // 
            this.gbTipoHab.Controls.Add(this.rbHabNorm);
            this.gbTipoHab.Controls.Add(this.rbSuite);
            this.gbTipoHab.Controls.Add(this.label2);
            this.gbTipoHab.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbTipoHab.Location = new System.Drawing.Point(12, 270);
            this.gbTipoHab.Name = "gbTipoHab";
            this.gbTipoHab.Size = new System.Drawing.Size(479, 61);
            this.gbTipoHab.TabIndex = 2;
            this.gbTipoHab.TabStop = false;
            this.gbTipoHab.Text = "Tipo de Habitación";
            // 
            // rbHabNorm
            // 
            this.rbHabNorm.AutoSize = true;
            this.rbHabNorm.Checked = true;
            this.rbHabNorm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbHabNorm.Location = new System.Drawing.Point(251, 36);
            this.rbHabNorm.Name = "rbHabNorm";
            this.rbHabNorm.Size = new System.Drawing.Size(76, 20);
            this.rbHabNorm.TabIndex = 2;
            this.rbHabNorm.TabStop = true;
            this.rbHabNorm.Text = "Normal";
            this.rbHabNorm.UseVisualStyleBackColor = true;
            // 
            // rbSuite
            // 
            this.rbSuite.AutoSize = true;
            this.rbSuite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbSuite.Location = new System.Drawing.Point(179, 34);
            this.rbSuite.Name = "rbSuite";
            this.rbSuite.Size = new System.Drawing.Size(61, 20);
            this.rbSuite.TabIndex = 1;
            this.rbSuite.Text = "Suite";
            this.rbSuite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Habitación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(124, 22);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(325, 22);
            this.txNom.TabIndex = 4;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.button1);
            this.gbInfo.Controls.Add(this.txDest);
            this.gbInfo.Controls.Add(this.txDestino);
            this.gbInfo.Controls.Add(this.txCed);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txNom);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbInfo.Location = new System.Drawing.Point(12, 36);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(479, 164);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informacion del Cliente";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(317, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular Costo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txDest
            // 
            this.txDest.Location = new System.Drawing.Point(124, 90);
            this.txDest.Name = "txDest";
            this.txDest.Size = new System.Drawing.Size(176, 22);
            this.txDest.TabIndex = 8;
            // 
            // txDestino
            // 
            this.txDestino.AutoSize = true;
            this.txDestino.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txDestino.Location = new System.Drawing.Point(33, 85);
            this.txDestino.Name = "txDestino";
            this.txDestino.Size = new System.Drawing.Size(73, 16);
            this.txDestino.TabIndex = 7;
            this.txDestino.Text = "Destino : ";
            // 
            // txCed
            // 
            this.txCed.Location = new System.Drawing.Point(124, 54);
            this.txCed.Name = "txCed";
            this.txCed.Size = new System.Drawing.Size(176, 22);
            this.txCed.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(33, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cedula : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.dateTimePicker1);
            this.gbFecha.Controls.Add(this.label7);
            this.gbFecha.Controls.Add(this.txDiasDViaje);
            this.gbFecha.Controls.Add(this.label5);
            this.gbFecha.Controls.Add(this.txDiasEstadia);
            this.gbFecha.Controls.Add(this.label6);
            this.gbFecha.Location = new System.Drawing.Point(511, 36);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(537, 193);
            this.gbFecha.TabIndex = 6;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha de Viaje : ";
            // 
            // txDiasDViaje
            // 
            this.txDiasDViaje.Location = new System.Drawing.Point(269, 122);
            this.txDiasDViaje.Name = "txDiasDViaje";
            this.txDiasDViaje.Size = new System.Drawing.Size(199, 22);
            this.txDiasDViaje.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de Dias De Viaje";
            // 
            // txDiasEstadia
            // 
            this.txDiasEstadia.Location = new System.Drawing.Point(269, 84);
            this.txDiasEstadia.Name = "txDiasEstadia";
            this.txDiasEstadia.Size = new System.Drawing.Size(199, 22);
            this.txDiasEstadia.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dias de Estadia : ";
            // 
            // gbTranspB
            // 
            this.gbTranspB.Controls.Add(this.txTransMu);
            this.gbTranspB.Controls.Add(this.label9);
            this.gbTranspB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTranspB.Location = new System.Drawing.Point(511, 414);
            this.gbTranspB.Name = "gbTranspB";
            this.gbTranspB.Size = new System.Drawing.Size(537, 59);
            this.gbTranspB.TabIndex = 7;
            this.gbTranspB.TabStop = false;
            this.gbTranspB.Text = "Transporte para Barco";
            // 
            // txTransMu
            // 
            this.txTransMu.Location = new System.Drawing.Point(269, 16);
            this.txTransMu.Name = "txTransMu";
            this.txTransMu.Size = new System.Drawing.Size(199, 22);
            this.txTransMu.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(18, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Valor Transporte Muelle";
            // 
            // gbTransAv
            // 
            this.gbTransAv.Controls.Add(this.txMillasCliente);
            this.gbTransAv.Controls.Add(this.label12);
            this.gbTransAv.Controls.Add(this.txTransAe);
            this.gbTransAv.Controls.Add(this.label11);
            this.gbTransAv.Controls.Add(this.label10);
            this.gbTransAv.Controls.Add(this.txTasaAero);
            this.gbTransAv.Controls.Add(this.txValMil);
            this.gbTransAv.Controls.Add(this.txValMillas);
            this.gbTransAv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTransAv.Location = new System.Drawing.Point(511, 240);
            this.gbTransAv.Name = "gbTransAv";
            this.gbTransAv.Size = new System.Drawing.Size(537, 168);
            this.gbTransAv.TabIndex = 8;
            this.gbTransAv.TabStop = false;
            this.gbTransAv.Text = "Transporte para Avion";
            // 
            // txTransAe
            // 
            this.txTransAe.Location = new System.Drawing.Point(269, 126);
            this.txTransAe.Name = "txTransAe";
            this.txTransAe.Size = new System.Drawing.Size(199, 22);
            this.txTransAe.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(18, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Valor Transporte a Aeropuerto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(18, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Valor Tasa Aeropuertuaria";
            // 
            // txTasaAero
            // 
            this.txTasaAero.Location = new System.Drawing.Point(269, 92);
            this.txTasaAero.Name = "txTasaAero";
            this.txTasaAero.Size = new System.Drawing.Size(199, 22);
            this.txTasaAero.TabIndex = 3;
            // 
            // txValMil
            // 
            this.txValMil.Location = new System.Drawing.Point(269, 58);
            this.txValMil.Name = "txValMil";
            this.txValMil.Size = new System.Drawing.Size(199, 22);
            this.txValMil.TabIndex = 1;
            // 
            // txValMillas
            // 
            this.txValMillas.AutoSize = true;
            this.txValMillas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txValMillas.Location = new System.Drawing.Point(18, 64);
            this.txValMillas.Name = "txValMillas";
            this.txValMillas.Size = new System.Drawing.Size(90, 16);
            this.txValMillas.TabIndex = 0;
            this.txValMillas.Text = "Valor Millas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Empresa Turistica";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 341);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 131);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txMillasCliente
            // 
            this.txMillasCliente.Location = new System.Drawing.Point(269, 24);
            this.txMillasCliente.Name = "txMillasCliente";
            this.txMillasCliente.Size = new System.Drawing.Size(199, 22);
            this.txMillasCliente.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(18, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Millas Acumuladas del Cliente :";
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbTransAv);
            this.Controls.Add(this.gbTranspB);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbTipoHab);
            this.Controls.Add(this.gbTipoCama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tours";
            this.Text = "Empresa de Tours";
            this.gbTipoCama.ResumeLayout(false);
            this.gbTipoCama.PerformLayout();
            this.gbTipoHab.ResumeLayout(false);
            this.gbTipoHab.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbTranspB.ResumeLayout(false);
            this.gbTranspB.PerformLayout();
            this.gbTransAv.ResumeLayout(false);
            this.gbTransAv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTipoCama;
        private System.Windows.Forms.RadioButton rbEconomco;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbLujo;
        private System.Windows.Forms.GroupBox gbTipoHab;
        private System.Windows.Forms.RadioButton rbHabNorm;
        private System.Windows.Forms.RadioButton rbSuite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCed;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.TextBox txDiasDViaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDiasEstadia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbTranspB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbTransAv;
        private System.Windows.Forms.TextBox txTransAe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txTasaAero;
        private System.Windows.Forms.TextBox txValMil;
        private System.Windows.Forms.Label txValMillas;
        private System.Windows.Forms.TextBox txTransMu;
        private System.Windows.Forms.TextBox txDest;
        private System.Windows.Forms.Label txDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txMillasCliente;
        private System.Windows.Forms.Label label12;
    }
}