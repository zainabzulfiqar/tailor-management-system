namespace Win.UI
{
    partial class FormViewWorkers
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
            this.tbWorkers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWorkers
            // 
            this.tbWorkers.AllowUserToAddRows = false;
            this.tbWorkers.AllowUserToDeleteRows = false;
            this.tbWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbWorkers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbWorkers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tbWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbWorkers.Location = new System.Drawing.Point(0, 0);
            this.tbWorkers.Name = "tbWorkers";
            this.tbWorkers.ReadOnly = true;
            this.tbWorkers.Size = new System.Drawing.Size(813, 462);
            this.tbWorkers.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormViewWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbWorkers);
            this.Name = "FormViewWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS - Workers List";
            this.Load += new System.EventHandler(this.FormViewWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tbWorkers;
        private System.Windows.Forms.Button button1;
    }
}