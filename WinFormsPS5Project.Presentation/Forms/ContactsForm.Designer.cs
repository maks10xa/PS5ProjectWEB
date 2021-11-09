
namespace WinFormsPS5Project.Presentation
{
    partial class ContactsForm
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
            this._contactsBtn = new System.Windows.Forms.Button();
            this._infoBtn = new System.Windows.Forms.Button();
            this._costsBtn = new System.Windows.Forms.Button();
            this._gamesBtn = new System.Windows.Forms.Button();
            this._profileBtn = new System.Windows.Forms.Button();
            this._maxNameLabel = new System.Windows.Forms.Label();
            this._artemNameLabel = new System.Windows.Forms.Label();
            this._artemPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this._maxPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this._emailLabel = new System.Windows.Forms.Label();
            this._emailCountLabel = new System.Windows.Forms.Label();
            this._closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _contactsBtn
            // 
            this._contactsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._contactsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._contactsBtn.Location = new System.Drawing.Point(554, 33);
            this._contactsBtn.Name = "_contactsBtn";
            this._contactsBtn.Size = new System.Drawing.Size(94, 29);
            this._contactsBtn.TabIndex = 19;
            this._contactsBtn.Text = "Контакты";
            this._contactsBtn.UseVisualStyleBackColor = true;
            // 
            // _infoBtn
            // 
            this._infoBtn.Location = new System.Drawing.Point(454, 33);
            this._infoBtn.Name = "_infoBtn";
            this._infoBtn.Size = new System.Drawing.Size(94, 29);
            this._infoBtn.TabIndex = 18;
            this._infoBtn.Text = "О нас";
            this._infoBtn.UseVisualStyleBackColor = true;
            this._infoBtn.Click += new System.EventHandler(this._infoBtn_Click);
            // 
            // _costsBtn
            // 
            this._costsBtn.Location = new System.Drawing.Point(354, 33);
            this._costsBtn.Name = "_costsBtn";
            this._costsBtn.Size = new System.Drawing.Size(94, 29);
            this._costsBtn.TabIndex = 17;
            this._costsBtn.Text = "Цены";
            this._costsBtn.UseVisualStyleBackColor = true;
            this._costsBtn.Click += new System.EventHandler(this._costsBtn_Click);
            // 
            // _gamesBtn
            // 
            this._gamesBtn.Location = new System.Drawing.Point(254, 33);
            this._gamesBtn.Name = "_gamesBtn";
            this._gamesBtn.Size = new System.Drawing.Size(94, 29);
            this._gamesBtn.TabIndex = 16;
            this._gamesBtn.Text = "Игры";
            this._gamesBtn.UseVisualStyleBackColor = true;
            this._gamesBtn.Click += new System.EventHandler(this._gamesBtn_Click);
            // 
            // _profileBtn
            // 
            this._profileBtn.Location = new System.Drawing.Point(161, 33);
            this._profileBtn.Name = "_profileBtn";
            this._profileBtn.Size = new System.Drawing.Size(87, 29);
            this._profileBtn.TabIndex = 15;
            this._profileBtn.Text = "Профиль";
            this._profileBtn.UseVisualStyleBackColor = true;
            this._profileBtn.Click += new System.EventHandler(this._profileBtn_Click);
            // 
            // _maxNameLabel
            // 
            this._maxNameLabel.AutoSize = true;
            this._maxNameLabel.Location = new System.Drawing.Point(139, 167);
            this._maxNameLabel.Name = "_maxNameLabel";
            this._maxNameLabel.Size = new System.Drawing.Size(64, 20);
            this._maxNameLabel.TabIndex = 20;
            this._maxNameLabel.Text = "Максим";
            // 
            // _artemNameLabel
            // 
            this._artemNameLabel.AutoSize = true;
            this._artemNameLabel.Location = new System.Drawing.Point(139, 117);
            this._artemNameLabel.Name = "_artemNameLabel";
            this._artemNameLabel.Size = new System.Drawing.Size(53, 20);
            this._artemNameLabel.TabIndex = 21;
            this._artemNameLabel.Text = "Артём";
            // 
            // _artemPhoneNumberTextBox
            // 
            this._artemPhoneNumberTextBox.Location = new System.Drawing.Point(323, 114);
            this._artemPhoneNumberTextBox.Name = "_artemPhoneNumberTextBox";
            this._artemPhoneNumberTextBox.ReadOnly = true;
            this._artemPhoneNumberTextBox.Size = new System.Drawing.Size(225, 27);
            this._artemPhoneNumberTextBox.TabIndex = 22;
            // 
            // _maxPhoneNumberTextBox
            // 
            this._maxPhoneNumberTextBox.Location = new System.Drawing.Point(323, 167);
            this._maxPhoneNumberTextBox.Name = "_maxPhoneNumberTextBox";
            this._maxPhoneNumberTextBox.ReadOnly = true;
            this._maxPhoneNumberTextBox.Size = new System.Drawing.Size(225, 27);
            this._maxPhoneNumberTextBox.TabIndex = 23;
            // 
            // _emailLabel
            // 
            this._emailLabel.AutoSize = true;
            this._emailLabel.Location = new System.Drawing.Point(139, 252);
            this._emailLabel.Name = "_emailLabel";
            this._emailLabel.Size = new System.Drawing.Size(49, 20);
            this._emailLabel.TabIndex = 24;
            this._emailLabel.Text = "email:";
            // 
            // _emailCountLabel
            // 
            this._emailCountLabel.AutoSize = true;
            this._emailCountLabel.Location = new System.Drawing.Point(323, 252);
            this._emailCountLabel.Name = "_emailCountLabel";
            this._emailCountLabel.Size = new System.Drawing.Size(135, 20);
            this._emailCountLabel.TabIndex = 25;
            this._emailCountLabel.Text = "admin@ps5-gm.by";
            // 
            // _closeBtn
            // 
            this._closeBtn.BackColor = System.Drawing.Color.Silver;
            this._closeBtn.Location = new System.Drawing.Point(711, 12);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(77, 34);
            this._closeBtn.TabIndex = 26;
            this._closeBtn.Text = "Закрыть";
            this._closeBtn.UseVisualStyleBackColor = false;
            this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._emailCountLabel);
            this.Controls.Add(this._emailLabel);
            this.Controls.Add(this._maxPhoneNumberTextBox);
            this.Controls.Add(this._artemPhoneNumberTextBox);
            this.Controls.Add(this._artemNameLabel);
            this.Controls.Add(this._maxNameLabel);
            this.Controls.Add(this._contactsBtn);
            this.Controls.Add(this._infoBtn);
            this.Controls.Add(this._costsBtn);
            this.Controls.Add(this._gamesBtn);
            this.Controls.Add(this._profileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactsForm";
            this.Text = "ContactsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _contactsBtn;
        private System.Windows.Forms.Button _infoBtn;
        private System.Windows.Forms.Button _costsBtn;
        private System.Windows.Forms.Button _gamesBtn;
        private System.Windows.Forms.Button _profileBtn;
        private System.Windows.Forms.Label _maxNameLabel;
        private System.Windows.Forms.Label _artemNameLabel;
        private System.Windows.Forms.TextBox _artemPhoneNumberTextBox;
        private System.Windows.Forms.TextBox _maxPhoneNumberTextBox;
        private System.Windows.Forms.Label _emailLabel;
        private System.Windows.Forms.Label _emailCountLabel;
        private System.Windows.Forms.Button _closeBtn;
    }
}