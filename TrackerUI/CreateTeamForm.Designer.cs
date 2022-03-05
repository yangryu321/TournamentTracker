
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameTextbox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMember = new System.Windows.Forms.Label();
            this.TeamMemberDroplist = new System.Windows.Forms.ComboBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellphoneTextBox = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.TeamMembersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedTeamsMembersButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameTextbox
            // 
            this.TeamNameTextbox.Location = new System.Drawing.Point(20, 109);
            this.TeamNameTextbox.Name = "TeamNameTextbox";
            this.TeamNameTextbox.Size = new System.Drawing.Size(240, 50);
            this.TeamNameTextbox.TabIndex = 5;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(13, 68);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(164, 38);
            this.TeamNameLabel.TabIndex = 4;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // SelectTeamMember
            // 
            this.SelectTeamMember.AutoSize = true;
            this.SelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.SelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamMember.Location = new System.Drawing.Point(13, 169);
            this.SelectTeamMember.Name = "SelectTeamMember";
            this.SelectTeamMember.Size = new System.Drawing.Size(277, 38);
            this.SelectTeamMember.TabIndex = 6;
            this.SelectTeamMember.Text = "Select Team Member";
            // 
            // TeamMemberDroplist
            // 
            this.TeamMemberDroplist.FormattingEnabled = true;
            this.TeamMemberDroplist.Location = new System.Drawing.Point(20, 210);
            this.TeamMemberDroplist.Name = "TeamMemberDroplist";
            this.TeamMemberDroplist.Size = new System.Drawing.Size(240, 53);
            this.TeamMemberDroplist.TabIndex = 7;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.BackColor = System.Drawing.Color.White;
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddMemberButton.Location = new System.Drawing.Point(51, 269);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(168, 45);
            this.AddMemberButton.TabIndex = 21;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = false;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.CellphoneTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.CellPhoneLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(20, 320);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(314, 327);
            this.AddNewMemberGroupBox.TabIndex = 22;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.BackColor = System.Drawing.Color.White;
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(31, 262);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(177, 45);
            this.CreateMemberButton.TabIndex = 23;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = false;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // CellphoneTextBox
            // 
            this.CellphoneTextBox.Location = new System.Drawing.Point(105, 217);
            this.CellphoneTextBox.Name = "CellphoneTextBox";
            this.CellphoneTextBox.Size = new System.Drawing.Size(190, 39);
            this.CellphoneTextBox.TabIndex = 28;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CellPhoneLabel.Location = new System.Drawing.Point(6, 217);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(99, 28);
            this.CellPhoneLabel.TabIndex = 29;
            this.CellPhoneLabel.Text = "CellPhone";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(105, 162);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(190, 39);
            this.EmailTextBox.TabIndex = 26;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(6, 162);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 28);
            this.EmailLabel.TabIndex = 27;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(105, 107);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(190, 39);
            this.LastNameTextBox.TabIndex = 24;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(6, 107);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(103, 28);
            this.LastNameLabel.TabIndex = 25;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(105, 49);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(190, 39);
            this.FirstNameTextBox.TabIndex = 23;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 49);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 28);
            this.FirstNameLabel.TabIndex = 23;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMemberListBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TeamMemberListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 28;
            this.TeamMemberListBox.Location = new System.Drawing.Point(367, 109);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(327, 534);
            this.TeamMemberListBox.TabIndex = 23;
            // 
            // TeamMembersLabel
            // 
            this.TeamMembersLabel.AutoSize = true;
            this.TeamMembersLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TeamMembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamMembersLabel.Location = new System.Drawing.Point(360, 68);
            this.TeamMembersLabel.Name = "TeamMembersLabel";
            this.TeamMembersLabel.Size = new System.Drawing.Size(207, 38);
            this.TeamMembersLabel.TabIndex = 24;
            this.TeamMembersLabel.Text = "Team Members";
            // 
            // DeleteSelectedTeamsMembersButton
            // 
            this.DeleteSelectedTeamsMembersButton.BackColor = System.Drawing.Color.White;
            this.DeleteSelectedTeamsMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedTeamsMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedTeamsMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedTeamsMembersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteSelectedTeamsMembersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedTeamsMembersButton.Location = new System.Drawing.Point(573, 31);
            this.DeleteSelectedTeamsMembersButton.Name = "DeleteSelectedTeamsMembersButton";
            this.DeleteSelectedTeamsMembersButton.Size = new System.Drawing.Size(100, 72);
            this.DeleteSelectedTeamsMembersButton.TabIndex = 25;
            this.DeleteSelectedTeamsMembersButton.Text = "Delete Selected";
            this.DeleteSelectedTeamsMembersButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedTeamsMembersButton.Click += new System.EventHandler(this.DeleteSelectedTeamsMembersButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.BackColor = System.Drawing.Color.White;
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(732, 336);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(219, 72);
            this.CreateTeamButton.TabIndex = 26;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = false;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(196, 45);
            this.CreateTeamLabel.TabIndex = 1;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // CreateTeamFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(979, 652);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedTeamsMembersButton);
            this.Controls.Add(this.TeamMembersLabel);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.TeamMemberDroplist);
            this.Controls.Add(this.SelectTeamMember);
            this.Controls.Add(this.TeamNameTextbox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamFrom";
            this.Text = "CreateTeamFrom";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TeamNameTextbox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label SelectTeamMember;
        private System.Windows.Forms.ComboBox TeamMemberDroplist;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.GroupBox AddNewMemberGroupBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox CellphoneTextBox;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Label TeamMembersLabel;
        private System.Windows.Forms.Button DeleteSelectedTeamsMembersButton;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Label CreateTeamLabel;
    }
}