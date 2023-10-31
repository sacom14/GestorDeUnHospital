namespace WindowsFormsApp1
{
    partial class SamirFormulario1
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.checkBoxWantSendEmail = new System.Windows.Forms.CheckBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.butSubmit = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.labelPercentComplete = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.labelCriticilty = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelLocalitation = new System.Windows.Forms.Label();
            this.comboBoxLocalitation = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCriticilty = new System.Windows.Forms.ComboBox();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxEnvironment = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(79, 351);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(371, 31);
            this.textBoxDescription.TabIndex = 36;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(79, 82);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(371, 31);
            this.textBoxTitle.TabIndex = 35;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // checkBoxWantSendEmail
            // 
            this.checkBoxWantSendEmail.AutoSize = true;
            this.checkBoxWantSendEmail.Location = new System.Drawing.Point(66, 660);
            this.checkBoxWantSendEmail.Name = "checkBoxWantSendEmail";
            this.checkBoxWantSendEmail.Size = new System.Drawing.Size(439, 29);
            this.checkBoxWantSendEmail.TabIndex = 34;
            this.checkBoxWantSendEmail.Text = "Check here if you want to send and email";
            this.checkBoxWantSendEmail.UseVisualStyleBackColor = true;
            this.checkBoxWantSendEmail.CheckedChanged += new System.EventHandler(this.checkBoxWantSendEmail_CheckedChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(89, 433);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(105, 25);
            this.labelStartDate.TabIndex = 33;
            this.labelStartDate.Text = "Start date";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(226, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(53, 25);
            this.labelTitle.TabIndex = 32;
            this.labelTitle.Text = "Title";
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(914, 738);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(110, 38);
            this.butSubmit.TabIndex = 31;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(716, 738);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(97, 38);
            this.butCancel.TabIndex = 30;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // labelPercentComplete
            // 
            this.labelPercentComplete.AutoSize = true;
            this.labelPercentComplete.Location = new System.Drawing.Point(634, 487);
            this.labelPercentComplete.Name = "labelPercentComplete";
            this.labelPercentComplete.Size = new System.Drawing.Size(179, 25);
            this.labelPercentComplete.TabIndex = 29;
            this.labelPercentComplete.Text = "Percent complete";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(61, 540);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 28;
            this.labelStatus.Text = "Status";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(629, 381);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(190, 25);
            this.labelDuration.TabIndex = 27;
            this.labelDuration.Text = "Duration (in hours)";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(108, 323);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 26;
            this.labelDescription.Text = "Description";
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Location = new System.Drawing.Point(697, 163);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(132, 25);
            this.labelEnvironment.TabIndex = 25;
            this.labelEnvironment.Text = "Environment";
            // 
            // labelCriticilty
            // 
            this.labelCriticilty.AutoSize = true;
            this.labelCriticilty.Location = new System.Drawing.Point(301, 163);
            this.labelCriticilty.Name = "labelCriticilty";
            this.labelCriticilty.Size = new System.Drawing.Size(88, 25);
            this.labelCriticilty.TabIndex = 24;
            this.labelCriticilty.Text = "Criticilty";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(74, 163);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 25);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Type";
            // 
            // labelLocalitation
            // 
            this.labelLocalitation.AutoSize = true;
            this.labelLocalitation.Location = new System.Drawing.Point(757, 35);
            this.labelLocalitation.Name = "labelLocalitation";
            this.labelLocalitation.Size = new System.Drawing.Size(122, 25);
            this.labelLocalitation.TabIndex = 22;
            this.labelLocalitation.Text = "Localitation";
            // 
            // comboBoxLocalitation
            // 
            this.comboBoxLocalitation.FormattingEnabled = true;
            this.comboBoxLocalitation.Items.AddRange(new object[] {
            "Barcelona",
            "Igualada",
            "Esparraguera",
            "Collbató",
            "L\'hospitatel",
            "Mataró",
            "El Masnou"});
            this.comboBoxLocalitation.Location = new System.Drawing.Point(676, 80);
            this.comboBoxLocalitation.Name = "comboBoxLocalitation";
            this.comboBoxLocalitation.Size = new System.Drawing.Size(268, 33);
            this.comboBoxLocalitation.TabIndex = 40;
            this.comboBoxLocalitation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocalitation_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(79, 219);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 33);
            this.comboBoxType.TabIndex = 41;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxCriticilty
            // 
            this.comboBoxCriticilty.FormattingEnabled = true;
            this.comboBoxCriticilty.Location = new System.Drawing.Point(306, 219);
            this.comboBoxCriticilty.Name = "comboBoxCriticilty";
            this.comboBoxCriticilty.Size = new System.Drawing.Size(121, 33);
            this.comboBoxCriticilty.TabIndex = 42;
            this.comboBoxCriticilty.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriticilty_SelectedIndexChanged);
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStartDate.Location = new System.Drawing.Point(96, 481);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(200, 31);
            this.dateTimeStartDate.TabIndex = 43;
            this.dateTimeStartDate.Value = new System.DateTime(2023, 10, 27, 17, 51, 58, 0);
            this.dateTimeStartDate.ValueChanged += new System.EventHandler(this.dateTimeStartDate_ValueChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Planned"});
            this.comboBoxStatus.Location = new System.Drawing.Point(68, 592);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 33);
            this.comboBoxStatus.TabIndex = 45;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPercentage.Location = new System.Drawing.Point(676, 559);
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownPercentage.TabIndex = 47;
            this.numericUpDownPercentage.ValueChanged += new System.EventHandler(this.numericUpDownPercentage_ValueChanged);
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.DecimalPlaces = 2;
            this.numericUpDownDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDuration.Location = new System.Drawing.Point(676, 426);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownDuration.TabIndex = 48;
            this.numericUpDownDuration.ValueChanged += new System.EventHandler(this.numericUpDownDuration_ValueChanged);
            // 
            // checkedListBoxEnvironment
            // 
            this.checkedListBoxEnvironment.CheckOnClick = true;
            this.checkedListBoxEnvironment.FormattingEnabled = true;
            this.checkedListBoxEnvironment.Items.AddRange(new object[] {
            "Prod",
            "Preprod",
            "Demo"});
            this.checkedListBoxEnvironment.Location = new System.Drawing.Point(676, 207);
            this.checkedListBoxEnvironment.Name = "checkedListBoxEnvironment";
            this.checkedListBoxEnvironment.Size = new System.Drawing.Size(268, 116);
            this.checkedListBoxEnvironment.TabIndex = 49;
            this.checkedListBoxEnvironment.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEnvironment_SelectedIndexChanged);
            // 
            // SamirFormulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 864);
            this.Controls.Add(this.checkedListBoxEnvironment);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.numericUpDownPercentage);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(this.comboBoxCriticilty);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxLocalitation);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.checkBoxWantSendEmail);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.labelPercentComplete);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEnvironment);
            this.Controls.Add(this.labelCriticilty);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelLocalitation);
            this.Name = "SamirFormulario1";
            this.Text = "SamirFormulario1";
            this.Load += new System.EventHandler(this.SamirFormulario1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxWantSendEmail;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label labelPercentComplete;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.Label labelCriticilty;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelLocalitation;
        private System.Windows.Forms.ComboBox comboBoxLocalitation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxCriticilty;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.CheckedListBox checkedListBoxEnvironment;
    }
}