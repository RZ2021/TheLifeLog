
namespace TheLifeLog
{
    partial class BudgetMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.billsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PSButton = new System.Windows.Forms.Button();
            this.SavingsButton = new System.Windows.Forms.Button();
            this.BudgetButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.billsButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.PSButton);
            this.panel1.Controls.Add(this.SavingsButton);
            this.panel1.Controls.Add(this.BudgetButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(241, 637);
            this.panel1.TabIndex = 16;
            // 
            // billsButton
            // 
            this.billsButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.billsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.billsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billsButton.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsButton.Location = new System.Drawing.Point(3, 449);
            this.billsButton.Name = "billsButton";
            this.billsButton.Size = new System.Drawing.Size(238, 67);
            this.billsButton.TabIndex = 11;
            this.billsButton.Text = "Bills";
            this.billsButton.UseVisualStyleBackColor = false;
            this.billsButton.Click += new System.EventHandler(this.billsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 180);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // PSButton
            // 
            this.PSButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.PSButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PSButton.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSButton.Location = new System.Drawing.Point(3, 376);
            this.PSButton.Name = "PSButton";
            this.PSButton.Size = new System.Drawing.Size(238, 67);
            this.PSButton.TabIndex = 4;
            this.PSButton.Text = "Past Spending";
            this.PSButton.UseVisualStyleBackColor = false;
            this.PSButton.Click += new System.EventHandler(this.PSButton_Click);
            // 
            // SavingsButton
            // 
            this.SavingsButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SavingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavingsButton.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsButton.Location = new System.Drawing.Point(3, 303);
            this.SavingsButton.Name = "SavingsButton";
            this.SavingsButton.Size = new System.Drawing.Size(238, 67);
            this.SavingsButton.TabIndex = 3;
            this.SavingsButton.Text = "Savings";
            this.SavingsButton.UseVisualStyleBackColor = false;
            this.SavingsButton.Click += new System.EventHandler(this.SavingsButton_Click);
            // 
            // BudgetButton
            // 
            this.BudgetButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BudgetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BudgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BudgetButton.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetButton.Location = new System.Drawing.Point(3, 230);
            this.BudgetButton.Name = "BudgetButton";
            this.BudgetButton.Size = new System.Drawing.Size(238, 67);
            this.BudgetButton.TabIndex = 2;
            this.BudgetButton.Text = "Budget";
            this.BudgetButton.UseVisualStyleBackColor = false;
            this.BudgetButton.Click += new System.EventHandler(this.BudgetButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Location = new System.Drawing.Point(310, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 474);
            this.panel2.TabIndex = 17;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Minerva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(997, -13);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(42, 50);
            this.exitLabel.TabIndex = 18;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // BudgetMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 637);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BudgetMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SavingsButton;
        private System.Windows.Forms.Button BudgetButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PSButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Button billsButton;
    }
}