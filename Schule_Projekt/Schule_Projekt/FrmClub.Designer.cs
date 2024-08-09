namespace Schule_Projekt
{
    partial class FrmClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClub));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textClubId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textClubName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBlick = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHin = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(660, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textClubId
            // 
            this.textClubId.Enabled = false;
            this.textClubId.Location = new System.Drawing.Point(287, 347);
            this.textClubId.Name = "textClubId";
            this.textClubId.Size = new System.Drawing.Size(312, 42);
            this.textClubId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Club Id :";
            // 
            // textClubName
            // 
            this.textClubName.Location = new System.Drawing.Point(287, 395);
            this.textClubName.Name = "textClubName";
            this.textClubName.Size = new System.Drawing.Size(312, 42);
            this.textClubName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Club Name :";
            // 
            // buttonBlick
            // 
            this.buttonBlick.Location = new System.Drawing.Point(128, 453);
            this.buttonBlick.Name = "buttonBlick";
            this.buttonBlick.Size = new System.Drawing.Size(199, 53);
            this.buttonBlick.TabIndex = 7;
            this.buttonBlick.Text = "Blick";
            this.buttonBlick.UseVisualStyleBackColor = true;
            this.buttonBlick.Click += new System.EventHandler(this.buttonBlick_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonHin
            // 
            this.buttonHin.Location = new System.Drawing.Point(128, 514);
            this.buttonHin.Name = "buttonHin";
            this.buttonHin.Size = new System.Drawing.Size(199, 53);
            this.buttonHin.TabIndex = 9;
            this.buttonHin.Text = "Hinzufügen";
            this.buttonHin.UseVisualStyleBackColor = true;
            this.buttonHin.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDelete);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(775, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonHin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBlick);
            this.Controls.Add(this.textClubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textClubId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClub";
            this.Load += new System.EventHandler(this.FrmClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textClubId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textClubName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBlick;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonHin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}