namespace DCCommentRanking
{
		public partial class CommentViewer : global::System.Windows.Forms.Form
	{
				protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

				private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DCCommentRanking.CommentViewer));
			this.userRankList = new global::System.Windows.Forms.ListView();
			this.index = new global::System.Windows.Forms.ColumnHeader();
			this.commentContent = new global::System.Windows.Forms.ColumnHeader();
			this.gallNum = new global::System.Windows.Forms.ColumnHeader();
			this.gallIDText = new global::System.Windows.Forms.Label();
			this.targetNickText = new global::System.Windows.Forms.Label();
			this.totalReplyCount = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.userRankList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.userRankList.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.index,
				this.gallNum,
				this.commentContent
			});
			this.userRankList.FullRowSelect = true;
			this.userRankList.HideSelection = false;
			this.userRankList.Location = new global::System.Drawing.Point(12, 12);
			this.userRankList.Name = "userRankList";
			this.userRankList.Size = new global::System.Drawing.Size(524, 426);
			this.userRankList.TabIndex = 1;
			this.userRankList.UseCompatibleStateImageBehavior = false;
			this.userRankList.View = global::System.Windows.Forms.View.Details;
			this.index.Text = "#";
			this.commentContent.Text = "댓글 내용";
			this.commentContent.Width = 280;
			this.gallNum.Text = "게시글 ID";
			this.gallNum.Width = 120;
			this.gallIDText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.gallIDText.Font = new global::System.Drawing.Font("굴림", 9f);
			this.gallIDText.Location = new global::System.Drawing.Point(553, 30);
			this.gallIDText.Name = "gallIDText";
			this.gallIDText.Size = new global::System.Drawing.Size(235, 35);
			this.gallIDText.TabIndex = 2;
			this.gallIDText.Text = "갤러리 ID | ****";
			this.targetNickText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.targetNickText.Font = new global::System.Drawing.Font("굴림", 9f);
			this.targetNickText.Location = new global::System.Drawing.Point(553, 65);
			this.targetNickText.Name = "targetNickText";
			this.targetNickText.Size = new global::System.Drawing.Size(238, 32);
			this.targetNickText.TabIndex = 3;
			this.targetNickText.Text = "대상 닉네임 | ****";
			this.totalReplyCount.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.totalReplyCount.AutoSize = true;
			this.totalReplyCount.Font = new global::System.Drawing.Font("굴림", 9f);
			this.totalReplyCount.Location = new global::System.Drawing.Point(553, 97);
			this.totalReplyCount.Name = "totalReplyCount";
			this.totalReplyCount.Size = new global::System.Drawing.Size(73, 12);
			this.totalReplyCount.TabIndex = 4;
			this.totalReplyCount.Text = "총 댓글 수 : ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(803, 450);
			base.Controls.Add(this.totalReplyCount);
			base.Controls.Add(this.targetNickText);
			base.Controls.Add(this.gallIDText);
			base.Controls.Add(this.userRankList);
			this.MinimumSize = new global::System.Drawing.Size(819, 489);
			base.Name = "CommentViewer";
			this.Text = "댓글 뷰어";
			base.Load += new global::System.EventHandler(this.CommentViewer_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

				private global::System.ComponentModel.IContainer components;

				private global::System.Windows.Forms.ListView userRankList;

				private global::System.Windows.Forms.ColumnHeader index;

				private global::System.Windows.Forms.ColumnHeader commentContent;

				private global::System.Windows.Forms.ColumnHeader gallNum;

				private global::System.Windows.Forms.Label gallIDText;

				private global::System.Windows.Forms.Label targetNickText;

				private global::System.Windows.Forms.Label totalReplyCount;
	}
}
