namespace IPSS
{
    partial class AgregarLiquidacion
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
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.Tipolbl = new System.Windows.Forms.Label();
            this.tipoBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.LiquidacionFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(90, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificacionTxt.Location = new System.Drawing.Point(173, 79);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(121, 20);
            this.IdentificacionTxt.TabIndex = 1;
            // 
            // Tipolbl
            // 
            this.Tipolbl.AutoSize = true;
            this.Tipolbl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipolbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipolbl.Location = new System.Drawing.Point(90, 119);
            this.Tipolbl.Name = "Tipolbl";
            this.Tipolbl.Size = new System.Drawing.Size(81, 14);
            this.Tipolbl.TabIndex = 2;
            this.Tipolbl.Text = "Tipo Afiliación:";
            // 
            // tipoBox
            // 
            this.tipoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoBox.FormattingEnabled = true;
            this.tipoBox.Items.AddRange(new object[] {
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.tipoBox.Location = new System.Drawing.Point(175, 116);
            this.tipoBox.Name = "tipoBox";
            this.tipoBox.Size = new System.Drawing.Size(119, 22);
            this.tipoBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(109, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTxt.Location = new System.Drawing.Point(175, 160);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(117, 20);
            this.NombreTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(377, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario:";
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioTxt.Location = new System.Drawing.Point(438, 75);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(115, 20);
            this.SalarioTxt.TabIndex = 7;
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorServicioTxt.Location = new System.Drawing.Point(438, 131);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(115, 20);
            this.ValorServicioTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(354, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Servicio:";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarBtn.Location = new System.Drawing.Point(267, 221);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(152, 58);
            this.AgregarBtn.TabIndex = 10;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // LiquidacionFecha
            // 
            this.LiquidacionFecha.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiquidacionFecha.Location = new System.Drawing.Point(373, 169);
            this.LiquidacionFecha.Name = "LiquidacionFecha";
            this.LiquidacionFecha.Size = new System.Drawing.Size(183, 20);
            this.LiquidacionFecha.TabIndex = 11;
            // 
            // AgregarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(756, 499);
            this.Controls.Add(this.LiquidacionFecha);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoBox);
            this.Controls.Add(this.Tipolbl);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarLiquidacion";
            this.Text = "AgregarLiquidacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.Label Tipolbl;
        private System.Windows.Forms.ComboBox tipoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DateTimePicker LiquidacionFecha;
    }
}