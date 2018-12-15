namespace CakeCRM.View
{
    partial class ListByStatusForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salesComboBox = new System.Windows.Forms.ComboBox();
            this.saleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salesListTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatusBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salesComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус";
            // 
            // salesComboBox
            // 
            this.salesComboBox.DataSource = this.saleStatusBindingSource;
            this.salesComboBox.DisplayMember = "Title";
            this.salesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salesComboBox.FormattingEnabled = true;
            this.salesComboBox.Location = new System.Drawing.Point(6, 19);
            this.salesComboBox.Name = "salesComboBox";
            this.salesComboBox.Size = new System.Drawing.Size(260, 21);
            this.salesComboBox.TabIndex = 2;
            // 
            // saleStatusBindingSource
            // 
            this.saleStatusBindingSource.DataSource = typeof(CakeCRM.Model.SaleStatus);
            this.saleStatusBindingSource.CurrentItemChanged += new System.EventHandler(this.saleStatusBindingSource_CurrentItemChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.salesListTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список";
            // 
            // salesListTextBox
            // 
            this.salesListTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesListTextBox.Location = new System.Drawing.Point(3, 16);
            this.salesListTextBox.Multiline = true;
            this.salesListTextBox.Name = "salesListTextBox";
            this.salesListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.salesListTextBox.Size = new System.Drawing.Size(266, 262);
            this.salesListTextBox.TabIndex = 0;
            // 
            // ListByStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(307, 388);
            this.Name = "ListByStatusForm";
            this.Text = "Список по статусу";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleStatusBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox salesComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox salesListTextBox;
        private System.Windows.Forms.BindingSource saleStatusBindingSource;
    }
}