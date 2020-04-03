namespace _291CarRental
{
    partial class ProcessReturns
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
            this.processReturnsTitle = new System.Windows.Forms.Label();
            this.carData = new System.Windows.Forms.DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfVehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._291GroupProjectDataSetCar = new _291CarRental._291GroupProjectDataSetCar();
            this.carTableAdapter = new _291CarRental._291GroupProjectDataSetCarTableAdapters.CarTableAdapter();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.carSearchLabel = new System.Windows.Forms.Label();
            this.vehicleIDBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSetCar)).BeginInit();
            this.SuspendLayout();
            // 
            // processReturnsTitle
            // 
            this.processReturnsTitle.AutoSize = true;
            this.processReturnsTitle.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReturnsTitle.ForeColor = System.Drawing.Color.White;
            this.processReturnsTitle.Location = new System.Drawing.Point(270, 9);
            this.processReturnsTitle.Name = "processReturnsTitle";
            this.processReturnsTitle.Size = new System.Drawing.Size(245, 34);
            this.processReturnsTitle.TabIndex = 0;
            this.processReturnsTitle.Text = "Process Returns";
            // 
            // carData
            // 
            this.carData.AutoGenerateColumns = false;
            this.carData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeOfVehicleDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.carData.DataSource = this.carBindingSource;
            this.carData.Location = new System.Drawing.Point(12, 87);
            this.carData.Name = "carData";
            this.carData.ReadOnly = true;
            this.carData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carData.Size = new System.Drawing.Size(542, 351);
            this.carData.TabIndex = 1;
            this.carData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carData_CellClick);
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOfVehicleDataGridViewTextBoxColumn
            // 
            this.typeOfVehicleDataGridViewTextBoxColumn.DataPropertyName = "Type of Vehicle";
            this.typeOfVehicleDataGridViewTextBoxColumn.HeaderText = "Type of Vehicle";
            this.typeOfVehicleDataGridViewTextBoxColumn.Name = "typeOfVehicleDataGridViewTextBoxColumn";
            this.typeOfVehicleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this._291GroupProjectDataSetCar;
            // 
            // _291GroupProjectDataSetCar
            // 
            this._291GroupProjectDataSetCar.DataSetName = "_291GroupProjectDataSetCar";
            this._291GroupProjectDataSetCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(686, 402);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(87, 36);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(579, 402);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 36);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(560, 87);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(228, 309);
            this.infoBox.TabIndex = 4;
            this.infoBox.Text = "";
            // 
            // carSearchLabel
            // 
            this.carSearchLabel.AutoSize = true;
            this.carSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.carSearchLabel.ForeColor = System.Drawing.Color.White;
            this.carSearchLabel.Location = new System.Drawing.Point(12, 43);
            this.carSearchLabel.Name = "carSearchLabel";
            this.carSearchLabel.Size = new System.Drawing.Size(59, 15);
            this.carSearchLabel.TabIndex = 5;
            this.carSearchLabel.Text = "VehicleID";
            // 
            // vehicleIDBox
            // 
            this.vehicleIDBox.Location = new System.Drawing.Point(12, 61);
            this.vehicleIDBox.Name = "vehicleIDBox";
            this.vehicleIDBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleIDBox.TabIndex = 6;
            this.vehicleIDBox.TextChanged += new System.EventHandler(this.vehicleIDBox_TextChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(479, 58);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // ProcessReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.vehicleIDBox);
            this.Controls.Add(this.carSearchLabel);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.carData);
            this.Controls.Add(this.processReturnsTitle);
            this.Name = "ProcessReturns";
            this.Text = "ProcessRentals";
            this.Load += new System.EventHandler(this.ProcessReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSetCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processReturnsTitle;
        private System.Windows.Forms.DataGridView carData;
        private _291GroupProjectDataSetCar _291GroupProjectDataSetCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private _291GroupProjectDataSetCarTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfVehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label carSearchLabel;
        private System.Windows.Forms.TextBox vehicleIDBox;
        private System.Windows.Forms.Button filterButton;
    }
}