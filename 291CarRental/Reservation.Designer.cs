namespace WindowsFormsApp1
{
    partial class Reservation
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._291GroupProjectDataSet = new WindowsFormsApp1._291GroupProjectDataSet();
            this.calendarPage = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRow = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRow = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationTableAdapter = new WindowsFormsApp1._291GroupProjectDataSetTableAdapters.ReservationTableAdapter();
            this._291GroupProjectDataSet1 = new WindowsFormsApp1._291GroupProjectDataSet();
            this._291GroupProjectDataSet2 = new WindowsFormsApp1._291GroupProjectDataSet();
            this.ReservationGrid = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(267, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(252, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Reservations";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.dataPage);
            this.tabControl.Controls.Add(this.calendarPage);
            this.tabControl.Location = new System.Drawing.Point(12, 102);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 336);
            this.tabControl.TabIndex = 2;
            // 
            // dataPage
            // 
            this.dataPage.Controls.Add(this.ReservationGrid);
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(768, 310);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Forms";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this._291GroupProjectDataSet;
            // 
            // _291GroupProjectDataSet
            // 
            this._291GroupProjectDataSet.DataSetName = "_291GroupProjectDataSet";
            this._291GroupProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarPage
            // 
            this.calendarPage.Location = new System.Drawing.Point(4, 22);
            this.calendarPage.Name = "calendarPage";
            this.calendarPage.Padding = new System.Windows.Forms.Padding(3);
            this.calendarPage.Size = new System.Drawing.Size(768, 310);
            this.calendarPage.TabIndex = 1;
            this.calendarPage.Text = "Calendar";
            this.calendarPage.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(688, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(77, 30);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButton1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.White;
            this.menuButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRow,
            this.removeRow});
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(54, 20);
            this.menuButton1.Text = "Action";
            // 
            // addRow
            // 
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(181, 22);
            this.addRow.Text = "New Reservation";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // removeRow
            // 
            this.removeRow.Name = "removeRow";
            this.removeRow.Size = new System.Drawing.Size(181, 22);
            this.removeRow.Text = "Remove Reservation";
            this.removeRow.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // _291GroupProjectDataSet1
            // 
            this._291GroupProjectDataSet1.DataSetName = "_291GroupProjectDataSet";
            this._291GroupProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _291GroupProjectDataSet2
            // 
            this._291GroupProjectDataSet2.DataSetName = "_291GroupProjectDataSet";
            this._291GroupProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReservationGrid
            // 
            this.ReservationGrid.AutoGenerateColumns = false;
            this.ReservationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.ReservationGrid.DataSource = this.reservationBindingSource;
            this.ReservationGrid.Location = new System.Drawing.Point(0, 0);
            this.ReservationGrid.Name = "ReservationGrid";
            this.ReservationGrid.Size = new System.Drawing.Size(768, 310);
            this.ReservationGrid.TabIndex = 0;
            this.ReservationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGrid_CellContentClick);
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "End date";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.tabControl.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private _291GroupProjectDataSet _291GroupProjectDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private _291GroupProjectDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private _291GroupProjectDataSet _291GroupProjectDataSet1;
        private _291GroupProjectDataSet _291GroupProjectDataSet2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.TabPage calendarPage;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuButton1;
        private System.Windows.Forms.ToolStripMenuItem addRow;
        private System.Windows.Forms.ToolStripMenuItem removeRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ReservationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}