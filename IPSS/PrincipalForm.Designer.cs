﻿namespace IPSS
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.ListaBtn = new System.Windows.Forms.Button();
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.EliminarBtn);
            this.panel1.Controls.Add(this.ModificarBtn);
            this.panel1.Controls.Add(this.ListaBtn);
            this.panel1.Controls.Add(this.IngresarBtn);
            this.panel1.Location = new System.Drawing.Point(1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 499);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarBtn.Location = new System.Drawing.Point(3, 363);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(143, 27);
            this.EliminarBtn.TabIndex = 4;
            this.EliminarBtn.Text = "Eliminar Persona";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModificarBtn.Location = new System.Drawing.Point(3, 330);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(143, 27);
            this.ModificarBtn.TabIndex = 3;
            this.ModificarBtn.Text = "Modificar Persona";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // ListaBtn
            // 
            this.ListaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListaBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListaBtn.Location = new System.Drawing.Point(3, 297);
            this.ListaBtn.Name = "ListaBtn";
            this.ListaBtn.Size = new System.Drawing.Size(143, 27);
            this.ListaBtn.TabIndex = 1;
            this.ListaBtn.Text = "Filtros";
            this.ListaBtn.UseVisualStyleBackColor = true;
            this.ListaBtn.Click += new System.EventHandler(this.ListaBtn_Click);
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IngresarBtn.Location = new System.Drawing.Point(3, 260);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(144, 29);
            this.IngresarBtn.TabIndex = 0;
            this.IngresarBtn.Text = "Registar Datos";
            this.IngresarBtn.UseVisualStyleBackColor = true;
            this.IngresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelPrincipal.Location = new System.Drawing.Point(150, 27);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(756, 499);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 26);
            this.panel2.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(857, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(36, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button ListaBtn;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}