﻿namespace Practica1
{
    partial class Vista
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
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.txIngAut = new System.Windows.Forms.TextBox();
            this.txIngNom = new System.Windows.Forms.TextBox();
            this.txIngCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbConsultar = new System.Windows.Forms.GroupBox();
            this.btBusqudaCod = new System.Windows.Forms.Button();
            this.txBusAut = new System.Windows.Forms.TextBox();
            this.txBusNombre = new System.Windows.Forms.TextBox();
            this.txBusCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txSalidaConsulta = new System.Windows.Forms.TextBox();
            this.btBusNom = new System.Windows.Forms.Button();
            this.btBusAu = new System.Windows.Forms.Button();
            this.btBusDis = new System.Windows.Forms.Button();
            this.txBusDisp = new System.Windows.Forms.TextBox();
            this.rbDisponible = new System.Windows.Forms.RadioButton();
            this.rbNoDisp = new System.Windows.Forms.RadioButton();
            this.gbIngresar.SuspendLayout();
            this.gbConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca";
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.rbNoDisp);
            this.gbIngresar.Controls.Add(this.rbDisponible);
            this.gbIngresar.Controls.Add(this.btIngresar);
            this.gbIngresar.Controls.Add(this.txIngAut);
            this.gbIngresar.Controls.Add(this.txIngNom);
            this.gbIngresar.Controls.Add(this.txIngCod);
            this.gbIngresar.Controls.Add(this.label4);
            this.gbIngresar.Controls.Add(this.label3);
            this.gbIngresar.Controls.Add(this.label2);
            this.gbIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbIngresar.Location = new System.Drawing.Point(43, 65);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(743, 163);
            this.gbIngresar.TabIndex = 1;
            this.gbIngresar.TabStop = false;
            this.gbIngresar.Text = "Ingresar Libro";
            // 
            // btIngresar
            // 
            this.btIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btIngresar.Location = new System.Drawing.Point(498, 24);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(157, 36);
            this.btIngresar.TabIndex = 8;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // txIngAut
            // 
            this.txIngAut.Location = new System.Drawing.Point(145, 85);
            this.txIngAut.Name = "txIngAut";
            this.txIngAut.Size = new System.Drawing.Size(247, 24);
            this.txIngAut.TabIndex = 6;
            // 
            // txIngNom
            // 
            this.txIngNom.Location = new System.Drawing.Point(145, 55);
            this.txIngNom.Name = "txIngNom";
            this.txIngNom.Size = new System.Drawing.Size(247, 24);
            this.txIngNom.TabIndex = 5;
            // 
            // txIngCod
            // 
            this.txIngCod.Location = new System.Drawing.Point(145, 24);
            this.txIngCod.Name = "txIngCod";
            this.txIngCod.Size = new System.Drawing.Size(247, 24);
            this.txIngCod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // gbConsultar
            // 
            this.gbConsultar.Controls.Add(this.txBusDisp);
            this.gbConsultar.Controls.Add(this.btBusDis);
            this.gbConsultar.Controls.Add(this.btBusAu);
            this.gbConsultar.Controls.Add(this.btBusNom);
            this.gbConsultar.Controls.Add(this.txSalidaConsulta);
            this.gbConsultar.Controls.Add(this.btBusqudaCod);
            this.gbConsultar.Controls.Add(this.txBusAut);
            this.gbConsultar.Controls.Add(this.txBusNombre);
            this.gbConsultar.Controls.Add(this.txBusCod);
            this.gbConsultar.Controls.Add(this.label6);
            this.gbConsultar.Controls.Add(this.label7);
            this.gbConsultar.Controls.Add(this.label8);
            this.gbConsultar.Controls.Add(this.label9);
            this.gbConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbConsultar.Location = new System.Drawing.Point(43, 234);
            this.gbConsultar.Name = "gbConsultar";
            this.gbConsultar.Size = new System.Drawing.Size(743, 297);
            this.gbConsultar.TabIndex = 10;
            this.gbConsultar.TabStop = false;
            this.gbConsultar.Text = "Consultar Libro";
            // 
            // btBusqudaCod
            // 
            this.btBusqudaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusqudaCod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBusqudaCod.Location = new System.Drawing.Point(456, 23);
            this.btBusqudaCod.Name = "btBusqudaCod";
            this.btBusqudaCod.Size = new System.Drawing.Size(210, 25);
            this.btBusqudaCod.TabIndex = 8;
            this.btBusqudaCod.Text = "Busqueda por Código";
            this.btBusqudaCod.UseVisualStyleBackColor = true;
            this.btBusqudaCod.Click += new System.EventHandler(this.button1_Click);
            // 
            // txBusAut
            // 
            this.txBusAut.Location = new System.Drawing.Point(145, 85);
            this.txBusAut.Name = "txBusAut";
            this.txBusAut.Size = new System.Drawing.Size(247, 24);
            this.txBusAut.TabIndex = 6;
            // 
            // txBusNombre
            // 
            this.txBusNombre.Location = new System.Drawing.Point(145, 55);
            this.txBusNombre.Name = "txBusNombre";
            this.txBusNombre.Size = new System.Drawing.Size(247, 24);
            this.txBusNombre.TabIndex = 5;
            // 
            // txBusCod
            // 
            this.txBusCod.Location = new System.Drawing.Point(145, 24);
            this.txBusCod.Name = "txBusCod";
            this.txBusCod.Size = new System.Drawing.Size(247, 24);
            this.txBusCod.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(19, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Disponible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(19, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Autor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(19, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(19, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código";
            // 
            // txSalidaConsulta
            // 
            this.txSalidaConsulta.Location = new System.Drawing.Point(22, 157);
            this.txSalidaConsulta.Multiline = true;
            this.txSalidaConsulta.Name = "txSalidaConsulta";
            this.txSalidaConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txSalidaConsulta.Size = new System.Drawing.Size(539, 134);
            this.txSalidaConsulta.TabIndex = 10;
            // 
            // btBusNom
            // 
            this.btBusNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusNom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBusNom.Location = new System.Drawing.Point(456, 55);
            this.btBusNom.Name = "btBusNom";
            this.btBusNom.Size = new System.Drawing.Size(210, 27);
            this.btBusNom.TabIndex = 12;
            this.btBusNom.Text = "Busqueda por Nombre";
            this.btBusNom.UseVisualStyleBackColor = true;
            this.btBusNom.Click += new System.EventHandler(this.txBusNom_Click);
            // 
            // btBusAu
            // 
            this.btBusAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusAu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBusAu.Location = new System.Drawing.Point(456, 88);
            this.btBusAu.Name = "btBusAu";
            this.btBusAu.Size = new System.Drawing.Size(210, 27);
            this.btBusAu.TabIndex = 13;
            this.btBusAu.Text = "Busqueda por Autor";
            this.btBusAu.UseVisualStyleBackColor = true;
            this.btBusAu.Click += new System.EventHandler(this.txBusAu_Click);
            // 
            // btBusDis
            // 
            this.btBusDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusDis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBusDis.Location = new System.Drawing.Point(583, 189);
            this.btBusDis.Name = "btBusDis";
            this.btBusDis.Size = new System.Drawing.Size(160, 46);
            this.btBusDis.TabIndex = 14;
            this.btBusDis.Text = "Busqueda por Disponible";
            this.btBusDis.UseVisualStyleBackColor = true;
            this.btBusDis.Click += new System.EventHandler(this.txBusDis_Click);
            // 
            // txBusDisp
            // 
            this.txBusDisp.Location = new System.Drawing.Point(145, 115);
            this.txBusDisp.Name = "txBusDisp";
            this.txBusDisp.Size = new System.Drawing.Size(247, 24);
            this.txBusDisp.TabIndex = 15;
            this.txBusDisp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbDisponible
            // 
            this.rbDisponible.AutoSize = true;
            this.rbDisponible.Checked = true;
            this.rbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisponible.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbDisponible.Location = new System.Drawing.Point(145, 119);
            this.rbDisponible.Name = "rbDisponible";
            this.rbDisponible.Size = new System.Drawing.Size(105, 22);
            this.rbDisponible.TabIndex = 10;
            this.rbDisponible.Text = "Disponible";
            this.rbDisponible.UseVisualStyleBackColor = true;
            // 
            // rbNoDisp
            // 
            this.rbNoDisp.AutoSize = true;
            this.rbNoDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoDisp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbNoDisp.Location = new System.Drawing.Point(278, 117);
            this.rbNoDisp.Name = "rbNoDisp";
            this.rbNoDisp.Size = new System.Drawing.Size(132, 22);
            this.rbNoDisp.TabIndex = 11;
            this.rbNoDisp.Text = "No Disponible";
            this.rbNoDisp.UseVisualStyleBackColor = true;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 570);
            this.Controls.Add(this.gbConsultar);
            this.Controls.Add(this.gbIngresar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Vista";
            this.Text = "Vista";
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.gbConsultar.ResumeLayout(false);
            this.gbConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.TextBox txIngAut;
        private System.Windows.Forms.TextBox txIngNom;
        private System.Windows.Forms.TextBox txIngCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbConsultar;
        private System.Windows.Forms.Button btBusqudaCod;
        private System.Windows.Forms.TextBox txBusAut;
        private System.Windows.Forms.TextBox txBusNombre;
        private System.Windows.Forms.TextBox txBusCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txSalidaConsulta;
        private System.Windows.Forms.Button btBusDis;
        private System.Windows.Forms.Button btBusAu;
        private System.Windows.Forms.Button btBusNom;
        private System.Windows.Forms.TextBox txBusDisp;
        private System.Windows.Forms.RadioButton rbNoDisp;
        private System.Windows.Forms.RadioButton rbDisponible;
    }
}