namespace WindowsFormsApp1
{
    partial class textBoxNombre
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.butSaberNombre = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.butNewForm = new System.Windows.Forms.Button();
            this.buttonForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(207, 102);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // butSaberNombre
            // 
            this.butSaberNombre.Location = new System.Drawing.Point(212, 196);
            this.butSaberNombre.Name = "butSaberNombre";
            this.butSaberNombre.Size = new System.Drawing.Size(188, 41);
            this.butSaberNombre.TabIndex = 1;
            this.butSaberNombre.Text = "Escribir nombre";
            this.butSaberNombre.UseVisualStyleBackColor = true;
            this.butSaberNombre.Click += new System.EventHandler(this.butSaberNombre_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(212, 130);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 31);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // butNewForm
            // 
            this.butNewForm.Location = new System.Drawing.Point(212, 331);
            this.butNewForm.Name = "butNewForm";
            this.butNewForm.Size = new System.Drawing.Size(165, 63);
            this.butNewForm.TabIndex = 3;
            this.butNewForm.Text = "Formulario 1";
            this.butNewForm.UseVisualStyleBackColor = true;
            this.butNewForm.Click += new System.EventHandler(this.butNewForm_Click);
            // 
            // buttonForm3
            // 
            this.buttonForm3.Location = new System.Drawing.Point(518, 331);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(158, 63);
            this.buttonForm3.TabIndex = 4;
            this.buttonForm3.Text = "Formulario 3";
            this.buttonForm3.UseVisualStyleBackColor = true;
            this.buttonForm3.Click += new System.EventHandler(this.OpenForm3);
            // 
            // textBoxNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 823);
            this.Controls.Add(this.buttonForm3);
            this.Controls.Add(this.butNewForm);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.butSaberNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "textBoxNombre";
            this.Text = "text box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FormPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button butSaberNombre;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button butNewForm;
        private System.Windows.Forms.Button buttonForm3;
    }
}

