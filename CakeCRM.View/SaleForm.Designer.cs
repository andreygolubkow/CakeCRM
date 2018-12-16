namespace CakeCRM.View
{
    partial class SaleForm
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
            this.sellCountGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellCountPairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.removePairButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewPairButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellVariantComboBox = new System.Windows.Forms.ComboBox();
            this.sellVariantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveSellButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.saleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellCountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellCountPairBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellVariantBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sellCountGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары";
            // 
            // sellCountGridView
            // 
            this.sellCountGridView.AllowUserToAddRows = false;
            this.sellCountGridView.AllowUserToDeleteRows = false;
            this.sellCountGridView.AllowUserToResizeRows = false;
            this.sellCountGridView.AutoGenerateColumns = false;
            this.sellCountGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellCountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellCountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.variantDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.sellCountGridView.DataSource = this.sellCountPairBindingSource;
            this.sellCountGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellCountGridView.Location = new System.Drawing.Point(3, 16);
            this.sellCountGridView.MultiSelect = false;
            this.sellCountGridView.Name = "sellCountGridView";
            this.sellCountGridView.ReadOnly = true;
            this.sellCountGridView.RowHeadersVisible = false;
            this.sellCountGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellCountGridView.Size = new System.Drawing.Size(333, 225);
            this.sellCountGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 30.45686F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // variantDataGridViewTextBoxColumn
            // 
            this.variantDataGridViewTextBoxColumn.DataPropertyName = "Variant";
            this.variantDataGridViewTextBoxColumn.FillWeight = 214.8136F;
            this.variantDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.variantDataGridViewTextBoxColumn.Name = "variantDataGridViewTextBoxColumn";
            this.variantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.FillWeight = 54.72957F;
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellCountPairBindingSource
            // 
            this.sellCountPairBindingSource.DataSource = typeof(CakeCRM.Model.SellCountPair);
            this.sellCountPairBindingSource.CurrentChanged += new System.EventHandler(this.sellCountPairBindingSource_CurrentChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentLabel);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.addClientButton);
            this.groupBox2.Location = new System.Drawing.Point(359, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиент";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Comment", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-"));
            this.commentLabel.Location = new System.Drawing.Point(6, 52);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(10, 13);
            this.commentLabel.TabIndex = 7;
            this.commentLabel.Text = "-";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CakeCRM.Model.Client);
            this.clientBindingSource.Sort = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(77, 74);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(154, 23);
            this.addClientButton.TabIndex = 6;
            this.addClientButton.Text = "Редактирование клиентов";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deliveryComboBox);
            this.groupBox3.Location = new System.Drawing.Point(357, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Доставка";
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.DataSource = this.deliveryBindingSource;
            this.deliveryComboBox.DisplayMember = "Name";
            this.deliveryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Location = new System.Drawing.Point(6, 19);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(190, 21);
            this.deliveryComboBox.TabIndex = 0;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(CakeCRM.Model.Delivery);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.removePairButton);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.addNewPairButton);
            this.groupBox4.Controls.Add(this.saveButton);
            this.groupBox4.Controls.Add(this.countTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.sellVariantComboBox);
            this.groupBox4.Location = new System.Drawing.Point(15, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 79);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактировать позицию";
            // 
            // removePairButton
            // 
            this.removePairButton.Location = new System.Drawing.Point(553, 47);
            this.removePairButton.Name = "removePairButton";
            this.removePairButton.Size = new System.Drawing.Size(21, 23);
            this.removePairButton.TabIndex = 6;
            this.removePairButton.Text = "X";
            this.removePairButton.UseVisualStyleBackColor = true;
            this.removePairButton.Click += new System.EventHandler(this.removePairButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "шт. ";
            // 
            // addNewPairButton
            // 
            this.addNewPairButton.Location = new System.Drawing.Point(311, 47);
            this.addNewPairButton.Name = "addNewPairButton";
            this.addNewPairButton.Size = new System.Drawing.Size(133, 23);
            this.addNewPairButton.TabIndex = 5;
            this.addNewPairButton.Text = "Сохранить как новый";
            this.addNewPairButton.UseVisualStyleBackColor = true;
            this.addNewPairButton.Click += new System.EventHandler(this.addNewPairButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(472, 47);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(78, 49);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 20);
            this.countTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Количество";
            // 
            // sellVariantComboBox
            // 
            this.sellVariantComboBox.DataSource = this.sellVariantBindingSource;
            this.sellVariantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellVariantComboBox.FormattingEnabled = true;
            this.sellVariantComboBox.Location = new System.Drawing.Point(9, 18);
            this.sellVariantComboBox.Name = "sellVariantComboBox";
            this.sellVariantComboBox.Size = new System.Drawing.Size(565, 21);
            this.sellVariantComboBox.TabIndex = 0;
            // 
            // sellVariantBindingSource
            // 
            this.sellVariantBindingSource.DataSource = typeof(CakeCRM.Model.SellVariant);
            this.sellVariantBindingSource.Sort = "Name";
            // 
            // saveSellButton
            // 
            this.saveSellButton.Location = new System.Drawing.Point(484, 353);
            this.saveSellButton.Name = "saveSellButton";
            this.saveSellButton.Size = new System.Drawing.Size(111, 23);
            this.saveSellButton.TabIndex = 4;
            this.saveSellButton.Text = "Сохранить заказ";
            this.saveSellButton.UseVisualStyleBackColor = true;
            this.saveSellButton.Click += new System.EventHandler(this.saveSellButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.statusComboBox);
            this.groupBox6.Location = new System.Drawing.Point(357, 182);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(236, 51);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataSource = this.saleStatusBindingSource;
            this.statusComboBox.DisplayMember = "Title";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(6, 19);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(219, 21);
            this.statusComboBox.TabIndex = 0;
            // 
            // saleStatusBindingSource
            // 
            this.saleStatusBindingSource.DataSource = typeof(CakeCRM.Model.SaleStatus);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(362, 240);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(61, 13);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "                  ";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(403, 353);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 10;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Visible = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 385);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.saveSellButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 424);
            this.Name = "SaleForm";
            this.Text = "Заказ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellCountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellCountPairBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellVariantBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveSellButton;
        private System.Windows.Forms.ComboBox deliveryComboBox;
        private System.Windows.Forms.DataGridView sellCountGridView;
        private System.Windows.Forms.BindingSource sellCountPairBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sellVariantComboBox;
        private System.Windows.Forms.Button removePairButton;
        private System.Windows.Forms.Button addNewPairButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.BindingSource sellVariantBindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.BindingSource saleStatusBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}