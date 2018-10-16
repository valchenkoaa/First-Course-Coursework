﻿namespace Home_Bookkeeper
{
    partial class AccountForm
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
            this.AccountNameInput = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Location = new System.Drawing.Point(26, 16);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(60, 13);
            this.AccountName.TabIndex = 0;
            this.AccountName.Text = "Имя счёта";
            // 
            // AccountBalance
            // 
            this.AccountBalance.AutoSize = true;
            this.AccountBalance.Location = new System.Drawing.Point(26, 42);
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(44, 13);
            this.AccountBalance.TabIndex = 1;
            this.AccountBalance.Text = "Баланс";
            // 
            // WholePartInput
            // 
            this.WholePartInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.WholePartInput.Location = new System.Drawing.Point(114, 39);
            this.WholePartInput.Margin = new System.Windows.Forms.Padding(0);
            this.WholePartInput.Name = "WholePartInput";
            this.WholePartInput.Size = new System.Drawing.Size(72, 20);
            this.WholePartInput.TabIndex = 3;
            this.WholePartInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WholePartInput_KeyPress);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Location = new System.Drawing.Point(186, 46);
            this.Point.Margin = new System.Windows.Forms.Padding(0);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(10, 13);
            this.Point.TabIndex = 4;
            this.Point.Text = ",";
            this.Point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecimalPartInput
            // 
            this.DecimalPartInput.Location = new System.Drawing.Point(196, 39);
            this.DecimalPartInput.Margin = new System.Windows.Forms.Padding(0);
            this.DecimalPartInput.MaxLength = 2;
            this.DecimalPartInput.Name = "DecimalPartInput";
            this.DecimalPartInput.Size = new System.Drawing.Size(26, 20);
            this.DecimalPartInput.TabIndex = 5;
            this.DecimalPartInput.Text = "00";
            this.DecimalPartInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalPartInput_KeyPress);
            // 
            // Ok
            // 
            this.Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ok.Location = new System.Drawing.Point(147, 71);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "Ввод";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(29, 71);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AccountNameInput
            // 
            this.AccountNameInput.DataSource = this.accountsBindingSource;
            this.AccountNameInput.DisplayMember = "Name";
            this.AccountNameInput.FormattingEnabled = true;
            this.AccountNameInput.Location = new System.Drawing.Point(114, 13);
            this.AccountNameInput.Name = "AccountNameInput";
            this.AccountNameInput.Size = new System.Drawing.Size(108, 21);
            this.AccountNameInput.TabIndex = 2;
            this.AccountNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountNameInput_KeyPress);
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
            // AccountForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(250, 106);
            this.ControlBox = false;
            this.Controls.Add(this.AccountNameInput);
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
            this.Name = "AccountForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа со счетами";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox AccountNameInput;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource personalAccountBindingSource;
    }
}