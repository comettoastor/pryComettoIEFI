﻿namespace pryComettoIEFI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.btnRegistrarSocio = new System.Windows.Forms.Button();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.mrcSexo = new System.Windows.Forms.GroupBox();
            this.tabRegistro = new System.Windows.Forms.TabControl();
            this.Socios = new System.Windows.Forms.TabPage();
            this.numIngreso = new System.Windows.Forms.NumericUpDown();
            this.numPuntaje = new System.Windows.Forms.NumericUpDown();
            this.Paises = new System.Windows.Forms.TabPage();
            this.btnRegistrarPais = new System.Windows.Forms.Button();
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.mrcPais = new System.Windows.Forms.GroupBox();
            this.mrcSocio = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.mrcSexo.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.Socios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntaje)).BeginInit();
            this.Paises.SuspendLayout();
            this.mrcPais.SuspendLayout();
            this.mrcSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(62, 22);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSocio.TabIndex = 0;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Checked = true;
            this.optMasculino.Location = new System.Drawing.Point(6, 19);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 0;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSocio
            // 
            this.btnRegistrarSocio.Location = new System.Drawing.Point(229, 239);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarSocio.TabIndex = 6;
            this.btnRegistrarSocio.Text = "Registrar";
            this.btnRegistrarSocio.UseVisualStyleBackColor = true;
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(62, 74);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(100, 21);
            this.cmbPais.TabIndex = 2;
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(62, 101);
            this.numEdad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numEdad.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(47, 20);
            this.numEdad.TabIndex = 3;
            this.numEdad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.Location = new System.Drawing.Point(12, 25);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(44, 13);
            this.lblNombreSocio.TabIndex = 7;
            this.lblNombreSocio.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 51);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(62, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(27, 77);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "País";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(24, 103);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(85, 19);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 17);
            this.optFemenino.TabIndex = 1;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(14, 195);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 13;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(13, 221);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 15;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // mrcSexo
            // 
            this.mrcSexo.Controls.Add(this.optMasculino);
            this.mrcSexo.Controls.Add(this.optFemenino);
            this.mrcSexo.Location = new System.Drawing.Point(7, 137);
            this.mrcSexo.Name = "mrcSexo";
            this.mrcSexo.Size = new System.Drawing.Size(162, 48);
            this.mrcSexo.TabIndex = 16;
            this.mrcSexo.TabStop = false;
            this.mrcSexo.Text = "Sexo";
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.Socios);
            this.tabRegistro.Controls.Add(this.Paises);
            this.tabRegistro.Location = new System.Drawing.Point(12, 12);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.SelectedIndex = 0;
            this.tabRegistro.Size = new System.Drawing.Size(330, 305);
            this.tabRegistro.TabIndex = 0;
            // 
            // Socios
            // 
            this.Socios.Controls.Add(this.mrcSocio);
            this.Socios.Location = new System.Drawing.Point(4, 22);
            this.Socios.Name = "Socios";
            this.Socios.Padding = new System.Windows.Forms.Padding(3);
            this.Socios.Size = new System.Drawing.Size(322, 279);
            this.Socios.TabIndex = 0;
            this.Socios.Text = "Socios";
            this.Socios.UseVisualStyleBackColor = true;
            // 
            // numIngreso
            // 
            this.numIngreso.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIngreso.Location = new System.Drawing.Point(62, 191);
            this.numIngreso.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numIngreso.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIngreso.Name = "numIngreso";
            this.numIngreso.Size = new System.Drawing.Size(100, 20);
            this.numIngreso.TabIndex = 4;
            this.numIngreso.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numPuntaje
            // 
            this.numPuntaje.DecimalPlaces = 1;
            this.numPuntaje.Location = new System.Drawing.Point(62, 218);
            this.numPuntaje.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numPuntaje.Minimum = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            this.numPuntaje.Name = "numPuntaje";
            this.numPuntaje.Size = new System.Drawing.Size(63, 20);
            this.numPuntaje.TabIndex = 5;
            this.numPuntaje.Value = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            // 
            // Paises
            // 
            this.Paises.Controls.Add(this.mrcPais);
            this.Paises.Controls.Add(this.btnRegistrarPais);
            this.Paises.Location = new System.Drawing.Point(4, 22);
            this.Paises.Name = "Paises";
            this.Paises.Padding = new System.Windows.Forms.Padding(3);
            this.Paises.Size = new System.Drawing.Size(322, 279);
            this.Paises.TabIndex = 1;
            this.Paises.Text = "Países";
            this.Paises.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPais
            // 
            this.btnRegistrarPais.Location = new System.Drawing.Point(241, 250);
            this.btnRegistrarPais.Name = "btnRegistrarPais";
            this.btnRegistrarPais.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarPais.TabIndex = 1;
            this.btnRegistrarPais.Text = "Registrar";
            this.btnRegistrarPais.UseVisualStyleBackColor = true;
            this.btnRegistrarPais.Click += new System.EventHandler(this.btnRegistrarPais_Click);
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Location = new System.Drawing.Point(17, 26);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePais.TabIndex = 9;
            this.lblNombrePais.Text = "Nombre";
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(67, 23);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePais.TabIndex = 0;
            // 
            // mrcPais
            // 
            this.mrcPais.Controls.Add(this.txtNombrePais);
            this.mrcPais.Controls.Add(this.lblNombrePais);
            this.mrcPais.Location = new System.Drawing.Point(6, 6);
            this.mrcPais.Name = "mrcPais";
            this.mrcPais.Size = new System.Drawing.Size(181, 60);
            this.mrcPais.TabIndex = 10;
            this.mrcPais.TabStop = false;
            this.mrcPais.Text = "Registrar País";
            // 
            // mrcSocio
            // 
            this.mrcSocio.Controls.Add(this.lblNombreSocio);
            this.mrcSocio.Controls.Add(this.btnRegistrarSocio);
            this.mrcSocio.Controls.Add(this.numIngreso);
            this.mrcSocio.Controls.Add(this.lblApellido);
            this.mrcSocio.Controls.Add(this.numPuntaje);
            this.mrcSocio.Controls.Add(this.lblPais);
            this.mrcSocio.Controls.Add(this.txtApellido);
            this.mrcSocio.Controls.Add(this.lblEdad);
            this.mrcSocio.Controls.Add(this.mrcSexo);
            this.mrcSocio.Controls.Add(this.numEdad);
            this.mrcSocio.Controls.Add(this.lblPuntaje);
            this.mrcSocio.Controls.Add(this.lblIngreso);
            this.mrcSocio.Controls.Add(this.txtNombreSocio);
            this.mrcSocio.Controls.Add(this.cmbPais);
            this.mrcSocio.Location = new System.Drawing.Point(6, 6);
            this.mrcSocio.Name = "mrcSocio";
            this.mrcSocio.Size = new System.Drawing.Size(310, 268);
            this.mrcSocio.TabIndex = 17;
            this.mrcSocio.TabStop = false;
            this.mrcSocio.Text = "Registrar Socio";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 319);
            this.Controls.Add(this.tabRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - EL CLUB";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.mrcSexo.ResumeLayout(false);
            this.mrcSexo.PerformLayout();
            this.tabRegistro.ResumeLayout(false);
            this.Socios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntaje)).EndInit();
            this.Paises.ResumeLayout(false);
            this.mrcPais.ResumeLayout(false);
            this.mrcPais.PerformLayout();
            this.mrcSocio.ResumeLayout(false);
            this.mrcSocio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.Button btnRegistrarSocio;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.GroupBox mrcSexo;
        private System.Windows.Forms.TabControl tabRegistro;
        private System.Windows.Forms.TabPage Socios;
        private System.Windows.Forms.TabPage Paises;
        private System.Windows.Forms.Button btnRegistrarPais;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.NumericUpDown numPuntaje;
        private System.Windows.Forms.NumericUpDown numIngreso;
        private System.Windows.Forms.GroupBox mrcPais;
        private System.Windows.Forms.GroupBox mrcSocio;
    }
}

