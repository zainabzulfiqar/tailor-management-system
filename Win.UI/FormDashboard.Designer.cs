namespace Win.UI
{
    partial class FormDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewWorkers = new System.Windows.Forms.Button();
            this.btnAssignWork = new System.Windows.Forms.Button();
            this.btnPendingOrders = new System.Windows.Forms.Button();
            this.btnAssignedOrders = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWorkerToolStripMenuItem,
            this.createProductToolStripMenuItem,
            this.assignWorkToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createWorkerToolStripMenuItem
            // 
            this.createWorkerToolStripMenuItem.Name = "createWorkerToolStripMenuItem";
            this.createWorkerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createWorkerToolStripMenuItem.Text = "Create Worker";
            this.createWorkerToolStripMenuItem.Click += new System.EventHandler(this.createWorkerToolStripMenuItem_Click);
            // 
            // createProductToolStripMenuItem
            // 
            this.createProductToolStripMenuItem.Name = "createProductToolStripMenuItem";
            this.createProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createProductToolStripMenuItem.Text = "Create Product";
            this.createProductToolStripMenuItem.Click += new System.EventHandler(this.createProductToolStripMenuItem_Click);
            // 
            // assignWorkToolStripMenuItem
            // 
            this.assignWorkToolStripMenuItem.Name = "assignWorkToolStripMenuItem";
            this.assignWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignWorkToolStripMenuItem.Text = "Assign Work";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workersToolStripMenuItem.Text = "Workers";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.workerToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workerToolStripMenuItem.Text = "Worker";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(880, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Out";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tailor Management System";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(414, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 52);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewWorkers
            // 
            this.btnViewWorkers.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewWorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWorkers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewWorkers.Image = global::Win.UI.Properties.Resources.view_80px;
            this.btnViewWorkers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewWorkers.Location = new System.Drawing.Point(611, 313);
            this.btnViewWorkers.Name = "btnViewWorkers";
            this.btnViewWorkers.Padding = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.btnViewWorkers.Size = new System.Drawing.Size(224, 122);
            this.btnViewWorkers.TabIndex = 6;
            this.btnViewWorkers.Text = "View Workers";
            this.btnViewWorkers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewWorkers.UseVisualStyleBackColor = false;
            this.btnViewWorkers.Click += new System.EventHandler(this.btnViewWorkers_Click);
            // 
            // btnAssignWork
            // 
            this.btnAssignWork.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssignWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignWork.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAssignWork.Image = global::Win.UI.Properties.Resources.audit_80px;
            this.btnAssignWork.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssignWork.Location = new System.Drawing.Point(611, 170);
            this.btnAssignWork.Name = "btnAssignWork";
            this.btnAssignWork.Padding = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.btnAssignWork.Size = new System.Drawing.Size(224, 122);
            this.btnAssignWork.TabIndex = 3;
            this.btnAssignWork.Text = "Assign to Worker";
            this.btnAssignWork.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssignWork.UseVisualStyleBackColor = false;
            // 
            // btnPendingOrders
            // 
            this.btnPendingOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnPendingOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingOrders.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPendingOrders.Image = global::Win.UI.Properties.Resources.time_80px;
            this.btnPendingOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPendingOrders.Location = new System.Drawing.Point(365, 313);
            this.btnPendingOrders.Name = "btnPendingOrders";
            this.btnPendingOrders.Padding = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.btnPendingOrders.Size = new System.Drawing.Size(224, 122);
            this.btnPendingOrders.TabIndex = 5;
            this.btnPendingOrders.Text = "Pending Orders";
            this.btnPendingOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPendingOrders.UseVisualStyleBackColor = false;
            this.btnPendingOrders.Click += new System.EventHandler(this.btnPendingOrders_Click);
            // 
            // btnAssignedOrders
            // 
            this.btnAssignedOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssignedOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignedOrders.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAssignedOrders.Image = global::Win.UI.Properties.Resources.checked_80px;
            this.btnAssignedOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssignedOrders.Location = new System.Drawing.Point(121, 170);
            this.btnAssignedOrders.Name = "btnAssignedOrders";
            this.btnAssignedOrders.Padding = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.btnAssignedOrders.Size = new System.Drawing.Size(224, 122);
            this.btnAssignedOrders.TabIndex = 4;
            this.btnAssignedOrders.Text = "Assigned Orders";
            this.btnAssignedOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssignedOrders.UseVisualStyleBackColor = false;
            this.btnAssignedOrders.Click += new System.EventHandler(this.btnAssignedOrders_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreateProduct.Image = global::Win.UI.Properties.Resources.create_80px;
            this.btnCreateProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateProduct.Location = new System.Drawing.Point(365, 170);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Padding = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.btnCreateProduct.Size = new System.Drawing.Size(224, 122);
            this.btnCreateProduct.TabIndex = 2;
            this.btnCreateProduct.Text = "New Product";
            this.btnCreateProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 617);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnViewWorkers);
            this.Controls.Add(this.btnAssignWork);
            this.Controls.Add(this.btnPendingOrders);
            this.Controls.Add(this.btnAssignedOrders);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS - Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAssignWork;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Button btnAssignedOrders;
        private System.Windows.Forms.Button btnPendingOrders;
        private System.Windows.Forms.Button btnViewWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}