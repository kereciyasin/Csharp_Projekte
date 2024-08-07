namespace Projekt_Spital
{
    partial class Frmbearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbearbeiten));
            this.label6 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textNachname = new System.Windows.Forms.TextBox();
            this.textVorname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistrieren = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.maskedId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 35);
            this.label6.TabIndex = 34;
            this.label6.Text = "Gender :";
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Männer",
            "Frauen"});
            this.comboGender.Location = new System.Drawing.Point(238, 352);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(264, 43);
            this.comboGender.TabIndex = 33;
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTelefon.Location = new System.Drawing.Point(238, 236);
            this.maskedTelefon.Mask = "(000)0000000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(265, 42);
            this.maskedTelefon.TabIndex = 32;
            // 
            // textNachname
            // 
            this.textNachname.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNachname.Location = new System.Drawing.Point(238, 111);
            this.textNachname.Name = "textNachname";
            this.textNachname.Size = new System.Drawing.Size(268, 42);
            this.textNachname.TabIndex = 31;
            // 
            // textVorname
            // 
            this.textVorname.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVorname.Location = new System.Drawing.Point(238, 57);
            this.textVorname.Name = "textVorname";
            this.textVorname.Size = new System.Drawing.Size(268, 42);
            this.textVorname.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 35);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nachname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vorname :";
            // 
            // buttonRegistrieren
            // 
            this.buttonRegistrieren.BackColor = System.Drawing.Color.Red;
            this.buttonRegistrieren.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrieren.Location = new System.Drawing.Point(238, 411);
            this.buttonRegistrieren.Name = "buttonRegistrieren";
            this.buttonRegistrieren.Size = new System.Drawing.Size(265, 58);
            this.buttonRegistrieren.TabIndex = 26;
            this.buttonRegistrieren.Text = "Bearbeiten";
            this.buttonRegistrieren.UseVisualStyleBackColor = false;
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(238, 292);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(268, 42);
            this.textPass.TabIndex = 25;
            // 
            // maskedId
            // 
            this.maskedId.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedId.Location = new System.Drawing.Point(238, 174);
            this.maskedId.Mask = "00000000000";
            this.maskedId.Name = "maskedId";
            this.maskedId.Size = new System.Drawing.Size(265, 42);
            this.maskedId.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 35);
            this.label2.TabIndex = 22;
            this.label2.Text = "Patient ID :";
            // 
            // Frmbearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(651, 522);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.maskedTelefon);
            this.Controls.Add(this.textNachname);
            this.Controls.Add(this.textVorname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistrieren);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.maskedId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbearbeiten";
            this.Text = "Frmbearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.TextBox textNachname;
        private System.Windows.Forms.TextBox textVorname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrieren;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.MaskedTextBox maskedId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}