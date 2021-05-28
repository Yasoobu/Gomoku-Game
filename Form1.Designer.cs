namespace Gomoku
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
            this.Start = new System.Windows.Forms.Button();
            this.BoardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TurnMsgLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1box = new System.Windows.Forms.Button();
            this.Player2box = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(384, 23);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(135, 41);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // BoardPanel
            // 
            this.BoardPanel.Location = new System.Drawing.Point(4, 79);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(902, 500);
            this.BoardPanel.TabIndex = 1;
            // 
            // TurnMsgLabel
            // 
            this.TurnMsgLabel.AutoSize = true;
            this.TurnMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnMsgLabel.Location = new System.Drawing.Point(115, 28);
            this.TurnMsgLabel.Name = "TurnMsgLabel";
            this.TurnMsgLabel.Size = new System.Drawing.Size(0, 25);
            this.TurnMsgLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1                 Player 2";
            // 
            // Player1box
            // 
            this.Player1box.Location = new System.Drawing.Point(635, 47);
            this.Player1box.Name = "Player1box";
            this.Player1box.Size = new System.Drawing.Size(42, 26);
            this.Player1box.TabIndex = 4;
            this.Player1box.UseVisualStyleBackColor = true;
            // 
            // Player2box
            // 
            this.Player2box.Location = new System.Drawing.Point(760, 47);
            this.Player2box.Name = "Player2box";
            this.Player2box.Size = new System.Drawing.Size(42, 26);
            this.Player2box.TabIndex = 5;
            this.Player2box.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(907, 584);
            this.Controls.Add(this.Player2box);
            this.Controls.Add(this.Player1box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TurnMsgLabel);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Gomoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel BoardPanel;
        private System.Windows.Forms.Label TurnMsgLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Player1box;
        private System.Windows.Forms.Button Player2box;
    }
}

