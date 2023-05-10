using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DCCommentRanking
{
		public partial class OpenTempForm : Form
	{
				public OpenTempForm(string path)
		{
			this.InitializeComponent();
			string path2 = Directory.GetCurrentDirectory() + "\\" + path;
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			foreach (string item in from filename in Directory.GetFiles(path2, "*.json")
			select Path.GetFileName(filename))
			{
				this.listBox.Items.Add(item);
			}
		}

				private void selectBtn_Click(object sender, EventArgs e)
		{
			if (this.listBox.SelectedItem != null)
			{
				this.selectedFileName = this.listBox.GetItemText(this.listBox.SelectedItem);
				base.DialogResult = DialogResult.OK;
				return;
			}
			MessageBox.Show("전처리한 데이터를 선택 해야합니다.");
		}

				public string selectedFileName;
	}
}
