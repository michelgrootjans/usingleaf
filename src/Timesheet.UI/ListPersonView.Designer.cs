namespace Timesheet.UI
{
    partial class ListPersonView
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
            this.personList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.personList)).BeginInit();
            this.SuspendLayout();
            // 
            // personList
            // 
            this.personList.AllowUserToAddRows = false;
            this.personList.AllowUserToDeleteRows = false;
            this.personList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.personList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personList.Location = new System.Drawing.Point(12, 12);
            this.personList.Name = "personList";
            this.personList.ReadOnly = true;
            this.personList.Size = new System.Drawing.Size(1061, 329);
            this.personList.TabIndex = 0;
            this.personList.DoubleClick += new System.EventHandler(this.personList_DoubleClick);
            // 
            // ListPersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 353);
            this.Controls.Add(this.personList);
            this.Name = "ListPersonView";
            this.Text = "ListPersonView";
            this.Load += new System.EventHandler(this.ListPersonView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personList;
    }
}

