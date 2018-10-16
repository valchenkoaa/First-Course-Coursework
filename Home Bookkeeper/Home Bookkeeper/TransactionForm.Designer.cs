namespace Home_Bookkeeper
{
    partial class TransactionForm
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
            this.AccountName = new System.Windows.Forms.Label();
            this.AccountBalance = new System.Windows.Forms.Label();
            this.WholePartInput = new System.Windows.Forms.TextBox();
            this.Point = new System.Windows.Forms.Label();
            this.DecimalPartInput = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomeOrExtense = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryNameInput = new System.Windows.Forms.ComboBox();
            this.AccountNameInput = new System.Windows.Forms.ComboBox();
            this.ArticleNameInput = new System.Windows.Forms.ComboBox();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Location = new System.Drawing.Point(22, 47);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(30, 13);
            this.AccountName.TabIndex = 10;
            this.AccountName.Text = "Счёт";
            // 
            // AccountBalance
            // 
            this.AccountBalance.AutoSize = true;
            this.AccountBalance.Location = new System.Drawing.Point(22, 69);
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(41, 13);
            this.AccountBalance.TabIndex = 9;
            this.AccountBalance.Text = "Сумма";
            // 
            // WholePartInput
            // 
            this.WholePartInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.WholePartInput.Location = new System.Drawing.Point(99, 67);
            this.WholePartInput.Margin = new System.Windows.Forms.Padding(0);
            this.WholePartInput.Name = "WholePartInput";
            this.WholePartInput.Size = new System.Drawing.Size(85, 20);
            this.WholePartInput.TabIndex = 2;
            this.WholePartInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WholePartInput_KeyPress);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Location = new System.Drawing.Point(184, 74);
            this.Point.Margin = new System.Windows.Forms.Padding(0);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(10, 13);
            this.Point.TabIndex = 12;
            this.Point.Text = ",";
            this.Point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecimalPartInput
            // 
            this.DecimalPartInput.Location = new System.Drawing.Point(194, 67);
            this.DecimalPartInput.Margin = new System.Windows.Forms.Padding(0);
            this.DecimalPartInput.MaxLength = 2;
            this.DecimalPartInput.Name = "DecimalPartInput";
            this.DecimalPartInput.Size = new System.Drawing.Size(26, 20);
            this.DecimalPartInput.TabIndex = 3;
            this.DecimalPartInput.Text = "00";
            this.DecimalPartInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalPartInput_KeyPress);
            // 
            // Ok
            // 
            this.Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ok.Location = new System.Drawing.Point(145, 175);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 14;
            this.Ok.Text = "Ввод";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(25, 175);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Статья";
            // 
            // IncomeOrExtense
            // 
            this.IncomeOrExtense.FormattingEnabled = true;
            this.IncomeOrExtense.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.IncomeOrExtense.Location = new System.Drawing.Point(99, 17);
            this.IncomeOrExtense.Name = "IncomeOrExtense";
            this.IncomeOrExtense.Size = new System.Drawing.Size(121, 21);
            this.IncomeOrExtense.TabIndex = 0;
            this.IncomeOrExtense.Text = "Расход";
            this.IncomeOrExtense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncomeOrExtense_KeyPress);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(22, 20);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(26, 13);
            this.Type.TabIndex = 11;
            this.Type.Text = "Вид";
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(25, 140);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(195, 20);
            this.Date.TabIndex = 6;
            this.Date.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.personalAccountBindingSource;
            // 
            // personalAccountBindingSource
            // 
            this.personalAccountBindingSource.DataSource = typeof(Home_Bookkeeper.Wallet.PersonalAccount);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.personalAccountBindingSource;
            // 
            // CategoryNameInput
            // 
            this.CategoryNameInput.DataSource = this.categoriesBindingSource;
            this.CategoryNameInput.DisplayMember = "Name";
            this.CategoryNameInput.FormattingEnabled = true;
            this.CategoryNameInput.Location = new System.Drawing.Point(99, 90);
            this.CategoryNameInput.Name = "CategoryNameInput";
            this.CategoryNameInput.Size = new System.Drawing.Size(121, 21);
            this.CategoryNameInput.TabIndex = 4;
            this.CategoryNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryNameInput_KeyPress);
            // 
            // AccountNameInput
            // 
            this.AccountNameInput.DataSource = this.accountsBindingSource;
            this.AccountNameInput.DisplayMember = "Name";
            this.AccountNameInput.FormattingEnabled = true;
            this.AccountNameInput.Location = new System.Drawing.Point(99, 43);
            this.AccountNameInput.Name = "AccountNameInput";
            this.AccountNameInput.Size = new System.Drawing.Size(121, 21);
            this.AccountNameInput.TabIndex = 1;
            this.AccountNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountNameInput_KeyPress);
            // 
            // ArticleNameInput
            // 
            this.ArticleNameInput.DataSource = this.transactionsBindingSource;
            this.ArticleNameInput.DisplayMember = "Article";
            this.ArticleNameInput.FormattingEnabled = true;
            this.ArticleNameInput.Location = new System.Drawing.Point(99, 114);
            this.ArticleNameInput.Name = "ArticleNameInput";
            this.ArticleNameInput.Size = new System.Drawing.Size(121, 21);
            this.ArticleNameInput.TabIndex = 5;
            this.ArticleNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArticleNameInput_KeyPress);
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.personalAccountBindingSource;
            // 
            // TransactionForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(234, 213);
            this.ControlBox = false;
            this.Controls.Add(this.ArticleNameInput);
            this.Controls.Add(this.CategoryNameInput);
            this.Controls.Add(this.AccountNameInput);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.IncomeOrExtense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.DecimalPartInput);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.WholePartInput);
            this.Controls.Add(this.AccountBalance);
            this.Controls.Add(this.AccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа с транзакциями";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountName;
        private System.Windows.Forms.Label AccountBalance;
        private System.Windows.Forms.TextBox WholePartInput;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.TextBox DecimalPartInput;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox IncomeOrExtense;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource personalAccountBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.ComboBox CategoryNameInput;
        private System.Windows.Forms.ComboBox AccountNameInput;
        private System.Windows.Forms.ComboBox ArticleNameInput;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
    }
}