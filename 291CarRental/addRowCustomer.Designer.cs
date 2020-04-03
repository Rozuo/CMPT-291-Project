namespace WindowsFormsApp1
{
    partial class addRowCustomer
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
            this.extraFeeAdmin = new System.Windows.Forms.ComboBox();
            this.ExtraFeeCustomer = new System.Windows.Forms.ComboBox();
            this.removeListB = new System.Windows.Forms.Button();
            this.addListB = new System.Windows.Forms.Button();
            this.extraFeeList = new System.Windows.Forms.ListBox();
            this.resultB = new System.Windows.Forms.Button();
            this.priceResult = new System.Windows.Forms.Label();
            this.branchL = new System.Windows.Forms.Label();
            this.locationB = new System.Windows.Forms.ComboBox();
            this.startDateL = new System.Windows.Forms.Label();
            this.cancelB = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.confirmB = new System.Windows.Forms.Button();
            this.endDateL = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // extraFeeAdmin
            // 
            this.extraFeeAdmin.FormattingEnabled = true;
            this.extraFeeAdmin.Items.AddRange(new object[] {
            "Late return",
            "Special Insurance",
            "Oil Fee",
            "Different Location"});
            this.extraFeeAdmin.Location = new System.Drawing.Point(327, 63);
            this.extraFeeAdmin.Name = "extraFeeAdmin";
            this.extraFeeAdmin.Size = new System.Drawing.Size(121, 21);
            this.extraFeeAdmin.TabIndex = 44;
            // 
            // ExtraFeeCustomer
            // 
            this.ExtraFeeCustomer.FormattingEnabled = true;
            this.ExtraFeeCustomer.Items.AddRange(new object[] {
            "Special Insurence",
            "Oil Fee"});
            this.ExtraFeeCustomer.Location = new System.Drawing.Point(327, 33);
            this.ExtraFeeCustomer.Name = "ExtraFeeCustomer";
            this.ExtraFeeCustomer.Size = new System.Drawing.Size(121, 21);
            this.ExtraFeeCustomer.TabIndex = 43;
            // 
            // removeListB
            // 
            this.removeListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeListB.Location = new System.Drawing.Point(337, 169);
            this.removeListB.Name = "removeListB";
            this.removeListB.Size = new System.Drawing.Size(103, 28);
            this.removeListB.TabIndex = 42;
            this.removeListB.Text = "Remove";
            this.removeListB.UseVisualStyleBackColor = true;
            // 
            // addListB
            // 
            this.addListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListB.Location = new System.Drawing.Point(337, 113);
            this.addListB.Name = "addListB";
            this.addListB.Size = new System.Drawing.Size(103, 28);
            this.addListB.TabIndex = 41;
            this.addListB.Text = "Add";
            this.addListB.UseVisualStyleBackColor = true;
            // 
            // extraFeeList
            // 
            this.extraFeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraFeeList.FormattingEnabled = true;
            this.extraFeeList.ItemHeight = 20;
            this.extraFeeList.Location = new System.Drawing.Point(9, 113);
            this.extraFeeList.Name = "extraFeeList";
            this.extraFeeList.Size = new System.Drawing.Size(322, 84);
            this.extraFeeList.TabIndex = 40;
            // 
            // resultB
            // 
            this.resultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultB.Location = new System.Drawing.Point(121, 222);
            this.resultB.Name = "resultB";
            this.resultB.Size = new System.Drawing.Size(160, 28);
            this.resultB.TabIndex = 39;
            this.resultB.Text = "Click to get price";
            this.resultB.UseVisualStyleBackColor = true;
            this.resultB.Click += new System.EventHandler(this.resultB_Click_1);
            // 
            // priceResult
            // 
            this.priceResult.AutoSize = true;
            this.priceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.priceResult.Location = new System.Drawing.Point(155, 253);
            this.priceResult.Name = "priceResult";
            this.priceResult.Size = new System.Drawing.Size(84, 25);
            this.priceResult.TabIndex = 36;
            this.priceResult.Text = "______";
            this.priceResult.Click += new System.EventHandler(this.priceResult_Click_1);
            // 
            // branchL
            // 
            this.branchL.AutoSize = true;
            this.branchL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchL.Location = new System.Drawing.Point(9, 84);
            this.branchL.Name = "branchL";
            this.branchL.Size = new System.Drawing.Size(145, 20);
            this.branchL.TabIndex = 30;
            this.branchL.Text = "Branch Location:";
            // 
            // locationB
            // 
            this.locationB.FormattingEnabled = true;
            this.locationB.Items.AddRange(new object[] {
            "Edmonton",
            "Calgary",
            "RedDeer",
            "Vancouver",
            "Richmond"});
            this.locationB.Location = new System.Drawing.Point(160, 86);
            this.locationB.Name = "locationB";
            this.locationB.Size = new System.Drawing.Size(121, 21);
            this.locationB.TabIndex = 34;
            this.locationB.Text = "City";
            // 
            // startDateL
            // 
            this.startDateL.AutoSize = true;
            this.startDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.startDateL.Location = new System.Drawing.Point(20, 34);
            this.startDateL.Name = "startDateL";
            this.startDateL.Size = new System.Drawing.Size(95, 20);
            this.startDateL.TabIndex = 35;
            this.startDateL.Text = "Start date:";
            // 
            // cancelB
            // 
            this.cancelB.BackColor = System.Drawing.Color.Firebrick;
            this.cancelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(258, 320);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(107, 34);
            this.cancelB.TabIndex = 38;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = false;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click_1);
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(121, 34);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimePicker.TabIndex = 32;
            // 
            // confirmB
            // 
            this.confirmB.BackColor = System.Drawing.Color.Green;
            this.confirmB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmB.Location = new System.Drawing.Point(47, 320);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(107, 34);
            this.confirmB.TabIndex = 37;
            this.confirmB.Text = "confirm";
            this.confirmB.UseVisualStyleBackColor = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click_1);
            // 
            // endDateL
            // 
            this.endDateL.AutoSize = true;
            this.endDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endDateL.Location = new System.Drawing.Point(20, 58);
            this.endDateL.Name = "endDateL";
            this.endDateL.Size = new System.Drawing.Size(95, 20);
            this.endDateL.TabIndex = 31;
            this.endDateL.Text = "End Date: ";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 25);
            this.title.TabIndex = 29;
            this.title.Text = "Add Reservation";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(121, 60);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimePicker.TabIndex = 33;
            // 
            // addRowCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 369);
            this.Controls.Add(this.extraFeeAdmin);
            this.Controls.Add(this.ExtraFeeCustomer);
            this.Controls.Add(this.removeListB);
            this.Controls.Add(this.addListB);
            this.Controls.Add(this.extraFeeList);
            this.Controls.Add(this.resultB);
            this.Controls.Add(this.priceResult);
            this.Controls.Add(this.branchL);
            this.Controls.Add(this.locationB);
            this.Controls.Add(this.startDateL);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.endDateL);
            this.Controls.Add(this.title);
            this.Controls.Add(this.endTimePicker);
            this.Name = "addRowCustomer";
            this.Text = "addRowCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox extraFeeAdmin;
        private System.Windows.Forms.ComboBox ExtraFeeCustomer;
        private System.Windows.Forms.Button removeListB;
        private System.Windows.Forms.Button addListB;
        private System.Windows.Forms.ListBox extraFeeList;
        private System.Windows.Forms.Button resultB;
        private System.Windows.Forms.Label priceResult;
        private System.Windows.Forms.Label branchL;
        private System.Windows.Forms.ComboBox locationB;
        private System.Windows.Forms.Label startDateL;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Label endDateL;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker endTimePicker;
    }
}