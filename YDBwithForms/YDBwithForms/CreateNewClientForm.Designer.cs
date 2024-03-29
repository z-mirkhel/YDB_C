namespace YDBwithForms
{
    partial class CreateNewClientForm
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
            textBoxNewF = new TextBox();
            textBoxNewI = new TextBox();
            textBoxNewO = new TextBox();
            textBoxNewPassword = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            this.maskedTextBoxNewNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxNewF
            // 
            textBoxNewF.Location = new Point(327, 45);
            textBoxNewF.Margin = new Padding(3, 4, 3, 4);
            textBoxNewF.MinimumSize = new Size(222, 30);
            textBoxNewF.Name = "textBoxNewF";
            textBoxNewF.Size = new Size(222, 31);
            textBoxNewF.TabIndex = 0;
            textBoxNewF.Enter += textBoxNewF_Enter;
            textBoxNewF.Leave += textBoxNewF_Leave;
            // 
            // textBoxNewI
            // 
            textBoxNewI.Location = new Point(327, 129);
            textBoxNewI.Margin = new Padding(3, 4, 3, 4);
            textBoxNewI.MinimumSize = new Size(222, 30);
            textBoxNewI.Name = "textBoxNewI";
            textBoxNewI.Size = new Size(222, 31);
            textBoxNewI.TabIndex = 1;
            textBoxNewI.Enter += textBoxNewI_Enter;
            textBoxNewI.Leave += textBoxNewI_Leave;
            // 
            // textBoxNewO
            // 
            textBoxNewO.Location = new Point(327, 218);
            textBoxNewO.Margin = new Padding(3, 4, 3, 4);
            textBoxNewO.MinimumSize = new Size(222, 30);
            textBoxNewO.Name = "textBoxNewO";
            textBoxNewO.Size = new Size(222, 31);
            textBoxNewO.TabIndex = 2;
            textBoxNewO.Enter += textBoxNewO_Enter;
            textBoxNewO.Leave += textBoxNewO_Leave;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(327, 394);
            textBoxNewPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPassword.MinimumSize = new Size(222, 30);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(222, 31);
            textBoxNewPassword.TabIndex = 4;
            textBoxNewPassword.Enter += textBoxNewPassword_Enter;
            textBoxNewPassword.Leave += textBoxNewPassword_Leave;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(462, 472);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.MinimumSize = new Size(167, 38);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(167, 38);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(249, 472);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.MinimumSize = new Size(167, 38);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(167, 38);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // maskedTextBoxNewNumber
            // 
            this.maskedTextBoxNewNumber.Location = new Point(327, 304);
            this.maskedTextBoxNewNumber.Margin = new Padding(3, 4, 3, 4);
            this.maskedTextBoxNewNumber.Mask = "+7(999) 999-99-99";
            this.maskedTextBoxNewNumber.MinimumSize = new Size(222, 30);
            this.maskedTextBoxNewNumber.Name = "textBoxNewNumber";
            this.maskedTextBoxNewNumber.Size = new Size(222, 31);
            this.maskedTextBoxNewNumber.TabIndex = 7;
            this.maskedTextBoxNewNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // CreateNewClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 562);
            Controls.Add(this.maskedTextBoxNewNumber);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxNewO);
            Controls.Add(textBoxNewI);
            Controls.Add(textBoxNewF);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateNewClientForm";
            Text = "CreateNewClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewF;
        private TextBox textBoxNewI;
        private TextBox textBoxNewO;
        // private TextBox textBoxNewLogin;
        private TextBox textBoxNewPassword;
        private Button buttonSave;
        private Button buttonCancel;
        private MaskedTextBox maskedTextBoxNewNumber;
    }
}