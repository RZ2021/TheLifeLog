
namespace TheLifeLog
{
    partial class NewUser
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p1TB = new System.Windows.Forms.TextBox();
            this.unTB = new System.Windows.Forms.TextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p2TB = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Minerva", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(198, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 47);
            this.saveButton.TabIndex = 91;
            this.saveButton.Text = "Create";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minerva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 35);
            this.label2.TabIndex = 90;
            this.label2.Text = "Choose a password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minerva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 35);
            this.label1.TabIndex = 89;
            this.label1.Text = "Choose a username:";
            // 
            // p1TB
            // 
            this.p1TB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.p1TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1TB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1TB.Location = new System.Drawing.Point(95, 231);
            this.p1TB.Multiline = true;
            this.p1TB.Name = "p1TB";
            this.p1TB.Size = new System.Drawing.Size(319, 35);
            this.p1TB.TabIndex = 88;
            // 
            // unTB
            // 
            this.unTB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.unTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unTB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unTB.Location = new System.Drawing.Point(95, 141);
            this.unTB.Multiline = true;
            this.unTB.Name = "unTB";
            this.unTB.Size = new System.Drawing.Size(319, 35);
            this.unTB.TabIndex = 87;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Minerva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(464, -6);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(42, 50);
            this.exitLabel.TabIndex = 86;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minerva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 50);
            this.label3.TabIndex = 85;
            this.label3.Text = "Create New User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minerva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 35);
            this.label4.TabIndex = 93;
            this.label4.Text = "Confirm your password:";
            // 
            // p2TB
            // 
            this.p2TB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.p2TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2TB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2TB.Location = new System.Drawing.Point(95, 322);
            this.p2TB.Multiline = true;
            this.p2TB.Name = "p2TB";
            this.p2TB.Size = new System.Drawing.Size(319, 35);
            this.p2TB.TabIndex = 92;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Minerva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(147, 465);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 35);
            this.ErrorLabel.TabIndex = 94;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(512, 508);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p2TB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1TB);
            this.Controls.Add(this.unTB);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewUser_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewUser_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewUser_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox p1TB;
        private System.Windows.Forms.TextBox unTB;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p2TB;
        private System.Windows.Forms.Label ErrorLabel;
    }
}