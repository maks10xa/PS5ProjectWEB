
namespace WinFormsPS5Project.Presentation
{
    partial class RegistrationForm
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
            this._registrationLabel = new System.Windows.Forms.Label();
            this._passwordField = new System.Windows.Forms.TextBox();
            this._loginFIeld = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._дщпштLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._registerBtn = new System.Windows.Forms.Button();
            this._closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _registrationLabel
            // 
            this._registrationLabel.AutoSize = true;
            this._registrationLabel.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._registrationLabel.Location = new System.Drawing.Point(319, 28);
            this._registrationLabel.Name = "_registrationLabel";
            this._registrationLabel.Size = new System.Drawing.Size(160, 31);
            this._registrationLabel.TabIndex = 1;
            this._registrationLabel.Text = "Регистрация";
            // 
            // _passwordField
            // 
            this._passwordField.Location = new System.Drawing.Point(304, 186);
            this._passwordField.Name = "_passwordField";
            this._passwordField.Size = new System.Drawing.Size(213, 27);
            this._passwordField.TabIndex = 8;
            // 
            // _loginFIeld
            // 
            this._loginFIeld.Location = new System.Drawing.Point(304, 139);
            this._loginFIeld.Name = "_loginFIeld";
            this._loginFIeld.Size = new System.Drawing.Size(213, 27);
            this._loginFIeld.TabIndex = 7;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._passwordLabel.Location = new System.Drawing.Point(204, 190);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(63, 23);
            this._passwordLabel.TabIndex = 6;
            this._passwordLabel.Text = "Пароль";
            // 
            // _дщпштLabel
            // 
            this._дщпштLabel.AutoSize = true;
            this._дщпштLabel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._дщпштLabel.Location = new System.Drawing.Point(204, 139);
            this._дщпштLabel.Name = "_дщпштLabel";
            this._дщпштLabel.Size = new System.Drawing.Size(52, 23);
            this._дщпштLabel.TabIndex = 5;
            this._дщпштLabel.Text = "Логин";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 27);
            this.textBox2.TabIndex = 11;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._nameLabel.Location = new System.Drawing.Point(204, 234);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(40, 23);
            this._nameLabel.TabIndex = 9;
            this._nameLabel.Text = "Имя";
            // 
            // _registerBtn
            // 
            this._registerBtn.Location = new System.Drawing.Point(292, 325);
            this._registerBtn.Name = "_registerBtn";
            this._registerBtn.Size = new System.Drawing.Size(225, 29);
            this._registerBtn.TabIndex = 12;
            this._registerBtn.Text = "Зарегистрироваться";
            this._registerBtn.UseVisualStyleBackColor = true;
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
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._closeBtn);
            this.Controls.Add(this._registerBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._passwordField);
            this.Controls.Add(this._loginFIeld);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._дщпштLabel);
            this.Controls.Add(this._registrationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _registrationLabel;
        private System.Windows.Forms.TextBox _passwordField;
        private System.Windows.Forms.TextBox _loginFIeld;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _дщпштLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Button _registerBtn;
        private System.Windows.Forms.Button _closeBtn;
    }
}