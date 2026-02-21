namespace GuessingGameFull
{
    partial class GuessingGame
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
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGuess.Location = new System.Drawing.Point(5, 155);
            this.btnSubmitGuess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(129, 42);
            this.btnSubmitGuess.TabIndex = 0;
            this.btnSubmitGuess.Text = "Enter Guess";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.ForestGreen;
            this.lblInstructions.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInstructions.Location = new System.Drawing.Point(-2, 50);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(268, 41);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Guess The Word!";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(5, 242);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 28);
            this.lblFeedback.TabIndex = 2;
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFeedback.UseCompatibleTextRendering = true;
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(5, 109);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtGuess.MaximumSize = new System.Drawing.Size(56, 50);
            this.txtGuess.MinimumSize = new System.Drawing.Size(202, 25);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(202, 35);
            this.txtGuess.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(140, 155);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(359, 119);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(146, 25);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Time Left: 2:00";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(359, 66);
            this.lblHint.MinimumSize = new System.Drawing.Size(140, 25);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(140, 25);
            this.lblHint.TabIndex = 6;
            this.lblHint.Text = "label1";
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(601, 369);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnSubmitGuess);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GuessingGame";
            this.Text = "Guessing game";
            this.Load += new System.EventHandler(this.GuessingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblFeedback;
        public System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblHint;
    }
}

