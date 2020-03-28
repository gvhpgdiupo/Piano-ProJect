namespace Piano_Project
{
    partial class FormDetailKey
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
            this.DetailKey_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DetailKey_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailKey_dataGridView
            // 
            this.DetailKey_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailKey_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailKey_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.DetailKey_dataGridView.Name = "DetailKey_dataGridView";
            this.DetailKey_dataGridView.RowHeadersWidth = 51;
            this.DetailKey_dataGridView.RowTemplate.Height = 24;
            this.DetailKey_dataGridView.Size = new System.Drawing.Size(496, 484);
            this.DetailKey_dataGridView.TabIndex = 0;
            this.DetailKey_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailKey_dataGridView_CellContentClick);
            // 
            // FormDetailKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 484);
            this.Controls.Add(this.DetailKey_dataGridView);
            this.Name = "FormDetailKey";
            this.Text = "FormDetail";
            ((System.ComponentModel.ISupportInitialize)(this.DetailKey_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DetailKey_dataGridView;
    }
}