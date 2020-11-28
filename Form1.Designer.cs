namespace GuitarExercises
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
            this.randomE = new System.Windows.Forms.Button();
            this.SNEButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.TempoBox = new System.Windows.Forms.TextBox();
            this.UEEButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomE
            // 
            this.randomE.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomE.Location = new System.Drawing.Point(55, 347);
            this.randomE.Name = "randomE";
            this.randomE.Size = new System.Drawing.Size(160, 46);
            this.randomE.TabIndex = 0;
            this.randomE.Text = "Hit Me!";
            this.randomE.UseVisualStyleBackColor = true;
            this.randomE.Click += new System.EventHandler(this.button1_Click);
            // 
            // SNEButton
            // 
            this.SNEButton.Location = new System.Drawing.Point(328, 370);
            this.SNEButton.Name = "SNEButton";
            this.SNEButton.Size = new System.Drawing.Size(130, 23);
            this.SNEButton.TabIndex = 2;
            this.SNEButton.Text = "Save new Exercise";
            this.SNEButton.UseVisualStyleBackColor = true;
            this.SNEButton.Click += new System.EventHandler(this.SNEButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(55, 37);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(403, 51);
            this.NameBox.TabIndex = 3;
            this.NameBox.Text = "Legato";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // DescBox
            // 
            this.DescBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescBox.Location = new System.Drawing.Point(55, 131);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DescBox.Size = new System.Drawing.Size(403, 142);
            this.DescBox.TabIndex = 4;
            this.DescBox.Text = "legato deez nuts mothafuckaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfasfsdfdsafasdfasfs SD" +
    "GFG FDGS DsdfghsdfgAEADFGVADFCGBSDFVCBASDFGAFGADFGADFG IPSSSOLEMISPUM BUTM\r\n\r\n";
            this.DescBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DescBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TempoBox
            // 
            this.TempoBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoBox.Location = new System.Drawing.Point(55, 292);
            this.TempoBox.Multiline = true;
            this.TempoBox.Name = "TempoBox";
            this.TempoBox.Size = new System.Drawing.Size(46, 32);
            this.TempoBox.TabIndex = 5;
            this.TempoBox.Text = "150";
            this.TempoBox.TextChanged += new System.EventHandler(this.TempoBox_TextChanged);
            // 
            // UEEButton
            // 
            this.UEEButton.Location = new System.Drawing.Point(328, 311);
            this.UEEButton.Name = "UEEButton";
            this.UEEButton.Size = new System.Drawing.Size(130, 23);
            this.UEEButton.TabIndex = 6;
            this.UEEButton.Text = "Update existing exercise";
            this.UEEButton.UseVisualStyleBackColor = true;
            this.UEEButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 440);
            this.Controls.Add(this.UEEButton);
            this.Controls.Add(this.TempoBox);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SNEButton);
            this.Controls.Add(this.randomE);
            this.Name = "Form1";
            this.Text = "Exercise Randomizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomE;
        private System.Windows.Forms.Button SNEButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox TempoBox;
        private System.Windows.Forms.Button UEEButton;
    }
}

