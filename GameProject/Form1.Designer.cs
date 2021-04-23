
namespace GameProject
{
    partial class arcadeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arcadeGame));
            this.startButton = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startButton.FlatAppearance.BorderSize = 5;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(243, 144);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(236, 118);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START GAME";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.Color.Black;
            this.countdown.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.White;
            this.countdown.Location = new System.Drawing.Point(316, 318);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(100, 34);
            this.countdown.TabIndex = 1;
            this.countdown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.Black;
            this.outputText.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.Color.White;
            this.outputText.Location = new System.Drawing.Point(243, 265);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(236, 23);
            this.outputText.TabIndex = 2;
            this.outputText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // arcadeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(740, 428);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "arcadeGame";
            this.Text = "Aracade";
            this.Load += new System.EventHandler(this.arcadeGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label outputText;
    }
}

