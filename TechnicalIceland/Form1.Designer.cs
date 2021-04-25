
namespace WinFormsApp
{
    partial class Form1
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.itemDropdown = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblSellIn = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.tbSellIn = new System.Windows.Forms.NumericUpDown();
            this.tbQty = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.gvItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbSellIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 29);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(140, 35);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // itemDropdown
            // 
            this.itemDropdown.FormattingEnabled = true;
            this.itemDropdown.Location = new System.Drawing.Point(257, 29);
            this.itemDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemDropdown.Name = "itemDropdown";
            this.itemDropdown.Size = new System.Drawing.Size(185, 21);
            this.itemDropdown.TabIndex = 1;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItem.Location = new System.Drawing.Point(166, 29);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(89, 21);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Select Item:";
            // 
            // lblSellIn
            // 
            this.lblSellIn.AutoSize = true;
            this.lblSellIn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSellIn.Location = new System.Drawing.Point(165, 55);
            this.lblSellIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellIn.Name = "lblSellIn";
            this.lblSellIn.Size = new System.Drawing.Size(101, 21);
            this.lblSellIn.TabIndex = 3;
            this.lblSellIn.Text = "Sell In (days):";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQty.Location = new System.Drawing.Point(350, 54);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(73, 21);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Quantity:";
            // 
            // tbSellIn
            // 
            this.tbSellIn.Location = new System.Drawing.Point(257, 55);
            this.tbSellIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSellIn.Name = "tbSellIn";
            this.tbSellIn.Size = new System.Drawing.Size(58, 20);
            this.tbSellIn.TabIndex = 8;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(416, 55);
            this.tbQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(58, 20);
            this.tbQty.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvItems);
            this.groupBox1.Location = new System.Drawing.Point(26, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(364, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Added Items:";
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(443, 122);
            this.btnNextDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(177, 54);
            this.btnNextDay.TabIndex = 11;
            this.btnNextDay.Text = "Next Day";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // gvItems
            // 
            this.gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItems.Location = new System.Drawing.Point(5, 18);
            this.gvItems.Margin = new System.Windows.Forms.Padding(1);
            this.gvItems.Name = "gvItems";
            this.gvItems.Size = new System.Drawing.Size(355, 240);
            this.gvItems.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 445);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.tbSellIn);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblSellIn);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.itemDropdown);
            this.Controls.Add(this.btnAddItem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSellIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox itemDropdown;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblSellIn;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown tbSellIn;
        private System.Windows.Forms.NumericUpDown tbQty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.DataGridView gvItems;
    }
}