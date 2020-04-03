namespace _291CarRental
{
    partial class Report
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
            this.reportTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMostBranch = new System.Windows.Forms.Label();
            this.labelMostReservation = new System.Windows.Forms.Label();
            this.labelMostMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportTitle
            // 
            this.reportTitle.AutoSize = true;
            this.reportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reportTitle.ForeColor = System.Drawing.Color.White;
            this.reportTitle.Location = new System.Drawing.Point(362, 9);
            this.reportTitle.Name = "reportTitle";
            this.reportTitle.Size = new System.Drawing.Size(69, 25);
            this.reportTitle.TabIndex = 0;
            this.reportTitle.Text = "Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "The most car rentals this month at branch: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Most cars rented at the most popular branch: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Highest monetary achieved in a single transaction:";
            // 
            // labelMostBranch
            // 
            this.labelMostBranch.AutoSize = true;
            this.labelMostBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMostBranch.ForeColor = System.Drawing.Color.White;
            this.labelMostBranch.Location = new System.Drawing.Point(382, 68);
            this.labelMostBranch.Name = "labelMostBranch";
            this.labelMostBranch.Size = new System.Drawing.Size(60, 24);
            this.labelMostBranch.TabIndex = 4;
            this.labelMostBranch.Text = "label4";
            // 
            // labelMostReservation
            // 
            this.labelMostReservation.AutoSize = true;
            this.labelMostReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMostReservation.ForeColor = System.Drawing.Color.White;
            this.labelMostReservation.Location = new System.Drawing.Point(405, 152);
            this.labelMostReservation.Name = "labelMostReservation";
            this.labelMostReservation.Size = new System.Drawing.Size(60, 24);
            this.labelMostReservation.TabIndex = 5;
            this.labelMostReservation.Text = "label5";
            // 
            // labelMostMoney
            // 
            this.labelMostMoney.AutoSize = true;
            this.labelMostMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMostMoney.ForeColor = System.Drawing.Color.White;
            this.labelMostMoney.Location = new System.Drawing.Point(448, 251);
            this.labelMostMoney.Name = "labelMostMoney";
            this.labelMostMoney.Size = new System.Drawing.Size(60, 24);
            this.labelMostMoney.TabIndex = 6;
            this.labelMostMoney.Text = "label6";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMostMoney);
            this.Controls.Add(this.labelMostReservation);
            this.Controls.Add(this.labelMostBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportTitle);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMostBranch;
        private System.Windows.Forms.Label labelMostReservation;
        private System.Windows.Forms.Label labelMostMoney;
    }
}