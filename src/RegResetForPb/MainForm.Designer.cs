namespace RegResetForPb
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "aaa",
            "test"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "test2",
            "bbb",
            "test2"}, -1);
            this.regListView = new System.Windows.Forms.ListView();
            this.RegNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.regDeleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.versionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // regListView
            // 
            this.regListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RegNameColumnHeader,
            this.PathColumnHeader});
            this.regListView.FullRowSelect = true;
            this.regListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.regListView.Location = new System.Drawing.Point(12, 73);
            this.regListView.Name = "regListView";
            this.regListView.Size = new System.Drawing.Size(824, 168);
            this.regListView.TabIndex = 20;
            this.regListView.UseCompatibleStateImageBehavior = false;
            this.regListView.View = System.Windows.Forms.View.Details;
            // 
            // RegNameColumnHeader
            // 
            this.RegNameColumnHeader.Text = "キー名";
            this.RegNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegNameColumnHeader.Width = 400;
            // 
            // PathColumnHeader
            // 
            this.PathColumnHeader.Text = "パス";
            this.PathColumnHeader.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Controls.Add(this.regDeleteButton);
            this.panel1.Location = new System.Drawing.Point(12, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 28);
            this.panel1.TabIndex = 30;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 40;
            this.refreshButton.Text = "更新(&R)";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.Location = new System.Drawing.Point(746, 3);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 50;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "終了(&Q)";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // regDeleteButton
            // 
            this.regDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.regDeleteButton.Location = new System.Drawing.Point(375, 3);
            this.regDeleteButton.Name = "regDeleteButton";
            this.regDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.regDeleteButton.TabIndex = 30;
            this.regDeleteButton.Text = "削除(&D)";
            this.regDeleteButton.UseVisualStyleBackColor = true;
            this.regDeleteButton.Click += new System.EventHandler(this.regDeleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.versionComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 55);
            this.panel2.TabIndex = 10;
            // 
            // versionComboBox
            // 
            this.versionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionComboBox.FormattingEnabled = true;
            this.versionComboBox.Location = new System.Drawing.Point(63, 6);
            this.versionComboBox.Name = "versionComboBox";
            this.versionComboBox.Size = new System.Drawing.Size(86, 20);
            this.versionComboBox.TabIndex = 12;
            this.versionComboBox.SelectedIndexChanged += new System.EventHandler(this.versionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "バージョン：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(63, 33);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(758, 19);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regListView);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 165);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "レジストリリセット for PB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView regListView;
        private System.Windows.Forms.ColumnHeader RegNameColumnHeader;
        private System.Windows.Forms.ColumnHeader PathColumnHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button regDeleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox versionComboBox;
    }
}

