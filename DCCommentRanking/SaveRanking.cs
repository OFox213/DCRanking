using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DCCommentRanking
{
		public partial class SaveRanking : Form
	{
				public SaveRanking(string saveFileName, List<DCHelper.UserInfoRank> uir)
		{
			this.InitializeComponent();
			this.saveFileNameTextbox.Text = saveFileName;
		}

				private void onlyNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
			{
				e.Handled = true;
			}
		}

				private void saveButton_Click(object sender, EventArgs e)
		{
			bool flag = true;
			if (this.saveFileNameTextbox.Text.Length == 0)
			{
				flag = false;
				this.h1t.ForeColor = Color.Red;
			}
			else
			{
				this.h1t.ForeColor = Color.Black;
			}
			if (this.underRankTextbox.Text.Length == 0)
			{
				flag = false;
				this.h2t.ForeColor = Color.Red;
			}
			else
			{
				this.h2t.ForeColor = Color.Black;
			}
			if (this.upReplyNumTextbox.Text.Length == 0)
			{
				flag = false;
				this.h3t.ForeColor = Color.Red;
			}
			else
			{
				this.h3t.ForeColor = Color.Black;
			}
			if (!flag)
			{
				MessageBox.Show("일부 항목에 값을 입력하지 않았습니다.\n입력 후 다시 시도해주세요.");
				return;
			}
			this.fileName = this.saveFileNameTextbox.Text;
			this.maximumRankingNum = int.Parse(this.underRankTextbox.Text);
			this.miniumReplyCount = int.Parse(this.upReplyNumTextbox.Text);
			base.DialogResult = DialogResult.OK;
		}

				public string fileName;

				public int maximumRankingNum;

				public int miniumReplyCount;
	}
}
