﻿namespace StupidBlackjackSln {
  partial class frmTitle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame1 = new System.Windows.Forms.Button();
            this.btnRulebook = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblGamblingHotline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(219, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(519, 73);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stupid Blackjack";
            // 
            // btnNewGame1
            // 
            this.btnNewGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame1.Location = new System.Drawing.Point(12, 340);
            this.btnNewGame1.Name = "btnNewGame1";
            this.btnNewGame1.Size = new System.Drawing.Size(197, 60);
            this.btnNewGame1.TabIndex = 1;
            this.btnNewGame1.Text = "New Game";
            this.btnNewGame1.UseVisualStyleBackColor = true;
            this.btnNewGame1.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnRulebook
            // 
            this.btnRulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRulebook.Location = new System.Drawing.Point(246, 340);
            this.btnRulebook.Name = "btnRulebook";
            this.btnRulebook.Size = new System.Drawing.Size(227, 60);
            this.btnRulebook.TabIndex = 2;
            this.btnRulebook.Text = "View Rulebook";
            this.btnRulebook.UseVisualStyleBackColor = true;
            this.btnRulebook.Click += new System.EventHandler(this.btnRulebook_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(744, 340);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(197, 60);
            this.btnExitGame.TabIndex = 3;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(510, 340);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(197, 60);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // lblGamblingHotline
            // 
            this.lblGamblingHotline.BackColor = System.Drawing.Color.Transparent;
            this.lblGamblingHotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamblingHotline.Location = new System.Drawing.Point(12, 430);
            this.lblGamblingHotline.Name = "lblGamblingHotline";
            this.lblGamblingHotline.Size = new System.Drawing.Size(942, 23);
            this.lblGamblingHotline.TabIndex = 5;
            this.lblGamblingHotline.Text = "Gambling Addiction: Call the Hotline at 1-800-522-4700 or visit gamtalk.org for o" +
    "nline support";
            this.lblGamblingHotline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.table_texture;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.lblGamblingHotline);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnRulebook);
            this.Controls.Add(this.btnNewGame1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTitle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnNewGame1;
    private System.Windows.Forms.Button btnRulebook;
    private System.Windows.Forms.Button btnExitGame;
    private System.Windows.Forms.Button btnOptions;
    private System.Windows.Forms.Label lblGamblingHotline;
    }
}

