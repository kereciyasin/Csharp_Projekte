namespace Projekt_Spital
{
    partial class ArztPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArztPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textVorname = new System.Windows.Forms.TextBox();
            this.textNachname = new System.Windows.Forms.TextBox();
            this.comboBranch = new System.Windows.Forms.ComboBox();
            this.maskedNummer = new System.Windows.Forms.MaskedTextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nummer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // textVorname
            // 
            this.textVorname.Location = new System.Drawing.Point(228, 64);
            this.textVorname.Name = "textVorname";
            this.textVorname.Size = new System.Drawing.Size(238, 42);
            this.textVorname.TabIndex = 1;
            // 
            // textNachname
            // 
            this.textNachname.Location = new System.Drawing.Point(228, 115);
            this.textNachname.Name = "textNachname";
            this.textNachname.Size = new System.Drawing.Size(238, 42);
            this.textNachname.TabIndex = 2;
            // 
            // comboBranch
            // 
            this.comboBranch.FormattingEnabled = true;
            this.comboBranch.Location = new System.Drawing.Point(228, 163);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.Size = new System.Drawing.Size(237, 43);
            this.comboBranch.TabIndex = 3;
            this.comboBranch.SelectedIndexChanged += new System.EventHandler(this.comboBranch_SelectedIndexChanged);
            // 
            // maskedNummer
            // 
            this.maskedNummer.Location = new System.Drawing.Point(228, 220);
            this.maskedNummer.Mask = "00000000000";
            this.maskedNummer.Name = "maskedNummer";
            this.maskedNummer.Size = new System.Drawing.Size(237, 42);
            this.maskedNummer.TabIndex = 4;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(227, 272);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(238, 42);
            this.textPass.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(630, 512);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(226, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.Location = new System.Drawing.Point(227, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(228, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 63);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ArztPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1178, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.maskedNummer);
            this.Controls.Add(this.comboBranch);
            this.Controls.Add(this.textNachname);
            this.Controls.Add(this.textVorname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ArztPanel";
            this.Text = "ArztPanel";
            this.Load += new System.EventHandler(this.ArztPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textVorname;
        private System.Windows.Forms.TextBox textNachname;
        private System.Windows.Forms.ComboBox comboBranch;
        private System.Windows.Forms.MaskedTextBox maskedNummer;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}