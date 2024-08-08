namespace Projekt_Spital
{
    partial class Arzt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arzt));
            this.buttonEinloggen = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.maskedId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEinloggen
            // 
            this.buttonEinloggen.Location = new System.Drawing.Point(359, 352);
            this.buttonEinloggen.Name = "buttonEinloggen";
            this.buttonEinloggen.Size = new System.Drawing.Size(164, 58);
            this.buttonEinloggen.TabIndex = 13;
            this.buttonEinloggen.Text = "Einloggen";
            this.buttonEinloggen.UseVisualStyleBackColor = true;
            this.buttonEinloggen.Click += new System.EventHandler(this.buttonEinloggen_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(258, 269);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(268, 42);
            this.textPass.TabIndex = 11;
            this.textPass.Text = "12345";
            this.textPass.UseSystemPasswordChar = true;
            // 
            // maskedId
            // 
            this.maskedId.Location = new System.Drawing.Point(258, 199);
            this.maskedId.Mask = "00000000000";
            this.maskedId.Name = "maskedId";
            this.maskedId.Size = new System.Drawing.Size(265, 42);
            this.maskedId.TabIndex = 10;
            this.maskedId.Text = "12345678901";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arzt ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "Arztanmeldepanel";
            // 
            // Arzt
            // 
            this.AcceptButton = this.buttonEinloggen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(886, 533);
            this.Controls.Add(this.buttonEinloggen);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.maskedId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Arzt";
            this.Text = "Arzt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEinloggen;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.MaskedTextBox maskedId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}