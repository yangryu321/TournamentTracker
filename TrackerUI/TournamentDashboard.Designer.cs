
namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.LoadingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadingExistingTournamentDropList = new System.Windows.Forms.ComboBox();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DashboardLabel.Location = new System.Drawing.Point(221, 87);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(353, 45);
            this.DashboardLabel.TabIndex = 2;
            this.DashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadingTournamentLabel
            // 
            this.LoadingTournamentLabel.AutoSize = true;
            this.LoadingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LoadingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadingTournamentLabel.Location = new System.Drawing.Point(211, 194);
            this.LoadingTournamentLabel.Name = "LoadingTournamentLabel";
            this.LoadingTournamentLabel.Size = new System.Drawing.Size(373, 38);
            this.LoadingTournamentLabel.TabIndex = 3;
            this.LoadingTournamentLabel.Text = "Loading Existing Tournament";
            // 
            // LoadingExistingTournamentDropList
            // 
            this.LoadingExistingTournamentDropList.FormattingEnabled = true;
            this.LoadingExistingTournamentDropList.Location = new System.Drawing.Point(219, 233);
            this.LoadingExistingTournamentDropList.Name = "LoadingExistingTournamentDropList";
            this.LoadingExistingTournamentDropList.Size = new System.Drawing.Size(356, 53);
            this.LoadingExistingTournamentDropList.TabIndex = 4;
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.BackColor = System.Drawing.Color.White;
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadTournamentButton.Location = new System.Drawing.Point(281, 323);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(232, 62);
            this.LoadTournamentButton.TabIndex = 27;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = false;
            this.LoadTournamentButton.Click += new System.EventHandler(this.LoadTournamentButton_Click);
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(243, 423);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(308, 70);
            this.CreateTournamentButton.TabIndex = 28;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 585);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadingExistingTournamentDropList);
            this.Controls.Add(this.LoadingTournamentLabel);
            this.Controls.Add(this.DashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.Load += new System.EventHandler(this.TournamentDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Label LoadingTournamentLabel;
        private System.Windows.Forms.ComboBox LoadingExistingTournamentDropList;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}