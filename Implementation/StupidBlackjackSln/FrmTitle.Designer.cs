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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnRulebook = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNameMarker = new System.Windows.Forms.Label();
            this.lblHotlineInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitle.Location = new System.Drawing.Point(228, 272);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(794, 95);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stupid Blackjack";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(16, 645);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(233, 71);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnRulebook
            // 
            this.btnRulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRulebook.Location = new System.Drawing.Point(276, 645);
            this.btnRulebook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRulebook.Name = "btnRulebook";
            this.btnRulebook.Size = new System.Drawing.Size(309, 71);
            this.btnRulebook.TabIndex = 2;
            this.btnRulebook.Text = "View Rulebook";
            this.btnRulebook.UseVisualStyleBackColor = true;
            this.btnRulebook.Click += new System.EventHandler(this.btnRulebook_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(1099, 645);
            this.btnExitGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(220, 71);
            this.btnExitGame.TabIndex = 3;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(900, 645);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(172, 71);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.Location = new System.Drawing.Point(612, 645);
            this.btnLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(261, 71);
            this.btnLeaderboard.TabIndex = 5;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsTab = true;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserName.Location = new System.Drawing.Point(207, 11);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.MaxLength = 16;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(138, 26);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblNameMarker
            // 
            this.lblNameMarker.AutoSize = true;
            this.lblNameMarker.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMarker.ForeColor = System.Drawing.Color.White;
            this.lblNameMarker.Location = new System.Drawing.Point(19, 12);
            this.lblNameMarker.Name = "lblNameMarker";
            this.lblNameMarker.Size = new System.Drawing.Size(169, 22);
            this.lblNameMarker.TabIndex = 7;
            this.lblNameMarker.Text = "Enter User Name:";
            // 
            // lblHotlineInfo
            // 
            this.lblHotlineInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblHotlineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotlineInfo.ForeColor = System.Drawing.Color.White;
            this.lblHotlineInfo.Location = new System.Drawing.Point(16, 737);
            this.lblHotlineInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotlineInfo.Name = "lblHotlineInfo";
            this.lblHotlineInfo.Size = new System.Drawing.Size(1303, 38);
            this.lblHotlineInfo.TabIndex = 8;
            this.lblHotlineInfo.Text = "Gambling Addiction: Call the Hotline at 1-800-522-4700 or visit gamtalk.org for o" +
    "nline support";
            this.lblHotlineInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.blackjackTitle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 786);
            this.Controls.Add(this.lblHotlineInfo);
            this.Controls.Add(this.lblNameMarker);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnRulebook);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTitle";
            this.Text = "Stupid BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnNewGame;
    private System.Windows.Forms.Button btnRulebook;
    private System.Windows.Forms.Button btnExitGame;
    private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNameMarker;
        private System.Windows.Forms.Label lblHotlineInfo;
    }
}

