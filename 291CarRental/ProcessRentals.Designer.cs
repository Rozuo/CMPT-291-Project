namespace _291CarRental
{
    partial class ProcessRentals
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
            this.processRentalsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processRentalsTitle
            // 
            this.processRentalsTitle.AutoSize = true;
            this.processRentalsTitle.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processRentalsTitle.ForeColor = System.Drawing.Color.White;
            this.processRentalsTitle.Location = new System.Drawing.Point(270, 9);
            this.processRentalsTitle.Name = "processRentalsTitle";
            this.processRentalsTitle.Size = new System.Drawing.Size(240, 34);
            this.processRentalsTitle.TabIndex = 0;
            this.processRentalsTitle.Text = "Process Rentals";
            // 
            // ProcessRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processRentalsTitle);
            this.Name = "ProcessRentals";
            this.Text = "ProcessRentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processRentalsTitle;
    }
}