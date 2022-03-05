
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.Tournament = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScore = new System.Windows.Forms.Label();
            this.TeamOneScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScore = new System.Windows.Forms.Label();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.VSlabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournament
            // 
            this.Tournament.AutoSize = true;
            this.Tournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Tournament.Location = new System.Drawing.Point(12, 9);
            this.Tournament.Name = "Tournament";
            this.Tournament.Size = new System.Drawing.Size(197, 45);
            this.Tournament.TabIndex = 0;
            this.Tournament.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentName.Location = new System.Drawing.Point(143, 9);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(136, 45);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(12, 70);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(97, 38);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(115, 62);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(217, 53);
            this.RoundDropdown.TabIndex = 3;
            this.RoundDropdown.SelectedIndexChanged += new System.EventHandler(this.RoundDropdown_SelectedIndexChanged);
            // 
            // UnplayedOnly
            // 
            this.UnplayedOnly.AutoSize = true;
            this.UnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.UnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnly.Location = new System.Drawing.Point(115, 131);
            this.UnplayedOnly.Name = "UnplayedOnly";
            this.UnplayedOnly.Size = new System.Drawing.Size(236, 45);
            this.UnplayedOnly.TabIndex = 4;
            this.UnplayedOnly.Text = "Unplayed Only";
            this.UnplayedOnly.UseVisualStyleBackColor = true;
            this.UnplayedOnly.CheckedChanged += new System.EventHandler(this.UnplayedOnly_CheckedChanged);
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.ItemHeight = 45;
            this.MatchupListbox.Location = new System.Drawing.Point(38, 234);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(294, 317);
            this.MatchupListbox.TabIndex = 5;
            this.MatchupListbox.SelectedIndexChanged += new System.EventHandler(this.MatchupListbox_SelectedIndexChanged);
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(425, 272);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(132, 38);
            this.TeamOneScoreLabel.TabIndex = 6;
            this.TeamOneScoreLabel.Text = "<team1>";
            // 
            // TeamOneScore
            // 
            this.TeamOneScore.AutoSize = true;
            this.TeamOneScore.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScore.Location = new System.Drawing.Point(425, 321);
            this.TeamOneScore.Name = "TeamOneScore";
            this.TeamOneScore.Size = new System.Drawing.Size(86, 38);
            this.TeamOneScore.TabIndex = 7;
            this.TeamOneScore.Text = "Score";
            // 
            // TeamOneScoreText
            // 
            this.TeamOneScoreText.Location = new System.Drawing.Point(503, 313);
            this.TeamOneScoreText.Name = "TeamOneScoreText";
            this.TeamOneScoreText.Size = new System.Drawing.Size(100, 50);
            this.TeamOneScoreText.TabIndex = 8;
            // 
            // TeamTwoScoreText
            // 
            this.TeamTwoScoreText.Location = new System.Drawing.Point(503, 457);
            this.TeamTwoScoreText.Name = "TeamTwoScoreText";
            this.TeamTwoScoreText.Size = new System.Drawing.Size(100, 50);
            this.TeamTwoScoreText.TabIndex = 11;
            // 
            // TeamTwoScore
            // 
            this.TeamTwoScore.AutoSize = true;
            this.TeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoScore.Location = new System.Drawing.Point(425, 465);
            this.TeamTwoScore.Name = "TeamTwoScore";
            this.TeamTwoScore.Size = new System.Drawing.Size(86, 38);
            this.TeamTwoScore.TabIndex = 10;
            this.TeamTwoScore.Text = "Score";
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(425, 416);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(132, 38);
            this.TeamTwoScoreLabel.TabIndex = 9;
            this.TeamTwoScoreLabel.Text = "<team2>";
            // 
            // VSlabel
            // 
            this.VSlabel.AutoSize = true;
            this.VSlabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.VSlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.VSlabel.Location = new System.Drawing.Point(468, 378);
            this.VSlabel.Name = "VSlabel";
            this.VSlabel.Size = new System.Drawing.Size(71, 38);
            this.VSlabel.TabIndex = 12;
            this.VSlabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.BackColor = System.Drawing.Color.White;
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(654, 375);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(107, 51);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Confirm";
            this.ScoreButton.UseVisualStyleBackColor = false;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(826, 628);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VSlabel);
            this.Controls.Add(this.TeamTwoScoreText);
            this.Controls.Add(this.TeamTwoScore);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamOneScoreText);
            this.Controls.Add(this.TeamOneScore);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.MatchupListbox);
            this.Controls.Add(this.UnplayedOnly);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Tournament);
            this.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "TounamentViewer";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tournament;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox UnplayedOnly;
        private System.Windows.Forms.ListBox MatchupListbox;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.Label TeamOneScore;
        private System.Windows.Forms.TextBox TeamOneScoreText;
        private System.Windows.Forms.TextBox TeamTwoScoreText;
        private System.Windows.Forms.Label TeamTwoScore;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label VSlabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

