namespace WindowsFormsApp1
{
    partial class Form3
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
            this.listBoxListaPaises = new System.Windows.Forms.ListBox();
            this.textBoxPaisSeleccionado = new System.Windows.Forms.TextBox();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEsHombre = new System.Windows.Forms.TextBox();
            this.buttonDatePick = new System.Windows.Forms.Button();
            this.textBoxShowDate = new System.Windows.Forms.TextBox();
            this.dateTimePickerToday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxListaPaises
            // 
            this.listBoxListaPaises.AllowDrop = true;
            this.listBoxListaPaises.FormattingEnabled = true;
            this.listBoxListaPaises.ItemHeight = 25;
            this.listBoxListaPaises.Items.AddRange(new object[] {
            "Estados Unidos",
            "Canadá",
            "Francia",
            "Japón",
            "Brasil",
            "Australia",
            "India",
            "Sudáfrica",
            "Italia",
            "Argentina"});
            this.listBoxListaPaises.Location = new System.Drawing.Point(427, 115);
            this.listBoxListaPaises.Name = "listBoxListaPaises";
            this.listBoxListaPaises.Size = new System.Drawing.Size(188, 279);
            this.listBoxListaPaises.TabIndex = 1;
            this.listBoxListaPaises.UseWaitCursor = true;
            this.listBoxListaPaises.SelectedValueChanged += new System.EventHandler(this.OnSelectPais);
            // 
            // textBoxPaisSeleccionado
            // 
            this.textBoxPaisSeleccionado.Location = new System.Drawing.Point(427, 440);
            this.textBoxPaisSeleccionado.Name = "textBoxPaisSeleccionado";
            this.textBoxPaisSeleccionado.Size = new System.Drawing.Size(188, 31);
            this.textBoxPaisSeleccionado.TabIndex = 2;
            this.textBoxPaisSeleccionado.UseWaitCursor = true;
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(6, 55);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(118, 29);
            this.radioButtonHombre.TabIndex = 3;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            this.radioButtonHombre.UseWaitCursor = true;
            this.radioButtonHombre.CheckedChanged += new System.EventHandler(this.enHombre);
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(6, 90);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(97, 29);
            this.radioButtonMujer.TabIndex = 4;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            this.radioButtonMujer.UseWaitCursor = true;
            this.radioButtonMujer.CheckedChanged += new System.EventHandler(this.enMujer);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHombre);
            this.groupBox1.Controls.Add(this.radioButtonMujer);
            this.groupBox1.Location = new System.Drawing.Point(866, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 279);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxEsHombre
            // 
            this.textBoxEsHombre.Location = new System.Drawing.Point(931, 440);
            this.textBoxEsHombre.Name = "textBoxEsHombre";
            this.textBoxEsHombre.Size = new System.Drawing.Size(100, 31);
            this.textBoxEsHombre.TabIndex = 6;
            this.textBoxEsHombre.UseWaitCursor = true;
            this.textBoxEsHombre.TextChanged += new System.EventHandler(this.textBoxEsHombre_TextChanged);
            // 
            // buttonDatePick
            // 
            this.buttonDatePick.Location = new System.Drawing.Point(109, 252);
            this.buttonDatePick.Name = "buttonDatePick";
            this.buttonDatePick.Size = new System.Drawing.Size(200, 46);
            this.buttonDatePick.TabIndex = 7;
            this.buttonDatePick.Text = "ShowDate";
            this.buttonDatePick.UseVisualStyleBackColor = true;
            this.buttonDatePick.UseWaitCursor = true;
            this.buttonDatePick.Click += new System.EventHandler(this.showDate);
            // 
            // textBoxShowDate
            // 
            this.textBoxShowDate.Location = new System.Drawing.Point(109, 440);
            this.textBoxShowDate.Name = "textBoxShowDate";
            this.textBoxShowDate.Size = new System.Drawing.Size(200, 31);
            this.textBoxShowDate.TabIndex = 8;
            this.textBoxShowDate.UseWaitCursor = true;
            // 
            // dateTimePickerToday
            // 
            this.dateTimePickerToday.CustomFormat = "  yyyy-mm-dd";
            this.dateTimePickerToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToday.Location = new System.Drawing.Point(109, 115);
            this.dateTimePickerToday.Name = "dateTimePickerToday";
            this.dateTimePickerToday.ShowCheckBox = true;
            this.dateTimePickerToday.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerToday.TabIndex = 9;
            this.dateTimePickerToday.UseWaitCursor = true;
            this.dateTimePickerToday.ValueChanged += new System.EventHandler(this.dateTimePickerToday_ValueChanged_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 829);
            this.Controls.Add(this.dateTimePickerToday);
            this.Controls.Add(this.textBoxShowDate);
            this.Controls.Add(this.buttonDatePick);
            this.Controls.Add(this.textBoxEsHombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxPaisSeleccionado);
            this.Controls.Add(this.listBoxListaPaises);
            this.Name = "Form3";
            this.Text = "Form3";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxListaPaises;
        private System.Windows.Forms.TextBox textBoxPaisSeleccionado;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEsHombre;
        private System.Windows.Forms.Button buttonDatePick;
        private System.Windows.Forms.TextBox textBoxShowDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToday;
    }
}