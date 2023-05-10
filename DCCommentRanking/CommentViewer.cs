using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DCCommentRanking
{
    public partial class CommentViewer : Form
    {
        public CommentViewer(string dir)
        {
            this.InitializeComponent();
            this.dir = dir;
        }

        private void CommentViewer_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(this.dir))
                {
                    string value = streamReader.ReadToEnd();
                    this.uir = JsonConvert.DeserializeObject<List<CommentViewer.UserComment>>(value);
                }
                this.userRankList.Items.Clear();
                int num = 0;
                foreach (CommentViewer.UserComment userComment in this.uir)
                {
                    num++;
                    if (num == 1)
                    {
                        this.gallIDText.Text = "갤러리 ID | " + userComment.gallID;
                        this.targetNickText.Text = "대상 닉네임 | " + userComment.name;
                    }
                    ListViewItem value2 = new ListViewItem(new string[]
                    {
                        num.ToString(),
                        userComment.gallNum,
                        (userComment.comment.Length == 0) ? "[디시콘]" : userComment.comment
                    });
                    this.userRankList.Items.Add(value2);
                }
                this.userRankList.Refresh();
                this.totalReplyCount.Text = "총 댓글 수 ㅣ " + num.ToString();
            }
            catch
            {
                MessageBox.Show("아무것도 선택하지 않았거나 파일이 삭제되었습니다.");
            }
        }

        public List<CommentViewer.UserComment> uir = new List<CommentViewer.UserComment>();

        private string dir;

        [Serializable]
        public class UserComment
        {
            public UserComment()
            {
            }

            public UserComment(string name, string comment, string gallID, string gallNum)
            {
                this.name = name;
                this.comment = comment;
                this.gallID = gallID;
                this.gallNum = gallNum;
            }

            public string name;

            public string comment;

            public string gallID;

            public string gallNum;
        }
    }
}
