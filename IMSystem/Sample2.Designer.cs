
namespace IMSystem
{
    partial class Sample2
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
            this.BtnsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchSampleTwo = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.BtnsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.BtnsPanel);
            this.rightPanel.Size = new System.Drawing.Size(841, 450);
            this.rightPanel.Controls.SetChildIndex(this.panel4, 0);
            this.rightPanel.Controls.SetChildIndex(this.BtnsPanel, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(841, 63);
            // 
            // BtnsPanel
            // 
            this.BtnsPanel.Controls.Add(this.groupBox1);
            this.BtnsPanel.Controls.Add(this.delBtn);
            this.BtnsPanel.Controls.Add(this.saveBtn);
            this.BtnsPanel.Controls.Add(this.editBtn);
            this.BtnsPanel.Controls.Add(this.addBtn);
            this.BtnsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnsPanel.Location = new System.Drawing.Point(0, 63);
            this.BtnsPanel.Name = "BtnsPanel";
            this.BtnsPanel.Size = new System.Drawing.Size(841, 51);
            this.BtnsPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearchSampleTwo);
            this.groupBox1.Location = new System.Drawing.Point(580, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBoxSearchSampleTwo
            // 
            this.textBoxSearchSampleTwo.Location = new System.Drawing.Point(15, 15);
            this.textBoxSearchSampleTwo.MaxLength = 100;
            this.textBoxSearchSampleTwo.Name = "textBoxSearchSampleTwo";
            this.textBoxSearchSampleTwo.Size = new System.Drawing.Size(207, 23);
            this.textBoxSearchSampleTwo.TabIndex = 0;
            this.textBoxSearchSampleTwo.TextChanged += new System.EventHandler(this.textBoxSearchSampleTwo_TextChanged);
            // 
            // delBtn
            // 
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.Location = new System.Drawing.Point(437, 0);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(137, 51);
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(294, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 51);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Location = new System.Drawing.Point(151, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(137, 51);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(8, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 51);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(54, 29);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Name = "Sample2";
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.BtnsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BtnsPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearchSampleTwo;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
    }
}