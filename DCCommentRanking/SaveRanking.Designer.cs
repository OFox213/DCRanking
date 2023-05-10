namespace DCCommentRanking
{
		public partial class SaveRanking : global::System.Windows.Forms.Form
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
			this.saveFileNameTextbox = new global::System.Windows.Forms.TextBox();
			this.h1t = new global::System.Windows.Forms.Label();
			this.h2t = new global::System.Windows.Forms.Label();
			this.underRankTextbox = new global::System.Windows.Forms.TextBox();
			this.upReplyNumTextbox = new global::System.Windows.Forms.TextBox();
			this.h3t = new global::System.Windows.Forms.Label();
			this.saveButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.saveFileNameTextbox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.saveFileNameTextbox.Location = new global::System.Drawing.Point(87, 10);
			this.saveFileNameTextbox.Name = "saveFileNameTextbox";
			this.saveFileNameTextbox.Size = new global::System.Drawing.Size(345, 21);
			this.saveFileNameTextbox.TabIndex = 0;
			this.h1t.AutoSize = true;
			this.h1t.Location = new global::System.Drawing.Point(12, 15);
			this.h1t.Name = "h1t";
			this.h1t.Size = new global::System.Drawing.Size(69, 12);
			this.h1t.TabIndex = 1;
			this.h1t.Text = "저장 파일명";
			this.h2t.AutoSize = true;
			this.h2t.Location = new global::System.Drawing.Point(12, 63);
			this.h2t.Name = "h2t";
			this.h2t.Size = new global::System.Drawing.Size(137, 12);
			this.h2t.TabIndex = 2;
			this.h2t.Text = "일정 랭킹수 이하만 포함";
			this.underRankTextbox.Location = new global::System.Drawing.Point(14, 78);
			this.underRankTextbox.Name = "underRankTextbox";
			this.underRankTextbox.Size = new global::System.Drawing.Size(100, 21);
			this.underRankTextbox.TabIndex = 3;
			this.underRankTextbox.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
			this.upReplyNumTextbox.Location = new global::System.Drawing.Point(14, 128);
			this.upReplyNumTextbox.Name = "upReplyNumTextbox";
			this.upReplyNumTextbox.Size = new global::System.Drawing.Size(100, 21);
			this.upReplyNumTextbox.TabIndex = 5;
			this.upReplyNumTextbox.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
			this.h3t.AutoSize = true;
			this.h3t.Location = new global::System.Drawing.Point(12, 113);
			this.h3t.Name = "h3t";
			this.h3t.Size = new global::System.Drawing.Size(141, 12);
			this.h3t.TabIndex = 4;
			this.h3t.Text = "일정 댓글 수 이상만 포함";
			this.saveButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.saveButton.Location = new global::System.Drawing.Point(14, 168);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new global::System.Drawing.Size(418, 31);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "저장";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new global::System.EventHandler(this.saveButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(444, 211);
			base.Controls.Add(this.saveButton);
			base.Controls.Add(this.upReplyNumTextbox);
			base.Controls.Add(this.h3t);
			base.Controls.Add(this.underRankTextbox);
			base.Controls.Add(this.h2t);
			base.Controls.Add(this.h1t);
			base.Controls.Add(this.saveFileNameTextbox);
			this.MaximumSize = new global::System.Drawing.Size(560, 300);
			this.MinimumSize = new global::System.Drawing.Size(460, 250);
			base.Name = "SaveRanking";
			this.Text = "SaveRanking";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

				private global::System.ComponentModel.IContainer components;

				private global::System.Windows.Forms.TextBox saveFileNameTextbox;

				private global::System.Windows.Forms.Label h1t;

				private global::System.Windows.Forms.Label h2t;

				private global::System.Windows.Forms.TextBox underRankTextbox;

				private global::System.Windows.Forms.TextBox upReplyNumTextbox;

				private global::System.Windows.Forms.Label h3t;

				private global::System.Windows.Forms.Button saveButton;
	}
}
