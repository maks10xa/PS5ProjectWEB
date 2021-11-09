
namespace WinFormsPS5Project.Presentation
{
    partial class CostsForm
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
            this._costsListCheckBox = new System.Windows.Forms.ComboBox();
            this._costTextBox = new System.Windows.Forms.TextBox();
            this._closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _contactsBtn
            // 
            this._contactsBtn.Location = new System.Drawing.Point(561, 29);
            this._contactsBtn.Name = "_contactsBtn";
            this._contactsBtn.Size = new System.Drawing.Size(94, 29);
            this._contactsBtn.TabIndex = 14;
            this._contactsBtn.Text = "Контакты";
            this._contactsBtn.UseVisualStyleBackColor = true;
            this._contactsBtn.Click += new System.EventHandler(this._contactsBtn_Click);
            // 
            // _infoBtn
            // 
            this._infoBtn.Location = new System.Drawing.Point(461, 29);
            this._infoBtn.Name = "_infoBtn";
            this._infoBtn.Size = new System.Drawing.Size(94, 29);
            this._infoBtn.TabIndex = 13;
            this._infoBtn.Text = "О нас";
            this._infoBtn.UseVisualStyleBackColor = true;
            this._infoBtn.Click += new System.EventHandler(this._infoBtn_Click);
            // 
            // _costsBtn
            // 
            this._costsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._costsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._costsBtn.Location = new System.Drawing.Point(361, 29);
            this._costsBtn.Name = "_costsBtn";
            this._costsBtn.Size = new System.Drawing.Size(94, 29);
            this._costsBtn.TabIndex = 12;
            this._costsBtn.Text = "Цены";
            this._costsBtn.UseVisualStyleBackColor = true;
            // 
            // _gamesBtn
            // 
            this._gamesBtn.Location = new System.Drawing.Point(261, 29);
            this._gamesBtn.Name = "_gamesBtn";
            this._gamesBtn.Size = new System.Drawing.Size(94, 29);
            this._gamesBtn.TabIndex = 11;
            this._gamesBtn.Text = "Игры";
            this._gamesBtn.UseVisualStyleBackColor = true;
            this._gamesBtn.Click += new System.EventHandler(this._gamesBtn_Click);
            // 
            // _profileBtn
            // 
            this._profileBtn.Location = new System.Drawing.Point(168, 29);
            this._profileBtn.Name = "_profileBtn";
            this._profileBtn.Size = new System.Drawing.Size(87, 29);
            this._profileBtn.TabIndex = 10;
            this._profileBtn.Text = "Профиль";
            this._profileBtn.UseVisualStyleBackColor = true;
            this._profileBtn.Click += new System.EventHandler(this._profileBtn_Click);
            // 
            // _costsListCheckBox
            // 
            this._costsListCheckBox.FormattingEnabled = true;
            this._costsListCheckBox.Location = new System.Drawing.Point(108, 103);
            this._costsListCheckBox.Name = "_costsListCheckBox";
            this._costsListCheckBox.Size = new System.Drawing.Size(207, 28);
            this._costsListCheckBox.TabIndex = 15;
            // 
            // _costTextBox
            // 
            this._costTextBox.Location = new System.Drawing.Point(492, 103);
            this._costTextBox.Name = "_costTextBox";
            this._costTextBox.Size = new System.Drawing.Size(208, 27);
            this._costTextBox.TabIndex = 16;
            // 
            // _closeBtn
            // 
            this._closeBtn.BackColor = System.Drawing.Color.Silver;
            this._closeBtn.Location = new System.Drawing.Point(711, 12);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(77, 34);
            this._closeBtn.TabIndex = 17;
            this._closeBtn.Text = "Закрыть";
            this._closeBtn.UseVisualStyleBackColor = false;
            this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
            // 
            // CostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._costTextBox);
            this.Controls.Add(this._costsListCheckBox);
            this.Controls.Add(this._contactsBtn);
            this.Controls.Add(this._infoBtn);
            this.Controls.Add(this._costsBtn);
            this.Controls.Add(this._gamesBtn);
            this.Controls.Add(this._profileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CostsForm";
            this.Text = "CostsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _contactsBtn;
        private System.Windows.Forms.Button _infoBtn;
        private System.Windows.Forms.Button _costsBtn;
        private System.Windows.Forms.Button _gamesBtn;
        private System.Windows.Forms.Button _profileBtn;
        private System.Windows.Forms.ComboBox _costsListCheckBox;
        private System.Windows.Forms.TextBox _costTextBox;
        private System.Windows.Forms.Button _closeBtn;
    }
}