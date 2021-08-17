
namespace TheLifeLog
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.billsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SavingsButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billTB = new System.Windows.Forms.TextBox();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.formTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.billsButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SavingsButton);
            this.panel1.Controls.Add(this.CalendarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(241, 669);
            this.panel1.TabIndex = 18;
            // 
            // billsButton
            // 
            this.billsButton.BackColor = System.Drawing.Color.Gold;
            this.billsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.billsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billsButton.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsButton.Location = new System.Drawing.Point(3, 449);
            this.billsButton.Name = "billsButton";
            this.billsButton.Size = new System.Drawing.Size(238, 67);
            this.billsButton.TabIndex = 12;
            this.billsButton.Text = "Bills";
            this.billsButton.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Past Savings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // CalendarButton
            // 
            this.CalendarButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CalendarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarButton.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.Location = new System.Drawing.Point(3, 230);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(238, 67);
            this.CalendarButton.TabIndex = 2;
            this.CalendarButton.Text = "Budget";
            this.CalendarButton.UseVisualStyleBackColor = false;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minerva", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 41);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bills";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minerva", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "----------------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minerva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minerva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(794, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Due: mm/dd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minerva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 35);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minerva", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 35);
            this.label6.TabIndex = 26;
            this.label6.Text = "Form:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Minerva", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(271, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 357);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // billTB
            // 
            this.billTB.BackColor = System.Drawing.Color.MediumTurquoise;
            this.billTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billTB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTB.Location = new System.Drawing.Point(271, 539);
            this.billTB.Multiline = true;
            this.billTB.Name = "billTB";
            this.billTB.Size = new System.Drawing.Size(146, 34);
            this.billTB.TabIndex = 28;
            this.billTB.Text = "Enter bill:";
            this.billTB.Click += new System.EventHandler(this.billTB_Click);
            // 
            // amountTB
            // 
            this.amountTB.BackColor = System.Drawing.Color.MediumTurquoise;
            this.amountTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.Location = new System.Drawing.Point(446, 539);
            this.amountTB.Multiline = true;
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(160, 34);
            this.amountTB.TabIndex = 29;
            this.amountTB.Text = "Enter amount:";
            this.amountTB.Click += new System.EventHandler(this.amountTB_Click);
            // 
            // formTB
            // 
            this.formTB.BackColor = System.Drawing.Color.MediumTurquoise;
            this.formTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formTB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTB.Location = new System.Drawing.Point(631, 539);
            this.formTB.Multiline = true;
            this.formTB.Name = "formTB";
            this.formTB.Size = new System.Drawing.Size(160, 34);
            this.formTB.TabIndex = 30;
            this.formTB.Text = "Enter form:";
            this.formTB.Click += new System.EventHandler(this.formTB_Click);
            // 
            // dateTB
            // 
            this.dateTB.BackColor = System.Drawing.Color.MediumTurquoise;
            this.dateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTB.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTB.Location = new System.Drawing.Point(817, 539);
            this.dateTB.Multiline = true;
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(160, 34);
            this.dateTB.TabIndex = 31;
            this.dateTB.Text = "Enter due date:";
            this.dateTB.Click += new System.EventHandler(this.dateTB_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearButton.Font = new System.Drawing.Font("Minerva", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(870, 618);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 39);
            this.clearButton.TabIndex = 57;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.newButton.Font = new System.Drawing.Font("Minerva", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.Black;
            this.newButton.Location = new System.Drawing.Point(743, 618);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(107, 39);
            this.newButton.TabIndex = 59;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Minerva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(955, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(42, 50);
            this.exitLabel.TabIndex = 60;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 669);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.formTB);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.billTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button billsButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SavingsButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox billTB;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.TextBox formTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label exitLabel;
    }
}