using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;

namespace RegResetForPb
{
    public partial class MainForm : Form
    {
        private const string VersionKeyword = "%VERSION%";
        private const string WORKSPACE_REG_KEY = @"Software\Sybase\PowerBuilder\%VERSION%\Workspace";

        private readonly List<string> excludeRegKey = new List<string> { "MRUList" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.setupVersionList();
            this.refreshList();
        }

        /// <summary>
        /// バージョンリストをセットアップする。
        /// </summary>
        private void setupVersionList()
        {
            var versions = ConfigurationManager.AppSettings["versions"].ToString().Split(',');
            versionComboBox.Items.AddRange(versions);

            var defaultVersion = ConfigurationManager.AppSettings["default"].ToString();
            versionComboBox.SelectedItem = defaultVersion;
        }

        /// <summary>
        /// リストの再描画を行う。
        /// </summary>
        private void refreshList()
        {
            regListView.Items.Clear();

            // レジストリからワークスペースパスを取得
            var regKeyNames = this.findRegKeyNames();

            // 正規表現パターンを生成
            var pattern = "";
            if (searchTextBox.Text != "")
            {
                pattern = searchTextBox.Text;
                pattern = Regex.Escape(pattern);
                pattern = string.Format("^.*{0}.*$", pattern);
            }

            // キー名をリストに追加
            foreach (var regKey in regKeyNames)
            {
                // 除外キーは対象外
                if (this.excludeRegKey.Contains(regKey))
                {
                    continue;
                }

                var path = regKey.Replace(@"$", @"\");

                // 検索文字が含まれないキー、パスは対象外
                if (pattern != "" &&
                        !Regex.Match(path, pattern, RegexOptions.IgnoreCase).Success &&
                        !Regex.Match(regKey, pattern, RegexOptions.IgnoreCase).Success)
                {
                    continue;
                }

                var item = new ListViewItem(regKey);
                item.SubItems.Add(path);
                regListView.Items.Add(item);
            }
        }

        /// <summary>
        /// レジストリのサブキーを取得する。
        /// </summary>
        /// <returns></returns>
        private string[] findRegKeyNames()
        {
            var subKey = WORKSPACE_REG_KEY.Replace(VersionKeyword, versionComboBox.Text);
            var regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey, false);

            //キーが存在しないときは null が返される
            if (regkey == null)
            {
                return new string[] { };
            }

            return regkey.GetSubKeyNames();
        }

        /// <summary>
        /// 選択されているキーを削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regDeleteButton_Click(object sender, EventArgs e)
        {
            if (regListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("キーが選択されていません。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                regListView.Focus();
                return;
            }

            if (MessageBox.Show("選択されたキーを削除します。" + Environment.NewLine + "よろしいですか？",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // 選択されたサブキーをすべて削除する
            var subKey = WORKSPACE_REG_KEY.Replace(VersionKeyword, versionComboBox.Text);
            var regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey, true);
            foreach (ListViewItem item in regListView.SelectedItems)
            {
                regkey.DeleteSubKeyTree(item.Text);
            }
            regkey.Close();

            this.refreshList();
        }

        /// <summary>
        /// アプリ終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// リスト更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.refreshList();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.refreshList();
        }

        private void versionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshList();
        }
    }
}
