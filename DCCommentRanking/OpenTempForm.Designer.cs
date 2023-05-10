namespace DCCommentRanking
{
		public partial class OpenTempForm : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DCCommentRanking.OpenTempForm));
			this.selectBtn = new global::System.Windows.Forms.Button();
			this.listBox = new global::System.Windows.Forms.ListBox();
			base.SuspendLayout();
			this.selectBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectBtn.Location = new global::System.Drawing.Point(523, 246);
			this.selectBtn.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.selectBtn.Name = "selectBtn";
			this.selectBtn.Size = new global::System.Drawing.Size(105, 40);
			this.selectBtn.TabIndex = 4;
			this.selectBtn.Text = "불러오기";
			this.selectBtn.UseVisualStyleBackColor = true;
			this.selectBtn.Click += new global::System.EventHandler(this.selectBtn_Click);
			this.listBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 12;
			this.listBox.Location = new global::System.Drawing.Point(12, 11);
			this.listBox.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox.Name = "listBox";
			this.listBox.Size = new global::System.Drawing.Size(616, 220);
			this.listBox.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(634, 291);
			base.Controls.Add(this.selectBtn);
			base.Controls.Add(this.listBox);
			this.MaximumSize = new global::System.Drawing.Size(750, 530);
			this.MinimumSize = new global::System.Drawing.Size(650, 330);
			base.Name = "OpenTempForm";
			this.Text = "파일 열기";
			base.ResumeLayout(false);
		}

				private global::System.ComponentModel.IContainer components;

				private global::System.Windows.Forms.Button selectBtn;

				private global::System.Windows.Forms.ListBox listBox;
	}
}
