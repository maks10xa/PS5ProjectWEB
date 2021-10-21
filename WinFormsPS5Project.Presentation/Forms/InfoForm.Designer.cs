
namespace WinFormsPS5Project.Presentation
{
    partial class InfoForm
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
            this._headlineLabel = new System.Windows.Forms.Label();
            this._infoTextBox = new System.Windows.Forms.TextBox();
            this._closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _contactsBtn
            // 
            this._contactsBtn.Location = new System.Drawing.Point(558, 30);
            this._contactsBtn.Name = "_contactsBtn";
            this._contactsBtn.Size = new System.Drawing.Size(94, 29);
            this._contactsBtn.TabIndex = 19;
            this._contactsBtn.Text = "Контакты";
            this._contactsBtn.UseVisualStyleBackColor = true;
            // 
            // _infoBtn
            // 
            this._infoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._infoBtn.Location = new System.Drawing.Point(458, 30);
            this._infoBtn.Name = "_infoBtn";
            this._infoBtn.Size = new System.Drawing.Size(94, 29);
            this._infoBtn.TabIndex = 18;
            this._infoBtn.Text = "О нас";
            this._infoBtn.UseVisualStyleBackColor = true;
            // 
            // _costsBtn
            // 
            this._costsBtn.Location = new System.Drawing.Point(358, 30);
            this._costsBtn.Name = "_costsBtn";
            this._costsBtn.Size = new System.Drawing.Size(94, 29);
            this._costsBtn.TabIndex = 17;
            this._costsBtn.Text = "Цены";
            this._costsBtn.UseVisualStyleBackColor = true;
            // 
            // _gamesBtn
            // 
            this._gamesBtn.Location = new System.Drawing.Point(258, 30);
            this._gamesBtn.Name = "_gamesBtn";
            this._gamesBtn.Size = new System.Drawing.Size(94, 29);
            this._gamesBtn.TabIndex = 16;
            this._gamesBtn.Text = "Игры";
            this._gamesBtn.UseVisualStyleBackColor = true;
            // 
            // _profileBtn
            // 
            this._profileBtn.Location = new System.Drawing.Point(165, 30);
            this._profileBtn.Name = "_profileBtn";
            this._profileBtn.Size = new System.Drawing.Size(87, 29);
            this._profileBtn.TabIndex = 15;
            this._profileBtn.Text = "Профиль";
            this._profileBtn.UseVisualStyleBackColor = true;
            // 
            // _headlineLabel
            // 
            this._headlineLabel.AutoSize = true;
            this._headlineLabel.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._headlineLabel.Location = new System.Drawing.Point(165, 72);
            this._headlineLabel.Name = "_headlineLabel";
            this._headlineLabel.Size = new System.Drawing.Size(474, 33);
            this._headlineLabel.TabIndex = 20;
            this._headlineLabel.Text = "Как проходит аренда Playstation 5 у нас!";
            // 
            // _infoTextBox
            // 
            this._infoTextBox.Location = new System.Drawing.Point(34, 118);
            this._infoTextBox.Multiline = true;
            this._infoTextBox.Name = "_infoTextBox";
            this._infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._infoTextBox.Size = new System.Drawing.Size(733, 306);
            this._infoTextBox.TabIndex = 21;
            // 
            // _closeBtn
            // 
            this._closeBtn.BackColor = System.Drawing.Color.Silver;
            this._closeBtn.Location = new System.Drawing.Point(711, 12);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(77, 34);
            this._closeBtn.TabIndex = 22;
            this._closeBtn.Text = "Закрыть";
            this._closeBtn.UseVisualStyleBackColor = false;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._infoTextBox);
            this.Controls.Add(this._headlineLabel);
            this.Controls.Add(this._contactsBtn);
            this.Controls.Add(this._infoBtn);
            this.Controls.Add(this._costsBtn);
            this.Controls.Add(this._gamesBtn);
            this.Controls.Add(this._profileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _contactsBtn;
        private System.Windows.Forms.Button _infoBtn;
        private System.Windows.Forms.Button _costsBtn;
        private System.Windows.Forms.Button _gamesBtn;
        private System.Windows.Forms.Button _profileBtn;
        private System.Windows.Forms.Label _headlineLabel;
        private System.Windows.Forms.TextBox _infoTextBox;
        private System.Windows.Forms.Button _closeBtn;
    }
}