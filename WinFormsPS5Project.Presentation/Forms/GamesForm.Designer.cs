
namespace WinFormsPS5Project.Presentation
{
    partial class GamesForm
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
            this._listOfGamesLabel = new System.Windows.Forms.Label();
            this._listGamesComboBox = new System.Windows.Forms.ComboBox();
            this._NameOfGameLabel = new System.Windows.Forms.Label();
            this._gameGenreLabel = new System.Windows.Forms.Label();
            this._releaseDateLabel = new System.Windows.Forms.Label();
            this._gameTextBox = new System.Windows.Forms.TextBox();
            this._genreTextBox = new System.Windows.Forms.TextBox();
            this._releaseDateTextBox = new System.Windows.Forms.TextBox();
            this._addToFavouriteBtn = new System.Windows.Forms.Button();
            this._closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _contactsBtn
            // 
            this._contactsBtn.Location = new System.Drawing.Point(550, 12);
            this._contactsBtn.Name = "_contactsBtn";
            this._contactsBtn.Size = new System.Drawing.Size(94, 29);
            this._contactsBtn.TabIndex = 9;
            this._contactsBtn.Text = "Контакты";
            this._contactsBtn.UseVisualStyleBackColor = true;
            this._contactsBtn.UseWaitCursor = true;
            this._contactsBtn.Click += new System.EventHandler(this._contactsBtn_Click);
            // 
            // _infoBtn
            // 
            this._infoBtn.Location = new System.Drawing.Point(450, 12);
            this._infoBtn.Name = "_infoBtn";
            this._infoBtn.Size = new System.Drawing.Size(94, 29);
            this._infoBtn.TabIndex = 8;
            this._infoBtn.Text = "О нас";
            this._infoBtn.UseVisualStyleBackColor = true;
            this._infoBtn.UseWaitCursor = true;
            this._infoBtn.Click += new System.EventHandler(this._infoBtn_Click);
            // 
            // _costsBtn
            // 
            this._costsBtn.Location = new System.Drawing.Point(350, 12);
            this._costsBtn.Name = "_costsBtn";
            this._costsBtn.Size = new System.Drawing.Size(94, 29);
            this._costsBtn.TabIndex = 7;
            this._costsBtn.Text = "Цены";
            this._costsBtn.UseVisualStyleBackColor = true;
            this._costsBtn.UseWaitCursor = true;
            this._costsBtn.Click += new System.EventHandler(this._costsBtn_Click);
            // 
            // _gamesBtn
            // 
            this._gamesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._gamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._gamesBtn.Location = new System.Drawing.Point(250, 12);
            this._gamesBtn.Name = "_gamesBtn";
            this._gamesBtn.Size = new System.Drawing.Size(94, 29);
            this._gamesBtn.TabIndex = 6;
            this._gamesBtn.Text = "Игры";
            this._gamesBtn.UseVisualStyleBackColor = true;
            this._gamesBtn.UseWaitCursor = true;
            // 
            // _profileBtn
            // 
            this._profileBtn.Location = new System.Drawing.Point(157, 12);
            this._profileBtn.Name = "_profileBtn";
            this._profileBtn.Size = new System.Drawing.Size(87, 29);
            this._profileBtn.TabIndex = 5;
            this._profileBtn.Text = "Профиль";
            this._profileBtn.UseVisualStyleBackColor = true;
            this._profileBtn.UseWaitCursor = true;
            this._profileBtn.Click += new System.EventHandler(this._profileBtn_Click);
            // 
            // _listOfGamesLabel
            // 
            this._listOfGamesLabel.AutoSize = true;
            this._listOfGamesLabel.Location = new System.Drawing.Point(32, 82);
            this._listOfGamesLabel.Name = "_listOfGamesLabel";
            this._listOfGamesLabel.Size = new System.Drawing.Size(92, 20);
            this._listOfGamesLabel.TabIndex = 10;
            this._listOfGamesLabel.Text = "Список Игр:";
            this._listOfGamesLabel.UseWaitCursor = true;
            // 
            // _listGamesComboBox
            // 
            this._listGamesComboBox.FormattingEnabled = true;
            this._listGamesComboBox.Location = new System.Drawing.Point(157, 79);
            this._listGamesComboBox.Name = "_listGamesComboBox";
            this._listGamesComboBox.Size = new System.Drawing.Size(487, 28);
            this._listGamesComboBox.TabIndex = 11;
            this._listGamesComboBox.UseWaitCursor = true;
            this._listGamesComboBox.SelectedIndexChanged += new System.EventHandler(this._listGamesComboBox_SelectedIndexChanged);
            // 
            // _NameOfGameLabel
            // 
            this._NameOfGameLabel.AutoSize = true;
            this._NameOfGameLabel.Location = new System.Drawing.Point(187, 167);
            this._NameOfGameLabel.Name = "_NameOfGameLabel";
            this._NameOfGameLabel.Size = new System.Drawing.Size(46, 20);
            this._NameOfGameLabel.TabIndex = 12;
            this._NameOfGameLabel.Text = "Игра:";
            this._NameOfGameLabel.UseWaitCursor = true;
            // 
            // _gameGenreLabel
            // 
            this._gameGenreLabel.AutoSize = true;
            this._gameGenreLabel.Location = new System.Drawing.Point(496, 167);
            this._gameGenreLabel.Name = "_gameGenreLabel";
            this._gameGenreLabel.Size = new System.Drawing.Size(51, 20);
            this._gameGenreLabel.TabIndex = 13;
            this._gameGenreLabel.Text = "Жанр:";
            this._gameGenreLabel.UseWaitCursor = true;
            // 
            // _releaseDateLabel
            // 
            this._releaseDateLabel.AutoSize = true;
            this._releaseDateLabel.Location = new System.Drawing.Point(664, 167);
            this._releaseDateLabel.Name = "_releaseDateLabel";
            this._releaseDateLabel.Size = new System.Drawing.Size(97, 20);
            this._releaseDateLabel.TabIndex = 14;
            this._releaseDateLabel.Text = "Дата релиза:";
            this._releaseDateLabel.UseWaitCursor = true;
            // 
            // _gameTextBox
            // 
            this._gameTextBox.Location = new System.Drawing.Point(32, 209);
            this._gameTextBox.Name = "_gameTextBox";
            this._gameTextBox.Size = new System.Drawing.Size(382, 27);
            this._gameTextBox.TabIndex = 15;
            this._gameTextBox.UseWaitCursor = true;
            // 
            // _genreTextBox
            // 
            this._genreTextBox.Location = new System.Drawing.Point(436, 209);
            this._genreTextBox.Name = "_genreTextBox";
            this._genreTextBox.Size = new System.Drawing.Size(180, 27);
            this._genreTextBox.TabIndex = 16;
            this._genreTextBox.UseWaitCursor = true;
            // 
            // _releaseDateTextBox
            // 
            this._releaseDateTextBox.Location = new System.Drawing.Point(635, 209);
            this._releaseDateTextBox.Name = "_releaseDateTextBox";
            this._releaseDateTextBox.Size = new System.Drawing.Size(153, 27);
            this._releaseDateTextBox.TabIndex = 17;
            this._releaseDateTextBox.UseWaitCursor = true;
            // 
            // _addToFavouriteBtn
            // 
            this._addToFavouriteBtn.Location = new System.Drawing.Point(281, 278);
            this._addToFavouriteBtn.Name = "_addToFavouriteBtn";
            this._addToFavouriteBtn.Size = new System.Drawing.Size(266, 29);
            this._addToFavouriteBtn.TabIndex = 19;
            this._addToFavouriteBtn.Text = "Добавить в избранное";
            this._addToFavouriteBtn.UseVisualStyleBackColor = true;
            this._addToFavouriteBtn.UseWaitCursor = true;
            this._addToFavouriteBtn.Click += new System.EventHandler(this._addToFavouriteBtn_Click);
            // 
            // _closeBtn
            // 
            this._closeBtn.BackColor = System.Drawing.Color.Silver;
            this._closeBtn.Location = new System.Drawing.Point(711, 12);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(77, 34);
            this._closeBtn.TabIndex = 20;
            this._closeBtn.Text = "Закрыть";
            this._closeBtn.UseVisualStyleBackColor = false;
            this._closeBtn.UseWaitCursor = true;
            this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._addToFavouriteBtn);
            this.Controls.Add(this._releaseDateTextBox);
            this.Controls.Add(this._genreTextBox);
            this.Controls.Add(this._gameTextBox);
            this.Controls.Add(this._releaseDateLabel);
            this.Controls.Add(this._gameGenreLabel);
            this.Controls.Add(this._NameOfGameLabel);
            this.Controls.Add(this._listGamesComboBox);
            this.Controls.Add(this._listOfGamesLabel);
            this.Controls.Add(this._contactsBtn);
            this.Controls.Add(this._infoBtn);
            this.Controls.Add(this._costsBtn);
            this.Controls.Add(this._gamesBtn);
            this.Controls.Add(this._profileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Games";
            this.Text = "Games";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _contactsBtn;
        private System.Windows.Forms.Button _infoBtn;
        private System.Windows.Forms.Button _costsBtn;
        private System.Windows.Forms.Button _gamesBtn;
        private System.Windows.Forms.Button _profileBtn;
        private System.Windows.Forms.Label _listOfGamesLabel;
        private System.Windows.Forms.ComboBox _listGamesComboBox;
        private System.Windows.Forms.Label _NameOfGameLabel;
        private System.Windows.Forms.Label _gameGenreLabel;
        private System.Windows.Forms.Label _releaseDateLabel;
        private System.Windows.Forms.TextBox _gameTextBox;
        private System.Windows.Forms.TextBox _genreTextBox;
        private System.Windows.Forms.TextBox _releaseDateTextBox;
        private System.Windows.Forms.Button _addToFavouriteBtn;
        private System.Windows.Forms.Button _closeBtn;
    }
}