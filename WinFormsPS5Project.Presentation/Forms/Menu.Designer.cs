
namespace WinFormsPS5Project.Presentation
{
    partial class Menu
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
            this._profileBtn = new System.Windows.Forms.Button();
            this._gamesBtn = new System.Windows.Forms.Button();
            this._costsBtn = new System.Windows.Forms.Button();
            this._infoBtn = new System.Windows.Forms.Button();
            this._contactsBtn = new System.Windows.Forms.Button();
            this._closeBtn = new System.Windows.Forms.Button();
            this._profilePhoto = new System.Windows.Forms.PictureBox();
            this._nameTxt = new System.Windows.Forms.TextBox();
            this._loginTxt = new System.Windows.Forms.TextBox();
            this._gamesListTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._profilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // _profileBtn
            // 
            this._profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._profileBtn.Location = new System.Drawing.Point(146, 12);
            this._profileBtn.Name = "_profileBtn";
            this._profileBtn.Size = new System.Drawing.Size(87, 29);
            this._profileBtn.TabIndex = 0;
            this._profileBtn.Text = "Профиль";
            this._profileBtn.UseVisualStyleBackColor = true;
            // 
            // _gamesBtn
            // 
            this._gamesBtn.Location = new System.Drawing.Point(239, 12);
            this._gamesBtn.Name = "_gamesBtn";
            this._gamesBtn.Size = new System.Drawing.Size(94, 29);
            this._gamesBtn.TabIndex = 1;
            this._gamesBtn.Text = "Игры";
            this._gamesBtn.UseVisualStyleBackColor = true;
            this._gamesBtn.Click += new System.EventHandler(this._gamesBtn_Click);
            // 
            // _costsBtn
            // 
            this._costsBtn.Location = new System.Drawing.Point(339, 12);
            this._costsBtn.Name = "_costsBtn";
            this._costsBtn.Size = new System.Drawing.Size(94, 29);
            this._costsBtn.TabIndex = 2;
            this._costsBtn.Text = "Цены";
            this._costsBtn.UseVisualStyleBackColor = true;
            this._costsBtn.Click += new System.EventHandler(this._costsBtn_Click);
            // 
            // _infoBtn
            // 
            this._infoBtn.Location = new System.Drawing.Point(439, 12);
            this._infoBtn.Name = "_infoBtn";
            this._infoBtn.Size = new System.Drawing.Size(94, 29);
            this._infoBtn.TabIndex = 3;
            this._infoBtn.Text = "О нас";
            this._infoBtn.UseVisualStyleBackColor = true;
            this._infoBtn.Click += new System.EventHandler(this._infoBtn_Click);
            // 
            // _contactsBtn
            // 
            this._contactsBtn.Location = new System.Drawing.Point(539, 12);
            this._contactsBtn.Name = "_contactsBtn";
            this._contactsBtn.Size = new System.Drawing.Size(94, 29);
            this._contactsBtn.TabIndex = 4;
            this._contactsBtn.Text = "Контакты";
            this._contactsBtn.UseVisualStyleBackColor = true;
            this._contactsBtn.Click += new System.EventHandler(this._contactsBtn_Click);
            // 
            // _closeBtn
            // 
            this._closeBtn.BackColor = System.Drawing.Color.Silver;
            this._closeBtn.Location = new System.Drawing.Point(711, 12);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(77, 34);
            this._closeBtn.TabIndex = 15;
            this._closeBtn.Text = "Закрыть";
            this._closeBtn.UseVisualStyleBackColor = false;
            this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
            // 
            // _profilePhoto
            // 
            this._profilePhoto.Image = global::WinFormsPS5Project.Presentation.Properties.Resources._197297;
            this._profilePhoto.Location = new System.Drawing.Point(34, 78);
            this._profilePhoto.Name = "_profilePhoto";
            this._profilePhoto.Size = new System.Drawing.Size(259, 195);
            this._profilePhoto.TabIndex = 16;
            this._profilePhoto.TabStop = false;
            // 
            // _nameTxt
            // 
            this._nameTxt.Location = new System.Drawing.Point(358, 78);
            this._nameTxt.Name = "_nameTxt";
            this._nameTxt.Size = new System.Drawing.Size(196, 27);
            this._nameTxt.TabIndex = 17;
            // 
            // _loginTxt
            // 
            this._loginTxt.Location = new System.Drawing.Point(358, 126);
            this._loginTxt.Name = "_loginTxt";
            this._loginTxt.Size = new System.Drawing.Size(196, 27);
            this._loginTxt.TabIndex = 18;
            // 
            // _gamesListTxt
            // 
            this._gamesListTxt.Location = new System.Drawing.Point(358, 186);
            this._gamesListTxt.Multiline = true;
            this._gamesListTxt.Name = "_gamesListTxt";
            this._gamesListTxt.ReadOnly = true;
            this._gamesListTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._gamesListTxt.Size = new System.Drawing.Size(413, 146);
            this._gamesListTxt.TabIndex = 19;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._gamesListTxt);
            this.Controls.Add(this._loginTxt);
            this.Controls.Add(this._nameTxt);
            this.Controls.Add(this._profilePhoto);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._contactsBtn);
            this.Controls.Add(this._infoBtn);
            this.Controls.Add(this._costsBtn);
            this.Controls.Add(this._gamesBtn);
            this.Controls.Add(this._profileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this._profilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _profileBtn;
        private System.Windows.Forms.Button _gamesBtn;
        private System.Windows.Forms.Button _costsBtn;
        private System.Windows.Forms.Button _infoBtn;
        private System.Windows.Forms.Button _contactsBtn;
        private System.Windows.Forms.Button _closeBtn;
        private System.Windows.Forms.PictureBox _profilePhoto;
        private System.Windows.Forms.TextBox _nameTxt;
        private System.Windows.Forms.TextBox _loginTxt;
        private System.Windows.Forms.TextBox _gamesListTxt;
    }
}