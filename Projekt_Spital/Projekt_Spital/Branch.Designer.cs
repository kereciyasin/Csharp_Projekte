﻿namespace Projekt_Spital
{
    partial class Branch
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textNachname = new System.Windows.Forms.TextBox();
            this.textVorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(105, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 63);
            this.button3.TabIndex = 27;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.Location = new System.Drawing.Point(229, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 57);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(13, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 57);
            this.button1.TabIndex = 25;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textNachname
            // 
            this.textNachname.Location = new System.Drawing.Point(216, 154);
            this.textNachname.Name = "textNachname";
            this.textNachname.Size = new System.Drawing.Size(238, 42);
            this.textNachname.TabIndex = 20;
            // 
            // textVorname
            // 
            this.textVorname.Location = new System.Drawing.Point(216, 103);
            this.textVorname.Name = "textVorname";
            this.textVorname.Size = new System.Drawing.Size(238, 42);
            this.textVorname.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branch Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Branch ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(473, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(620, 309);
            this.dataGridView1.TabIndex = 24;
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNachname);
            this.Controls.Add(this.textVorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Branch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Branch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNachname;
        private System.Windows.Forms.TextBox textVorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}