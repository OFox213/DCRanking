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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentViewer));
            this.userRankList = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gallNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gallIDText = new System.Windows.Forms.Label();
            this.targetNickText = new System.Windows.Forms.Label();
            this.totalReplyCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userRankList
            // 
            this.userRankList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userRankList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.gallNum,
            this.commentContent});
            this.userRankList.FullRowSelect = true;
            this.userRankList.HideSelection = false;
            this.userRankList.Location = new System.Drawing.Point(12, 12);
            this.userRankList.Name = "userRankList";
            this.userRankList.Size = new System.Drawing.Size(524, 426);
            this.userRankList.TabIndex = 1;
            this.userRankList.UseCompatibleStateImageBehavior = false;
            this.userRankList.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "#";
            // 
            // gallNum
            // 
            this.gallNum.Text = "게시글 ID";
            this.gallNum.Width = 120;
            // 
            // commentContent
            // 
            this.commentContent.Text = "댓글 내용";
            this.commentContent.Width = 280;
            // 
            // gallIDText
            // 
            this.gallIDText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gallIDText.Font = new System.Drawing.Font("굴림", 9F);
            this.gallIDText.Location = new System.Drawing.Point(553, 30);
            this.gallIDText.Name = "gallIDText";
            this.gallIDText.Size = new System.Drawing.Size(235, 35);
            this.gallIDText.TabIndex = 2;
            this.gallIDText.Text = "갤러리 ID | ****";
            // 
            // targetNickText
            // 
            this.targetNickText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetNickText.Font = new System.Drawing.Font("굴림", 9F);
            this.targetNickText.Location = new System.Drawing.Point(553, 65);
            this.targetNickText.Name = "targetNickText";
            this.targetNickText.Size = new System.Drawing.Size(238, 32);
            this.targetNickText.TabIndex = 3;
            this.targetNickText.Text = "대상 닉네임 | ****";
            // 
            // totalReplyCount
            // 
            this.totalReplyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalReplyCount.AutoSize = true;
            this.totalReplyCount.Font = new System.Drawing.Font("굴림", 9F);
            this.totalReplyCount.Location = new System.Drawing.Point(553, 97);
            this.totalReplyCount.Name = "totalReplyCount";
            this.totalReplyCount.Size = new System.Drawing.Size(73, 12);
            this.totalReplyCount.TabIndex = 4;
            this.totalReplyCount.Text = "총 댓글 수 : ";
            // 
            // CommentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.totalReplyCount);
            this.Controls.Add(this.targetNickText);
            this.Controls.Add(this.gallIDText);
            this.Controls.Add(this.userRankList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(819, 489);
            this.Name = "CommentViewer";
            this.Text = "댓글 뷰어";
            this.Load += new System.EventHandler(this.CommentViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
