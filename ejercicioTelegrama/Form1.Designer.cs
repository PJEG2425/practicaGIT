﻿namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcularPrecio = new Button();
            lbPrecio = new Label();
            lbTexto = new Label();
            chkUrgente = new CheckBox();
            txtTelegrama = new TextBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(309, 223);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(141, 53);
            btnCalcularPrecio.TabIndex = 0;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPrecio.Location = new Point(33, 256);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(41, 15);
            lbPrecio.TabIndex = 1;
            lbPrecio.Text = "Coste:";
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTexto.Location = new Point(33, 20);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(39, 15);
            lbTexto.TabIndex = 2;
            lbTexto.Text = "Texto";
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(37, 207);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(73, 19);
            chkUrgente.TabIndex = 3;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(37, 43);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(422, 137);
            txtTelegrama.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(80, 253);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(134, 23);
            txtPrecio.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 314);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(chkUrgente);
            Controls.Add(lbTexto);
            Controls.Add(lbPrecio);
            Controls.Add(btnCalcularPrecio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularPrecio;
        private Label lbPrecio;
        private Label lbTexto;
        private CheckBox chkUrgente;
        private TextBox txtTelegrama;
        private TextBox txtPrecio;
    }
}