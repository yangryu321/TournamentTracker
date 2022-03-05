
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextbox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.EntryfeeTextbox = new System.Windows.Forms.TextBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SelectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.AddteamButton = new System.Windows.Forms.Button();
            this.CreatPrizeButton = new System.Windows.Forms.Button();
            this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TeamPlayerLabel = new System.Windows.Forms.Label();
            this.PrizeListbox = new System.Windows.Forms.ListBox();
            this.PrizeLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedTeamsButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentLabel.Location = new System.Drawing.Point(21, 9);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(291, 45);
            this.CreateTournamentLabel.TabIndex = 1;
            this.CreateTournamentLabel.Text = "Create Tournament";
            // 
            // TournamentNameTextbox
            // 
            this.TournamentNameTextbox.Location = new System.Drawing.Point(29, 118);
            this.TournamentNameTextbox.Name = "TournamentNameTextbox";
            this.TournamentNameTextbox.Size = new System.Drawing.Size(240, 50);
            this.TournamentNameTextbox.TabIndex = 3;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(22, 199);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(132, 38);
            this.EntryFeeLabel.TabIndex = 4;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // EntryfeeTextbox
            // 
            this.EntryfeeTextbox.Location = new System.Drawing.Point(144, 191);
            this.EntryfeeTextbox.Name = "EntryfeeTextbox";
            this.EntryfeeTextbox.Size = new System.Drawing.Size(114, 50);
            this.EntryfeeTextbox.TabIndex = 5;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(22, 299);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.SelectTeamLabel.TabIndex = 6;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewLinkLabel
            // 
            this.CreateNewLinkLabel.AutoSize = true;
            this.CreateNewLinkLabel.Location = new System.Drawing.Point(176, 294);
            this.CreateNewLinkLabel.Name = "CreateNewLinkLabel";
            this.CreateNewLinkLabel.Size = new System.Drawing.Size(179, 45);
            this.CreateNewLinkLabel.TabIndex = 8;
            this.CreateNewLinkLabel.TabStop = true;
            this.CreateNewLinkLabel.Text = "Create new";
            this.CreateNewLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewLinkLabel_LinkClicked);
            // 
            // SelectTeamComboBox
            // 
            this.SelectTeamComboBox.FormattingEnabled = true;
            this.SelectTeamComboBox.Location = new System.Drawing.Point(29, 355);
            this.SelectTeamComboBox.Name = "SelectTeamComboBox";
            this.SelectTeamComboBox.Size = new System.Drawing.Size(269, 53);
            this.SelectTeamComboBox.TabIndex = 9;
            // 
            // AddteamButton
            // 
            this.AddteamButton.BackColor = System.Drawing.Color.White;
            this.AddteamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddteamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddteamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddteamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddteamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddteamButton.Location = new System.Drawing.Point(90, 426);
            this.AddteamButton.Name = "AddteamButton";
            this.AddteamButton.Size = new System.Drawing.Size(146, 60);
            this.AddteamButton.TabIndex = 14;
            this.AddteamButton.Text = "Add Team";
            this.AddteamButton.UseVisualStyleBackColor = false;
            this.AddteamButton.Click += new System.EventHandler(this.AddteamButton_Click);
            // 
            // CreatPrizeButton
            // 
            this.CreatPrizeButton.BackColor = System.Drawing.Color.White;
            this.CreatPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatPrizeButton.Location = new System.Drawing.Point(90, 492);
            this.CreatPrizeButton.Name = "CreatPrizeButton";
            this.CreatPrizeButton.Size = new System.Drawing.Size(146, 60);
            this.CreatPrizeButton.TabIndex = 15;
            this.CreatPrizeButton.Text = "Create Prize";
            this.CreatPrizeButton.UseVisualStyleBackColor = false;
            this.CreatPrizeButton.Click += new System.EventHandler(this.CreatPrizeButton_Click);
            // 
            // TournamentTeamsListBox
            // 
            this.TournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TournamentTeamsListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TournamentTeamsListBox.FormattingEnabled = true;
            this.TournamentTeamsListBox.ItemHeight = 28;
            this.TournamentTeamsListBox.Location = new System.Drawing.Point(457, 118);
            this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            this.TournamentTeamsListBox.Size = new System.Drawing.Size(273, 170);
            this.TournamentTeamsListBox.TabIndex = 16;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(22, 77);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(247, 38);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // TeamPlayerLabel
            // 
            this.TeamPlayerLabel.AutoSize = true;
            this.TeamPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamPlayerLabel.Location = new System.Drawing.Point(450, 77);
            this.TeamPlayerLabel.Name = "TeamPlayerLabel";
            this.TeamPlayerLabel.Size = new System.Drawing.Size(193, 38);
            this.TeamPlayerLabel.TabIndex = 17;
            this.TeamPlayerLabel.Text = "Teams/Players";
            // 
            // PrizeListbox
            // 
            this.PrizeListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeListbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PrizeListbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PrizeListbox.FormattingEnabled = true;
            this.PrizeListbox.ItemHeight = 28;
            this.PrizeListbox.Location = new System.Drawing.Point(457, 355);
            this.PrizeListbox.Name = "PrizeListbox";
            this.PrizeListbox.Size = new System.Drawing.Size(273, 170);
            this.PrizeListbox.TabIndex = 18;
            // 
            // PrizeLabel
            // 
            this.PrizeLabel.AutoSize = true;
            this.PrizeLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizeLabel.Location = new System.Drawing.Point(450, 314);
            this.PrizeLabel.Name = "PrizeLabel";
            this.PrizeLabel.Size = new System.Drawing.Size(90, 38);
            this.PrizeLabel.TabIndex = 19;
            this.PrizeLabel.Text = "Prizes";
            // 
            // DeleteSelectedTeamsButton
            // 
            this.DeleteSelectedTeamsButton.BackColor = System.Drawing.Color.White;
            this.DeleteSelectedTeamsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedTeamsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedTeamsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedTeamsButton.Location = new System.Drawing.Point(736, 162);
            this.DeleteSelectedTeamsButton.Name = "DeleteSelectedTeamsButton";
            this.DeleteSelectedTeamsButton.Size = new System.Drawing.Size(134, 75);
            this.DeleteSelectedTeamsButton.TabIndex = 20;
            this.DeleteSelectedTeamsButton.Text = "Delete Selected";
            this.DeleteSelectedTeamsButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedTeamsButton.Click += new System.EventHandler(this.DeleteSelectedTeamsButton_Click);
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.BackColor = System.Drawing.Color.White;
            this.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(736, 411);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(134, 75);
            this.DeleteSelectedPrizeButton.TabIndex = 21;
            this.DeleteSelectedPrizeButton.Text = "Delete Selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedPrizeButton.Click += new System.EventHandler(this.DeleteSelectedPrizeButton_Click);
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(273, 561);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(290, 75);
            this.CreateTournamentButton.TabIndex = 22;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 648);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.DeleteSelectedTeamsButton);
            this.Controls.Add(this.PrizeLabel);
            this.Controls.Add(this.PrizeListbox);
            this.Controls.Add(this.TeamPlayerLabel);
            this.Controls.Add(this.TournamentTeamsListBox);
            this.Controls.Add(this.CreatPrizeButton);
            this.Controls.Add(this.AddteamButton);
            this.Controls.Add(this.SelectTeamComboBox);
            this.Controls.Add(this.CreateNewLinkLabel);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryfeeTextbox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameTextbox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournamentLabel;
        private System.Windows.Forms.TextBox TournamentNameTextbox;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.TextBox EntryfeeTextbox;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewLinkLabel;
        private System.Windows.Forms.ComboBox SelectTeamComboBox;
        private System.Windows.Forms.Button AddteamButton;
        private System.Windows.Forms.Button CreatPrizeButton;
        private System.Windows.Forms.ListBox TournamentTeamsListBox;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.Label TeamPlayerLabel;
        private System.Windows.Forms.ListBox PrizeListbox;
        private System.Windows.Forms.Label PrizeLabel;
        private System.Windows.Forms.Button DeleteSelectedTeamsButton;
        private System.Windows.Forms.Button DeleteSelectedPrizeButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}