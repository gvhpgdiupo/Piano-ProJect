namespace Piano_Project
{
    partial class InsertForm
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
            this.ShowDetail_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Path_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.INSERTKEY_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowDetail_button
            // 
            this.ShowDetail_button.BackColor = System.Drawing.Color.White;
            this.ShowDetail_button.Location = new System.Drawing.Point(326, 319);
            this.ShowDetail_button.Name = "ShowDetail_button";
            this.ShowDetail_button.Size = new System.Drawing.Size(212, 53);
            this.ShowDetail_button.TabIndex = 14;
            this.ShowDetail_button.Text = "SHOW DETAIL KEY";
            this.ShowDetail_button.UseVisualStyleBackColor = false;
            this.ShowDetail_button.Click += new System.EventHandler(this.ShowDetail_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "MusicKey";
            // 
            // Path_textBox
            // 
            this.Path_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Path_textBox.Location = new System.Drawing.Point(279, 219);
            this.Path_textBox.Name = "Path_textBox";
            this.Path_textBox.Size = new System.Drawing.Size(194, 30);
            this.Path_textBox.TabIndex = 11;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name_textBox.Location = new System.Drawing.Point(279, 135);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 30);
            this.Name_textBox.TabIndex = 10;
            // 
            // INSERTKEY_button
            // 
            this.INSERTKEY_button.BackColor = System.Drawing.Color.White;
            this.INSERTKEY_button.Location = new System.Drawing.Point(46, 319);
            this.INSERTKEY_button.Name = "INSERTKEY_button";
            this.INSERTKEY_button.Size = new System.Drawing.Size(212, 53);
            this.INSERTKEY_button.TabIndex = 9;
            this.INSERTKEY_button.Text = "INSERT KEY";
            this.INSERTKEY_button.UseVisualStyleBackColor = false;
            this.INSERTKEY_button.Click += new System.EventHandler(this.INSERTKEY_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "INSERT PATH MUSIC KEY";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowDetail_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.INSERTKEY_button);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertForm_FormClosing);
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowDetail_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button INSERTKEY_button;
        private System.Windows.Forms.Label label3;
    }
}