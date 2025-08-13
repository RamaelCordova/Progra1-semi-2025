namespace miPrimerProyectoCsharp
{
    partial class Form1
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.optsuma = new System.Windows.Forms.RadioButton();
            this.optresta = new System.Windows.Forms.RadioButton();
            this.optmultiplicacion = new System.Windows.Forms.RadioButton();
            this.optdivision = new System.Windows.Forms.RadioButton();
            this.optexponente = new System.Windows.Forms.RadioButton();
            this.cboopciones = new System.Windows.Forms.ComboBox();
            this.btncalcularopciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(122, 52);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(76, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(64, 54);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(38, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Num 1";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(109, 182);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(80, 36);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(64, 98);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(38, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Num 2";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(122, 96);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(76, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(64, 143);
            this.lblrespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(67, 13);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "Respuesta ?";
            // 
            // optsuma
            // 
            this.optsuma.AutoSize = true;
            this.optsuma.Location = new System.Drawing.Point(268, 63);
            this.optsuma.Name = "optsuma";
            this.optsuma.Size = new System.Drawing.Size(50, 17);
            this.optsuma.TabIndex = 6;
            this.optsuma.TabStop = true;
            this.optsuma.Text = "suma";
            this.optsuma.UseVisualStyleBackColor = true;
            // 
            // optresta
            // 
            this.optresta.AutoSize = true;
            this.optresta.Location = new System.Drawing.Point(268, 86);
            this.optresta.Name = "optresta";
            this.optresta.Size = new System.Drawing.Size(48, 17);
            this.optresta.TabIndex = 7;
            this.optresta.TabStop = true;
            this.optresta.Text = "resta";
            this.optresta.UseVisualStyleBackColor = true;
            // 
            // optmultiplicacion
            // 
            this.optmultiplicacion.AutoSize = true;
            this.optmultiplicacion.Location = new System.Drawing.Point(268, 109);
            this.optmultiplicacion.Name = "optmultiplicacion";
            this.optmultiplicacion.Size = new System.Drawing.Size(88, 17);
            this.optmultiplicacion.TabIndex = 8;
            this.optmultiplicacion.TabStop = true;
            this.optmultiplicacion.Text = "multiplicación";
            this.optmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optdivision
            // 
            this.optdivision.AutoSize = true;
            this.optdivision.Location = new System.Drawing.Point(268, 132);
            this.optdivision.Name = "optdivision";
            this.optdivision.Size = new System.Drawing.Size(60, 17);
            this.optdivision.TabIndex = 9;
            this.optdivision.TabStop = true;
            this.optdivision.Text = "división";
            this.optdivision.UseVisualStyleBackColor = true;
            // 
            // optexponente
            // 
            this.optexponente.AutoSize = true;
            this.optexponente.Location = new System.Drawing.Point(268, 155);
            this.optexponente.Name = "optexponente";
            this.optexponente.Size = new System.Drawing.Size(75, 17);
            this.optexponente.TabIndex = 10;
            this.optexponente.TabStop = true;
            this.optexponente.Text = "exponente";
            this.optexponente.UseVisualStyleBackColor = true;
            // 
            // cboopciones
            // 
            this.cboopciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboopciones.FormattingEnabled = true;
            this.cboopciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion ",
            "Division "});
            this.cboopciones.Location = new System.Drawing.Point(363, 63);
            this.cboopciones.Name = "cboopciones";
            this.cboopciones.Size = new System.Drawing.Size(121, 21);
            this.cboopciones.TabIndex = 11;
            // 
            // btncalcularopciones
            // 
            this.btncalcularopciones.Location = new System.Drawing.Point(363, 99);
            this.btncalcularopciones.Margin = new System.Windows.Forms.Padding(2);
            this.btncalcularopciones.Name = "btncalcularopciones";
            this.btncalcularopciones.Size = new System.Drawing.Size(80, 36);
            this.btncalcularopciones.TabIndex = 12;
            this.btncalcularopciones.Text = "Calcular";
            this.btncalcularopciones.UseVisualStyleBackColor = true;
            this.btncalcularopciones.Click += new System.EventHandler(this.btncalcularopciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 366);
            this.Controls.Add(this.btncalcularopciones);
            this.Controls.Add(this.cboopciones);
            this.Controls.Add(this.optexponente);
            this.Controls.Add(this.optdivision);
            this.Controls.Add(this.optmultiplicacion);
            this.Controls.Add(this.optresta);
            this.Controls.Add(this.optsuma);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtnum1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.RadioButton optsuma;
        private System.Windows.Forms.RadioButton optresta;
        private System.Windows.Forms.RadioButton optmultiplicacion;
        private System.Windows.Forms.RadioButton optdivision;
        private System.Windows.Forms.RadioButton optexponente;
        private System.Windows.Forms.ComboBox cboopciones;
        private System.Windows.Forms.Button btncalcularopciones;
    }
}

