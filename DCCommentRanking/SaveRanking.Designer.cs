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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveRanking));
            this.saveFileNameTextbox = new System.Windows.Forms.TextBox();
            this.h1t = new System.Windows.Forms.Label();
            this.h2t = new System.Windows.Forms.Label();
            this.underRankTextbox = new System.Windows.Forms.TextBox();
            this.upReplyNumTextbox = new System.Windows.Forms.TextBox();
            this.h3t = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveFileNameTextbox
            // 
            this.saveFileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileNameTextbox.Location = new System.Drawing.Point(87, 10);
            this.saveFileNameTextbox.Name = "saveFileNameTextbox";
            this.saveFileNameTextbox.Size = new System.Drawing.Size(345, 21);
            this.saveFileNameTextbox.TabIndex = 0;
            // 
            // h1t
            // 
            this.h1t.AutoSize = true;
            this.h1t.Location = new System.Drawing.Point(12, 15);
            this.h1t.Name = "h1t";
            this.h1t.Size = new System.Drawing.Size(69, 12);
            this.h1t.TabIndex = 1;
            this.h1t.Text = "저장 파일명";
            // 
            // h2t
            // 
            this.h2t.AutoSize = true;
            this.h2t.Location = new System.Drawing.Point(12, 63);
            this.h2t.Name = "h2t";
            this.h2t.Size = new System.Drawing.Size(137, 12);
            this.h2t.TabIndex = 2;
            this.h2t.Text = "일정 랭킹수 이하만 포함";
            // 
            // underRankTextbox
            // 
            this.underRankTextbox.Location = new System.Drawing.Point(14, 78);
            this.underRankTextbox.Name = "underRankTextbox";
            this.underRankTextbox.Size = new System.Drawing.Size(100, 21);
            this.underRankTextbox.TabIndex = 3;
            this.underRankTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // upReplyNumTextbox
            // 
            this.upReplyNumTextbox.Location = new System.Drawing.Point(14, 128);
            this.upReplyNumTextbox.Name = "upReplyNumTextbox";
            this.upReplyNumTextbox.Size = new System.Drawing.Size(100, 21);
            this.upReplyNumTextbox.TabIndex = 5;
            this.upReplyNumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // h3t
            // 
            this.h3t.AutoSize = true;
            this.h3t.Location = new System.Drawing.Point(12, 113);
            this.h3t.Name = "h3t";
            this.h3t.Size = new System.Drawing.Size(141, 12);
            this.h3t.TabIndex = 4;
            this.h3t.Text = "일정 댓글 수 이상만 포함";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(14, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(418, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SaveRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.upReplyNumTextbox);
            this.Controls.Add(this.h3t);
            this.Controls.Add(this.underRankTextbox);
            this.Controls.Add(this.h2t);
            this.Controls.Add(this.h1t);
            this.Controls.Add(this.saveFileNameTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 300);
            this.MinimumSize = new System.Drawing.Size(460, 250);
            this.Name = "SaveRanking";
            this.Text = "SaveRanking";
            this.ResumeLayout(false);
            this.PerformLayout();

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
