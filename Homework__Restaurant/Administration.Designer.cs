namespace Homework__Restaurant
{
    partial class Administration
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
            lbl_text = new Label();
            lbl_password = new Label();
            tb_enteredPassword = new TextBox();
            to_come_in_btn = new Button();
            SuspendLayout();
            // 
            // lbl_text
            // 
            lbl_text.AutoSize = true;
            lbl_text.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_text.ForeColor = Color.Gray;
            lbl_text.Location = new Point(12, 9);
            lbl_text.Name = "lbl_text";
            lbl_text.Size = new Size(422, 58);
            lbl_text.TabIndex = 1;
            lbl_text.Text = "Для следующих действий вы\r\nдолжны иметь права админитратора";
            lbl_text.Click += lbl_text_Click;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Bahnschrift", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.FromArgb(112, 151, 171);
            lbl_password.Location = new Point(12, 81);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(279, 42);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Введите пароль";
            // 
            // tb_enteredPassword
            // 
            tb_enteredPassword.Location = new Point(22, 143);
            tb_enteredPassword.Name = "tb_enteredPassword";
            tb_enteredPassword.Size = new Size(615, 39);
            tb_enteredPassword.TabIndex = 3;
            // 
            // to_come_in_btn
            // 
            to_come_in_btn.BackColor = Color.FromArgb(221, 224, 221);
            to_come_in_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            to_come_in_btn.Location = new Point(351, 399);
            to_come_in_btn.Name = "to_come_in_btn";
            to_come_in_btn.Size = new Size(321, 46);
            to_come_in_btn.TabIndex = 12;
            to_come_in_btn.Text = "Войти";
            to_come_in_btn.UseVisualStyleBackColor = false;
            to_come_in_btn.Click += to_come_in_btn_Click;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 457);
            Controls.Add(to_come_in_btn);
            Controls.Add(tb_enteredPassword);
            Controls.Add(lbl_password);
            Controls.Add(lbl_text);
            Name = "Administration";
            Text = "Administration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_text;
        private Label lbl_password;
        private TextBox tb_enteredPassword;
        private Button to_come_in_btn;
    }
}