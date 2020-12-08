namespace Win.UI
{
    partial class FormPendingOrders
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
            this.tableOrders = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOrders
            // 
            this.tableOrders.AllowUserToAddRows = false;
            this.tableOrders.AllowUserToDeleteRows = false;
            this.tableOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableOrders.Location = new System.Drawing.Point(0, 0);
            this.tableOrders.Name = "tableOrders";
            this.tableOrders.ReadOnly = true;
            this.tableOrders.Size = new System.Drawing.Size(831, 461);
            this.tableOrders.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPendingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableOrders);
            this.MaximizeBox = false;
            this.Name = "FormPendingOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPendingOrders";
            this.Load += new System.EventHandler(this.FormPendingOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableOrders;
        private System.Windows.Forms.Button button1;
    }
}