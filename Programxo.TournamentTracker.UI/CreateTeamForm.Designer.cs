namespace Programxo.TournamentTracker.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(27, 142);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(371, 38);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(20, 98);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(182, 41);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(263, 58);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.Location = new System.Drawing.Point(112, 326);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(219, 52);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(27, 258);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(371, 39);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(20, 214);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(311, 41);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(22, 402);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(385, 394);
            this.addNewMemberGroupBox.TabIndex = 20;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(173, 59);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(203, 45);
            this.FirstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 57);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(161, 40);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(174, 121);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(203, 45);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(7, 119);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(157, 40);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(173, 186);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(203, 45);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(6, 184);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(103, 40);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "E-Mail";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(173, 250);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(203, 45);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLabel.Location = new System.Drawing.Point(6, 248);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(151, 40);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.Location = new System.Drawing.Point(90, 322);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(219, 52);
            this.createMemberButton.TabIndex = 21;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 31;
            this.teamMembersListBox.Location = new System.Drawing.Point(436, 142);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(444, 655);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(910, 411);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(152, 95);
            this.deleteSelectedMemberButton.TabIndex = 22;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.Location = new System.Drawing.Point(436, 822);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(327, 65);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 909);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}