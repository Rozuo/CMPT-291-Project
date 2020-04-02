namespace WindowsFormsApp1
{
    partial class addRow
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.confirmB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this._291GroupProjectDataSet = new WindowsFormsApp1._291GroupProjectDataSet();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new WindowsFormsApp1._291GroupProjectDataSetTableAdapters.ReservationTableAdapter();
            this._291GroupProjectDataSet1 = new _291CarRental._291GroupProjectDataSet1();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new _291CarRental._291GroupProjectDataSet1TableAdapters.CarTableAdapter();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerFName = new System.Windows.Forms.TextBox();
            this.customerL = new System.Windows.Forms.Label();
            this.locationB = new System.Windows.Forms.ComboBox();
            this.branchL = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateL = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateL = new System.Windows.Forms.Label();
            this.priceResult = new System.Windows.Forms.Label();
            this.resultB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Add Reservation";
            // 
            // confirmB
            // 
            this.confirmB.BackColor = System.Drawing.Color.Green;
            this.confirmB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmB.Location = new System.Drawing.Point(61, 376);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(107, 34);
            this.confirmB.TabIndex = 21;
            this.confirmB.Text = "confirm";
            this.confirmB.UseVisualStyleBackColor = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // cancelB
            // 
            this.cancelB.BackColor = System.Drawing.Color.Firebrick;
            this.cancelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(272, 376);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(107, 34);
            this.cancelB.TabIndex = 22;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = false;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // _291GroupProjectDataSet
            // 
            this._291GroupProjectDataSet.DataSetName = "_291GroupProjectDataSet";
            this._291GroupProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this._291GroupProjectDataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // _291GroupProjectDataSet1
            // 
            this._291GroupProjectDataSet1.DataSetName = "_291GroupProjectDataSet1";
            this._291GroupProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this._291GroupProjectDataSet1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // customerFName
            // 
            this.customerFName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.customerFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerFName.Location = new System.Drawing.Point(152, 49);
            this.customerFName.Name = "customerFName";
            this.customerFName.Size = new System.Drawing.Size(121, 26);
            this.customerFName.TabIndex = 12;
            this.customerFName.Text = "First Name";
            this.customerFName.TextChanged += new System.EventHandler(this.customerFName_TextChanged);
            // 
            // customerL
            // 
            this.customerL.AutoSize = true;
            this.customerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerL.Location = new System.Drawing.Point(18, 52);
            this.customerL.Name = "customerL";
            this.customerL.Size = new System.Drawing.Size(128, 20);
            this.customerL.TabIndex = 5;
            this.customerL.Text = "Customer Info:";
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
            this.locationB.Location = new System.Drawing.Point(163, 176);
            this.locationB.Name = "locationB";
            this.locationB.Size = new System.Drawing.Size(121, 21);
            this.locationB.TabIndex = 17;
            this.locationB.Text = "City";
            // 
            // branchL
            // 
            this.branchL.AutoSize = true;
            this.branchL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchL.Location = new System.Drawing.Point(12, 174);
            this.branchL.Name = "branchL";
            this.branchL.Size = new System.Drawing.Size(145, 20);
            this.branchL.TabIndex = 13;
            this.branchL.Text = "Branch Location:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(124, 116);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimePicker.TabIndex = 16;
            // 
            // endDateL
            // 
            this.endDateL.AutoSize = true;
            this.endDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endDateL.Location = new System.Drawing.Point(23, 114);
            this.endDateL.Name = "endDateL";
            this.endDateL.Size = new System.Drawing.Size(95, 20);
            this.endDateL.TabIndex = 14;
            this.endDateL.Text = "End Date: ";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(124, 90);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimePicker.TabIndex = 15;
            // 
            // startDateL
            // 
            this.startDateL.AutoSize = true;
            this.startDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.startDateL.Location = new System.Drawing.Point(23, 90);
            this.startDateL.Name = "startDateL";
            this.startDateL.Size = new System.Drawing.Size(95, 20);
            this.startDateL.TabIndex = 18;
            this.startDateL.Text = "Start date:";
            // 
            // priceResult
            // 
            this.priceResult.AutoSize = true;
            this.priceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.priceResult.Location = new System.Drawing.Point(119, 287);
            this.priceResult.Name = "priceResult";
            this.priceResult.Size = new System.Drawing.Size(0, 25);
            this.priceResult.TabIndex = 19;
            this.priceResult.Click += new System.EventHandler(this.priceResult_Click);
            // 
            // resultB
            // 
            this.resultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultB.Location = new System.Drawing.Point(124, 226);
            this.resultB.Name = "resultB";
            this.resultB.Size = new System.Drawing.Size(160, 28);
            this.resultB.TabIndex = 23;
            this.resultB.Text = "Click to get price";
            this.resultB.UseVisualStyleBackColor = true;
            this.resultB.Click += new System.EventHandler(this.resultB_Click);
            // 
            // addRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 422);
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
            this.Controls.Add(this.customerFName);
            this.Controls.Add(this.customerL);
            this.Name = "addRow";
            this.Text = "addRow";
            this.Load += new System.EventHandler(this.addRow_Load);
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button cancelB;
        private _291GroupProjectDataSet _291GroupProjectDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private _291GroupProjectDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private _291CarRental._291GroupProjectDataSet1 _291GroupProjectDataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private _291CarRental. _291GroupProjectDataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.TextBox customerFName;
        private System.Windows.Forms.Label customerL;
        private System.Windows.Forms.ComboBox locationB;
        private System.Windows.Forms.Label branchL;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label endDateL;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label startDateL;
        private System.Windows.Forms.Label priceResult;
        private System.Windows.Forms.Button resultB;
    }
}