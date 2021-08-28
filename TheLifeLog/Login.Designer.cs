
namespace TheLifeLog
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.tdTb2 = new System.Windows.Forms.TextBox();
            this.tdTb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minerva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Minerva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(534, -12);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(42, 50);
            this.exitLabel.TabIndex = 17;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // tdTb2
            // 
            this.tdTb2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tdTb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdTb2.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdTb2.Location = new System.Drawing.Point(130, 286);
            this.tdTb2.Multiline = true;
            this.tdTb2.Name = "tdTb2";
            this.tdTb2.Size = new System.Drawing.Size(319, 35);
            this.tdTb2.TabIndex = 65;
            // 
            // tdTb1
            // 
            this.tdTb1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tdTb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdTb1.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdTb1.Location = new System.Drawing.Point(130, 181);
            this.tdTb1.Multiline = true;
            this.tdTb1.Name = "tdTb1";
            this.tdTb1.Size = new System.Drawing.Size(319, 35);
            this.tdTb1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minerva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 41);
            this.label1.TabIndex = 66;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minerva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 41);
            this.label2.TabIndex = 67;
            this.label2.Text = "Password:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Minerva", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(232, 347);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 47);
            this.saveButton.TabIndex = 84;
            this.saveButton.Text = "Login";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minerva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "Create New User";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(575, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdTb2);
            this.Controls.Add(this.tdTb1);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.TextBox tdTb2;
        private System.Windows.Forms.TextBox tdTb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
    }
}