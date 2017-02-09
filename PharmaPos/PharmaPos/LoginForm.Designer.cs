namespace PharmaPos
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.waterMarkTextBoxUser = new UtilityManager.ui.WaterMarkTextBox();
            this.waterMarkTextBoxPassword = new UtilityManager.ui.WaterMarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 40);
            this.panel1.TabIndex = 2;
            // 
            // waterMarkTextBoxUser
            // 
            this.waterMarkTextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBoxUser.Location = new System.Drawing.Point(279, 89);
            this.waterMarkTextBoxUser.Name = "waterMarkTextBoxUser";
            this.waterMarkTextBoxUser.Size = new System.Drawing.Size(215, 20);
            this.waterMarkTextBoxUser.TabIndex = 3;
            this.waterMarkTextBoxUser.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBoxUser.WaterMarkText = "<<enter username>>";
            // 
            // waterMarkTextBoxPassword
            // 
            this.waterMarkTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBoxPassword.Location = new System.Drawing.Point(279, 118);
            this.waterMarkTextBoxPassword.Name = "waterMarkTextBoxPassword";
            this.waterMarkTextBoxPassword.Size = new System.Drawing.Size(215, 20);
            this.waterMarkTextBoxPassword.TabIndex = 4;
            this.waterMarkTextBoxPassword.UseSystemPasswordChar = true;
            this.waterMarkTextBoxPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBoxPassword.WaterMarkText = "<<enter password>>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(419, 162);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(279, 162);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(134, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(211, 206);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(16, 13);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaPos.Properties.Resources.thFTZEPTJU;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Welcome! Please provide User Account to login. Thank you.";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(523, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waterMarkTextBoxPassword);
            this.Controls.Add(this.waterMarkTextBoxUser);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UtilityManager.ui.WaterMarkTextBox waterMarkTextBoxUser;
        private UtilityManager.ui.WaterMarkTextBox waterMarkTextBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}