namespace Projekt_Spital
{
    partial class Patientenanmeldung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedId = new System.Windows.Forms.MaskedTextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.buttonEinloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patientenanmeldepanel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // maskedId
            // 
            this.maskedId.Location = new System.Drawing.Point(402, 251);
            this.maskedId.Mask = "00000000000";
            this.maskedId.Name = "maskedId";
            this.maskedId.Size = new System.Drawing.Size(265, 42);
            this.maskedId.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(402, 321);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(268, 42);
            this.textPass.TabIndex = 4;
            this.textPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(706, 328);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(168, 35);
            this.Link.TabIndex = 5;
            this.Link.TabStop = true;
            this.Link.Text = "Registrieren?";
            // 
            // buttonEinloggen
            // 
            this.buttonEinloggen.Location = new System.Drawing.Point(503, 404);
            this.buttonEinloggen.Name = "buttonEinloggen";
            this.buttonEinloggen.Size = new System.Drawing.Size(164, 58);
            this.buttonEinloggen.TabIndex = 6;
            this.buttonEinloggen.Text = "Einloggen";
            this.buttonEinloggen.UseVisualStyleBackColor = true;
            // 
            // Patientenanmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1212, 721);
            this.Controls.Add(this.buttonEinloggen);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.maskedId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Patientenanmeldung";
            this.Text = "Patientenanmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedId;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Button buttonEinloggen;
    }
}