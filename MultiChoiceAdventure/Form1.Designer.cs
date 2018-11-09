namespace MultiChoiceAdventure
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueText = new System.Windows.Forms.Label();
            this.redText = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.yellowText = new System.Windows.Forms.Label();
            this.labelDebug = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(86, 17);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "OutputLabel";
            // 
            // blueText
            // 
            this.blueText.AutoSize = true;
            this.blueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueText.Location = new System.Drawing.Point(63, 363);
            this.blueText.Name = "blueText";
            this.blueText.Size = new System.Drawing.Size(83, 17);
            this.blueText.TabIndex = 1;
            this.blueText.Text = "Blue Output";
            // 
            // redText
            // 
            this.redText.AutoSize = true;
            this.redText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redText.Location = new System.Drawing.Point(63, 327);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(81, 17);
            this.redText.TabIndex = 3;
            this.redText.Text = "Red Output";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.BackColor = System.Drawing.Color.Red;
            this.labelM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelM.Location = new System.Drawing.Point(35, 330);
            this.labelM.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(16, 13);
            this.labelM.TabIndex = 4;
            this.labelM.Text = "M";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Blue;
            this.labelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelB.Location = new System.Drawing.Point(35, 366);
            this.labelB.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.Yellow;
            this.labelN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelN.Location = new System.Drawing.Point(35, 293);
            this.labelN.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(15, 13);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "N";
            // 
            // yellowText
            // 
            this.yellowText.AutoSize = true;
            this.yellowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowText.Location = new System.Drawing.Point(63, 290);
            this.yellowText.Name = "yellowText";
            this.yellowText.Size = new System.Drawing.Size(95, 17);
            this.yellowText.TabIndex = 6;
            this.yellowText.Text = "Yellow Output";
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(565, 294);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(66, 13);
            this.labelDebug.TabIndex = 8;
            this.labelDebug.Text = "DEBUG BOI";
            // 
            // labelImage
            // 
            this.labelImage.BackColor = System.Drawing.Color.Transparent;
            this.labelImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelImage.ForeColor = System.Drawing.Color.Coral;
            this.labelImage.Image = global::MultiChoiceAdventure.Properties.Resources.cave;
            this.labelImage.Location = new System.Drawing.Point(-1, -2);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(697, 404);
            this.labelImage.TabIndex = 9;
            this.labelImage.Text = "                ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 399);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.yellowText);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.redText);
            this.Controls.Add(this.blueText);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.labelImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label blueText;
        private System.Windows.Forms.Label redText;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label yellowText;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Label labelImage;
    }
}

