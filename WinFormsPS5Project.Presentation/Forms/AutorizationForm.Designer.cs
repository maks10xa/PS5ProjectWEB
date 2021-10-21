
namespace WinFormsPS5Project.Presentation
{
    partial class AutorizationForm
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
            this._goToRegistration = new System.Windows.Forms.Button();
            this._logInBtn = new System.Windows.Forms.Button();
            this._passwordField = new System.Windows.Forms.TextBox();
            this._loginFIeld = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._loginLabel = new System.Windows.Forms.Label();
            this._authorizationLabel = new System.Windows.Forms.Label();
            this._closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _goToRegistration
            // 
            this._goToRegistration.Location = new System.Drawing.Point(567, 26);
            this._goToRegistration.Name = "_goToRegistration";
            this._goToRegistration.Size = new System.Drawing.Size(221, 29);
            this._goToRegistration.TabIndex = 13;
            this._goToRegistration.Text = "Зарегистрироваться";
            this._goToRegistration.UseVisualStyleBackColor = true;
            this._goToRegistration.Click += new System.EventHandler(this._goToRegistration_Click);
            // 
            // _logInBtn
            // 
            this._logInBtn.Location = new System.Drawing.Point(335, 280);
            this._logInBtn.Name = "_logInBtn";
            this._logInBtn.Size = new System.Drawing.Size(94, 29);
            this._logInBtn.TabIndex = 12;
            this._logInBtn.Text = "Войти";
            this._logInBtn.UseVisualStyleBackColor = true;
            this._logInBtn.Click += new System.EventHandler(this._logInBtn_Click);
            // 
            // _passwordField
            // 
            this._passwordField.Location = new System.Drawing.Point(283, 218);
            this._passwordField.Name = "_passwordField";
            this._passwordField.Size = new System.Drawing.Size(213, 27);
            this._passwordField.TabIndex = 11;
            // 
            // _loginFIeld
            // 
            this._loginFIeld.Location = new System.Drawing.Point(283, 162);
            this._loginFIeld.Name = "_loginFIeld";
            this._loginFIeld.Size = new System.Drawing.Size(213, 27);
            this._loginFIeld.TabIndex = 10;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._passwordLabel.Location = new System.Drawing.Point(172, 222);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(63, 23);
            this._passwordLabel.TabIndex = 9;
            this._passwordLabel.Text = "Пароль";
            // 
            // _loginLabel
            // 
            this._loginLabel.AutoSize = true;
            this._loginLabel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._loginLabel.Location = new System.Drawing.Point(183, 162);
            this._loginLabel.Name = "_loginLabel";
            this._loginLabel.Size = new System.Drawing.Size(52, 23);
            this._loginLabel.TabIndex = 8;
            this._loginLabel.Text = "Логин";
            // 
            // _authorizationLabel
            // 
            this._authorizationLabel.AutoSize = true;
            this._authorizationLabel.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._authorizationLabel.Location = new System.Drawing.Point(307, 81);
            this._authorizationLabel.Name = "_authorizationLabel";
            this._authorizationLabel.Size = new System.Drawing.Size(161, 31);
            this._authorizationLabel.TabIndex = 7;
            this._authorizationLabel.Text = "Авторизация";
            // 
            // _closeBtn
            // 
            this._closeBtn.BackColor = System.Drawing.Color.Silver;
            this._closeBtn.Location = new System.Drawing.Point(12, 12);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(77, 34);
            this._closeBtn.TabIndex = 14;
            this._closeBtn.Text = "Закрыть";
            this._closeBtn.UseVisualStyleBackColor = false;
            this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
            this._closeBtn.MouseEnter += new System.EventHandler(this._closeBtn_MouseEnter);
            this._closeBtn.MouseLeave += new System.EventHandler(this._closeBtn_MouseLeave);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._goToRegistration);
            this.Controls.Add(this._logInBtn);
            this.Controls.Add(this._passwordField);
            this.Controls.Add(this._loginFIeld);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._loginLabel);
            this.Controls.Add(this._authorizationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizationForm";
            this.Text = "AutorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _goToRegistration;
        private System.Windows.Forms.Button _logInBtn;
        private System.Windows.Forms.TextBox _passwordField;
        private System.Windows.Forms.TextBox _loginFIeld;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _loginLabel;
        private System.Windows.Forms.Label _authorizationLabel;
        private System.Windows.Forms.Button _closeBtn;
    }
}