namespace Projekt_Spital
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.buttonArzt = new System.Windows.Forms.Button();
            this.buttonSekretär = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPatient
            // 
            this.buttonPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPatient.BackgroundImage")));
            this.buttonPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPatient.Location = new System.Drawing.Point(32, 323);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(353, 169);
            this.buttonPatient.TabIndex = 0;
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // buttonArzt
            // 
            this.buttonArzt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonArzt.BackgroundImage")));
            this.buttonArzt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonArzt.Location = new System.Drawing.Point(423, 323);
            this.buttonArzt.Name = "buttonArzt";
            this.buttonArzt.Size = new System.Drawing.Size(353, 169);
            this.buttonArzt.TabIndex = 1;
            this.buttonArzt.UseVisualStyleBackColor = true;
            this.buttonArzt.Click += new System.EventHandler(this.buttonArzt_Click);
            // 
            // buttonSekretär
            // 
            this.buttonSekretär.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSekretär.BackgroundImage")));
            this.buttonSekretär.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSekretär.Location = new System.Drawing.Point(804, 323);
            this.buttonSekretär.Name = "buttonSekretär";
            this.buttonSekretär.Size = new System.Drawing.Size(353, 169);
            this.buttonSekretär.TabIndex = 2;
            this.buttonSekretär.UseVisualStyleBackColor = true;
            this.buttonSekretär.Click += new System.EventHandler(this.buttonSekretär_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arzt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekretär";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(682, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 127);
            this.label4.TabIndex = 7;
            this.label4.Text = "See Spital";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1187, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSekretär);
            this.Controls.Add(this.buttonArzt);
            this.Controls.Add(this.buttonPatient);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sea Spital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Button buttonArzt;
        private System.Windows.Forms.Button buttonSekretär;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

