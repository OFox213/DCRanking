namespace DCCommentRanking
{
		public partial class Form1 : global::System.Windows.Forms.Form
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
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DCCommentRanking.Form1));
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.pageStatusText = new global::System.Windows.Forms.Label();
			this.pageStatusProgress = new global::System.Windows.Forms.ProgressBar();
			this.logConsole = new global::System.Windows.Forms.TextBox();
			this.gallIDCheckStatus = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.endDatePicker = new global::System.Windows.Forms.DateTimePicker();
			this.label6 = new global::System.Windows.Forms.Label();
			this.analyzeStartButton = new global::System.Windows.Forms.Button();
			this.startDatePicker = new global::System.Windows.Forms.DateTimePicker();
			this.label5 = new global::System.Windows.Forms.Label();
			this.endPageNumberTextbox = new global::System.Windows.Forms.TextBox();
			this.startPageNumberTextbox = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.gallIDTextBox = new global::System.Windows.Forms.TextBox();
			this.isMinorCheckbox = new global::System.Windows.Forms.CheckBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.saveProgress = new global::System.Windows.Forms.ProgressBar();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.autoMergeButton = new global::System.Windows.Forms.Button();
			this.searchButton = new global::System.Windows.Forms.Button();
			this.searchTextBox = new global::System.Windows.Forms.TextBox();
			this.saveFileButton = new global::System.Windows.Forms.Button();
			this.listDeselectAllButton = new global::System.Windows.Forms.Button();
			this.listSelectAllButton = new global::System.Windows.Forms.Button();
			this.fileNameTextbox = new global::System.Windows.Forms.TextBox();
			this.openTempFileButton = new global::System.Windows.Forms.Button();
			this.userRankList = new global::System.Windows.Forms.ListView();
			this.rankNum = new global::System.Windows.Forms.ColumnHeader();
			this.userNick = new global::System.Windows.Forms.ColumnHeader();
			this.replyNum = new global::System.Windows.Forms.ColumnHeader();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.saveCommentUserButton = new global::System.Windows.Forms.Button();
			this.label9 = new global::System.Windows.Forms.Label();
			this.targetUserTextbox = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.debugFolderPathTextbox = new global::System.Windows.Forms.TextBox();
			this.debugCommentCheckBox = new global::System.Windows.Forms.CheckBox();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.loadingTextUpdate = new global::System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.openCommentViewer = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.tabControl1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new global::System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(859, 383);
			this.tabControl1.TabIndex = 0;
			this.tabPage1.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.pageStatusText);
			this.tabPage1.Controls.Add(this.pageStatusProgress);
			this.tabPage1.Controls.Add(this.logConsole);
			this.tabPage1.Controls.Add(this.gallIDCheckStatus);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.endDatePicker);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.analyzeStartButton);
			this.tabPage1.Controls.Add(this.startDatePicker);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.endPageNumberTextbox);
			this.tabPage1.Controls.Add(this.startPageNumberTextbox);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.gallIDTextBox);
			this.tabPage1.Controls.Add(this.isMinorCheckbox);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(851, 357);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "갤러리 설정";
			this.pageStatusText.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.pageStatusText.AutoSize = true;
			this.pageStatusText.Location = new global::System.Drawing.Point(137, 332);
			this.pageStatusText.Name = "pageStatusText";
			this.pageStatusText.Size = new global::System.Drawing.Size(89, 12);
			this.pageStatusText.TabIndex = 15;
			this.pageStatusText.Text = "0 중 0 처리중...";
			this.pageStatusText.Visible = false;
			this.pageStatusProgress.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.pageStatusProgress.Location = new global::System.Drawing.Point(138, 306);
			this.pageStatusProgress.Name = "pageStatusProgress";
			this.pageStatusProgress.Size = new global::System.Drawing.Size(121, 18);
			this.pageStatusProgress.TabIndex = 16;
			this.pageStatusProgress.Visible = false;
			this.logConsole.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.logConsole.Location = new global::System.Drawing.Point(387, 11);
			this.logConsole.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logConsole.Multiline = true;
			this.logConsole.Name = "logConsole";
			this.logConsole.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.logConsole.Size = new global::System.Drawing.Size(456, 333);
			this.logConsole.TabIndex = 22;
			this.gallIDCheckStatus.AutoSize = true;
			this.gallIDCheckStatus.ForeColor = global::System.Drawing.Color.Green;
			this.gallIDCheckStatus.Location = new global::System.Drawing.Point(165, 66);
			this.gallIDCheckStatus.Name = "gallIDCheckStatus";
			this.gallIDCheckStatus.Size = new global::System.Drawing.Size(172, 12);
			this.gallIDCheckStatus.TabIndex = 15;
			this.gallIDCheckStatus.Text = "갤러리 ID 검증을 완료했습니다";
			this.gallIDCheckStatus.Visible = false;
			this.button1.Location = new global::System.Drawing.Point(6, 61);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(149, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "갤러리 ID 검증";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.endDatePicker.Location = new global::System.Drawing.Point(81, 255);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.Size = new global::System.Drawing.Size(200, 21);
			this.endDatePicker.TabIndex = 11;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(6, 260);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(45, 12);
			this.label6.TabIndex = 10;
			this.label6.Text = "끝 날짜";
			this.analyzeStartButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.analyzeStartButton.Location = new global::System.Drawing.Point(6, 301);
			this.analyzeStartButton.Name = "analyzeStartButton";
			this.analyzeStartButton.Size = new global::System.Drawing.Size(116, 50);
			this.analyzeStartButton.TabIndex = 14;
			this.analyzeStartButton.Text = "집계 시작";
			this.analyzeStartButton.UseVisualStyleBackColor = true;
			this.analyzeStartButton.Click += new global::System.EventHandler(this.analyzeStartButton_Click);
			this.startDatePicker.Location = new global::System.Drawing.Point(81, 228);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new global::System.Drawing.Size(200, 21);
			this.startDatePicker.TabIndex = 9;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 233);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(57, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "시작 날짜";
			this.endPageNumberTextbox.Location = new global::System.Drawing.Point(122, 167);
			this.endPageNumberTextbox.Name = "endPageNumberTextbox";
			this.endPageNumberTextbox.Size = new global::System.Drawing.Size(100, 21);
			this.endPageNumberTextbox.TabIndex = 6;
			this.endPageNumberTextbox.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
			this.startPageNumberTextbox.Location = new global::System.Drawing.Point(122, 138);
			this.startPageNumberTextbox.Name = "startPageNumberTextbox";
			this.startPageNumberTextbox.Size = new global::System.Drawing.Size(100, 21);
			this.startPageNumberTextbox.TabIndex = 5;
			this.startPageNumberTextbox.Text = "1";
			this.startPageNumberTextbox.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(6, 172);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(57, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "끝 페이지";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 143);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(107, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "시작 페이지 (필수)";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 18);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(56, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "갤러리 ID";
			this.gallIDTextBox.Location = new global::System.Drawing.Point(6, 33);
			this.gallIDTextBox.Name = "gallIDTextBox";
			this.gallIDTextBox.Size = new global::System.Drawing.Size(149, 21);
			this.gallIDTextBox.TabIndex = 1;
			this.gallIDTextBox.TextChanged += new global::System.EventHandler(this.GalleryIDTextbox_Changed);
			this.isMinorCheckbox.AutoSize = true;
			this.isMinorCheckbox.Location = new global::System.Drawing.Point(167, 35);
			this.isMinorCheckbox.Name = "isMinorCheckbox";
			this.isMinorCheckbox.Size = new global::System.Drawing.Size(136, 16);
			this.isMinorCheckbox.TabIndex = 0;
			this.isMinorCheckbox.Text = "마이너 갤러리입니다";
			this.isMinorCheckbox.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.saveProgress);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.autoMergeButton);
			this.tabPage2.Controls.Add(this.searchButton);
			this.tabPage2.Controls.Add(this.searchTextBox);
			this.tabPage2.Controls.Add(this.saveFileButton);
			this.tabPage2.Controls.Add(this.listDeselectAllButton);
			this.tabPage2.Controls.Add(this.listSelectAllButton);
			this.tabPage2.Controls.Add(this.fileNameTextbox);
			this.tabPage2.Controls.Add(this.openTempFileButton);
			this.tabPage2.Controls.Add(this.userRankList);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(851, 357);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "결과 후처리/저장";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.saveProgress.Location = new global::System.Drawing.Point(533, 316);
			this.saveProgress.Name = "saveProgress";
			this.saveProgress.Size = new global::System.Drawing.Size(311, 34);
			this.saveProgress.TabIndex = 11;
			this.saveProgress.Visible = false;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Font = new global::System.Drawing.Font("굴림", 9f);
			this.button2.Location = new global::System.Drawing.Point(533, 236);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(150, 35);
			this.button2.TabIndex = 10;
			this.button2.Text = "유저 병합";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Visible = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(534, 79);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(69, 12);
			this.label8.TabIndex = 9;
			this.label8.Text = "닉네임 검색";
			this.autoMergeButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.autoMergeButton.BackColor = global::System.Drawing.Color.LimeGreen;
			this.autoMergeButton.Font = new global::System.Drawing.Font("굴림", 9f);
			this.autoMergeButton.ForeColor = global::System.Drawing.Color.White;
			this.autoMergeButton.Location = new global::System.Drawing.Point(694, 236);
			this.autoMergeButton.Name = "autoMergeButton";
			this.autoMergeButton.Size = new global::System.Drawing.Size(150, 35);
			this.autoMergeButton.TabIndex = 8;
			this.autoMergeButton.Text = "유동 유저 자동 병합";
			this.autoMergeButton.UseVisualStyleBackColor = false;
			this.autoMergeButton.Visible = false;
			this.searchButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.searchButton.Location = new global::System.Drawing.Point(756, 95);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new global::System.Drawing.Size(89, 26);
			this.searchButton.TabIndex = 7;
			this.searchButton.Text = "검색";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new global::System.EventHandler(this.searchButton_Click);
			this.searchTextBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.searchTextBox.Location = new global::System.Drawing.Point(534, 97);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new global::System.Drawing.Size(215, 21);
			this.searchTextBox.TabIndex = 6;
			this.saveFileButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.saveFileButton.Location = new global::System.Drawing.Point(533, 316);
			this.saveFileButton.Name = "saveFileButton";
			this.saveFileButton.Size = new global::System.Drawing.Size(311, 35);
			this.saveFileButton.TabIndex = 5;
			this.saveFileButton.Text = "파일 저장";
			this.saveFileButton.UseVisualStyleBackColor = true;
			this.saveFileButton.Click += new global::System.EventHandler(this.saveFileButton_Click);
			this.listDeselectAllButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.listDeselectAllButton.Location = new global::System.Drawing.Point(534, 191);
			this.listDeselectAllButton.Name = "listDeselectAllButton";
			this.listDeselectAllButton.Size = new global::System.Drawing.Size(311, 26);
			this.listDeselectAllButton.TabIndex = 4;
			this.listDeselectAllButton.Text = "모두 선택 해제";
			this.listDeselectAllButton.UseVisualStyleBackColor = true;
			this.listDeselectAllButton.Click += new global::System.EventHandler(this.listDeselectAllButton_Click);
			this.listSelectAllButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.listSelectAllButton.Location = new global::System.Drawing.Point(534, 159);
			this.listSelectAllButton.Name = "listSelectAllButton";
			this.listSelectAllButton.Size = new global::System.Drawing.Size(311, 26);
			this.listSelectAllButton.TabIndex = 3;
			this.listSelectAllButton.Text = "모두 선택";
			this.listSelectAllButton.UseVisualStyleBackColor = true;
			this.listSelectAllButton.Click += new global::System.EventHandler(this.listSelectAllButton_Click);
			this.fileNameTextbox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.fileNameTextbox.Location = new global::System.Drawing.Point(626, 18);
			this.fileNameTextbox.Name = "fileNameTextbox";
			this.fileNameTextbox.ReadOnly = true;
			this.fileNameTextbox.Size = new global::System.Drawing.Size(218, 21);
			this.fileNameTextbox.TabIndex = 2;
			this.fileNameTextbox.Text = "이곳에 파일 이름이 표시됩니다";
			this.openTempFileButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.openTempFileButton.Location = new global::System.Drawing.Point(533, 6);
			this.openTempFileButton.Name = "openTempFileButton";
			this.openTempFileButton.Size = new global::System.Drawing.Size(87, 44);
			this.openTempFileButton.TabIndex = 1;
			this.openTempFileButton.Text = "데이터\r\n불러오기";
			this.openTempFileButton.UseVisualStyleBackColor = true;
			this.openTempFileButton.Click += new global::System.EventHandler(this.openTempFileButton_Click);
			this.userRankList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.userRankList.CheckBoxes = true;
			this.userRankList.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.rankNum,
				this.userNick,
				this.replyNum
			});
			this.userRankList.FullRowSelect = true;
			this.userRankList.HideSelection = false;
			this.userRankList.Location = new global::System.Drawing.Point(6, 6);
			this.userRankList.Name = "userRankList";
			this.userRankList.Size = new global::System.Drawing.Size(521, 345);
			this.userRankList.TabIndex = 0;
			this.userRankList.UseCompatibleStateImageBehavior = false;
			this.userRankList.View = global::System.Windows.Forms.View.Details;
			this.rankNum.Text = "순위";
			this.userNick.Text = "닉네임/IP";
			this.userNick.Width = 250;
			this.replyNum.Text = "댓글 수";
			this.replyNum.Width = 120;
			this.tabPage3.Controls.Add(this.panel1);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.debugFolderPathTextbox);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new global::System.Drawing.Size(851, 357);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "디버깅";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.saveCommentUserButton.Location = new global::System.Drawing.Point(233, 36);
			this.saveCommentUserButton.Name = "saveCommentUserButton";
			this.saveCommentUserButton.Size = new global::System.Drawing.Size(75, 23);
			this.saveCommentUserButton.TabIndex = 5;
			this.saveCommentUserButton.Text = "저장";
			this.saveCommentUserButton.UseVisualStyleBackColor = true;
			this.saveCommentUserButton.Click += new global::System.EventHandler(this.saveCommentUserButton_Click);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(10, 42);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(97, 12);
			this.label9.TabIndex = 4;
			this.label9.Text = "대상 유저 닉네임";
			this.targetUserTextbox.Location = new global::System.Drawing.Point(113, 37);
			this.targetUserTextbox.Name = "targetUserTextbox";
			this.targetUserTextbox.Size = new global::System.Drawing.Size(114, 21);
			this.targetUserTextbox.TabIndex = 3;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(13, 20);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(125, 12);
			this.label7.TabIndex = 2;
			this.label7.Text = "디버그 기록 저장 위치";
			this.debugFolderPathTextbox.Location = new global::System.Drawing.Point(144, 14);
			this.debugFolderPathTextbox.Name = "debugFolderPathTextbox";
			this.debugFolderPathTextbox.ReadOnly = true;
			this.debugFolderPathTextbox.Size = new global::System.Drawing.Size(321, 21);
			this.debugFolderPathTextbox.TabIndex = 1;
			this.debugCommentCheckBox.AutoSize = true;
			this.debugCommentCheckBox.Location = new global::System.Drawing.Point(12, 13);
			this.debugCommentCheckBox.Name = "debugCommentCheckBox";
			this.debugCommentCheckBox.Size = new global::System.Drawing.Size(132, 16);
			this.debugCommentCheckBox.TabIndex = 0;
			this.debugCommentCheckBox.Text = "유저 댓글 내용 기록";
			this.debugCommentCheckBox.UseVisualStyleBackColor = true;
			this.debugCommentCheckBox.CheckedChanged += new global::System.EventHandler(this.debugCommentCheckBox_CheckedChanged);
			this.linkLabel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new global::System.Drawing.Point(699, 440);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(169, 12);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "이 프로그램의 제작자 GITHUB";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(738, 399);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(130, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "DC 댓글 랭킹 프로그램";
			this.linkLabel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new global::System.Drawing.Point(746, 419);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(121, 12);
			this.linkLabel2.TabIndex = 3;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "사용방법 도움말 보기";
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.loadingTextUpdate.Tick += new global::System.EventHandler(this.loadingTextUpdate_Tick);

			this.openCommentViewer.Location = new global::System.Drawing.Point(12, 65);
			this.openCommentViewer.Name = "openCommentViewer";
			this.openCommentViewer.Size = new global::System.Drawing.Size(296, 41);
			this.openCommentViewer.TabIndex = 6;
			this.openCommentViewer.Text = "댓글 내용 뷰어 열기";
			this.openCommentViewer.UseVisualStyleBackColor = true;
			this.openCommentViewer.Click += new global::System.EventHandler(this.openCommentViewer_Click);
			this.panel1.BackColor = global::System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.debugCommentCheckBox);
			this.panel1.Controls.Add(this.openCommentViewer);
			this.panel1.Controls.Add(this.targetUserTextbox);
			this.panel1.Controls.Add(this.saveCommentUserButton);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Location = new global::System.Drawing.Point(15, 54);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(323, 119);
			this.panel1.TabIndex = 7;
			this.label10.AutoSize = true;
			this.label10.ForeColor = global::System.Drawing.Color.Red;
			this.label10.Location = new global::System.Drawing.Point(531, 236);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(181, 12);
			this.label10.TabIndex = 12;
			this.label10.Text = "유저 병합 기능은 추후 지원 예정";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(884, 461);
			base.Controls.Add(this.linkLabel2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.tabControl1);
			this.MinimumSize = new global::System.Drawing.Size(800, 500);
			base.Name = "Form1";
			this.Text = "디시 댓글 랭킹";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

				private global::System.ComponentModel.IContainer components;

				private global::System.Windows.Forms.TabControl tabControl1;

				private global::System.Windows.Forms.TabPage tabPage1;

				private global::System.Windows.Forms.TextBox endPageNumberTextbox;

				private global::System.Windows.Forms.TextBox startPageNumberTextbox;

				private global::System.Windows.Forms.Label label4;

				private global::System.Windows.Forms.Label label3;

				private global::System.Windows.Forms.Label label2;

				private global::System.Windows.Forms.TextBox gallIDTextBox;

				private global::System.Windows.Forms.CheckBox isMinorCheckbox;

				private global::System.Windows.Forms.TabPage tabPage2;

				private global::System.Windows.Forms.LinkLabel linkLabel1;

				private global::System.Windows.Forms.Label label1;

				private global::System.Windows.Forms.DateTimePicker endDatePicker;

				private global::System.Windows.Forms.Label label6;

				private global::System.Windows.Forms.DateTimePicker startDatePicker;

				private global::System.Windows.Forms.Label label5;

				private global::System.Windows.Forms.Button button1;

				private global::System.Windows.Forms.Button analyzeStartButton;

				private global::System.Windows.Forms.Label gallIDCheckStatus;

				private global::System.Windows.Forms.LinkLabel linkLabel2;

				private global::System.Windows.Forms.TextBox logConsole;

				private global::System.Windows.Forms.Timer loadingTextUpdate;

				private global::System.Windows.Forms.NotifyIcon notifyIcon1;

				private global::System.Windows.Forms.Label pageStatusText;

				private global::System.Windows.Forms.ProgressBar pageStatusProgress;

				private global::System.Windows.Forms.ListView userRankList;

				private global::System.Windows.Forms.ColumnHeader rankNum;

				private global::System.Windows.Forms.ColumnHeader userNick;

				private global::System.Windows.Forms.ColumnHeader replyNum;

				private global::System.Windows.Forms.Button openTempFileButton;

				private global::System.Windows.Forms.TextBox fileNameTextbox;

				private global::System.Windows.Forms.Button saveFileButton;

				private global::System.Windows.Forms.Button listDeselectAllButton;

				private global::System.Windows.Forms.Button listSelectAllButton;

				private global::System.Windows.Forms.TabPage tabPage3;

				private global::System.Windows.Forms.Label label7;

				private global::System.Windows.Forms.TextBox debugFolderPathTextbox;

				private global::System.Windows.Forms.CheckBox debugCommentCheckBox;

				private global::System.Windows.Forms.Button searchButton;

				private global::System.Windows.Forms.TextBox searchTextBox;

				private global::System.Windows.Forms.Button autoMergeButton;

				private global::System.Windows.Forms.Label label8;

				private global::System.Windows.Forms.Button button2;

				private global::System.Windows.Forms.Label label9;

				private global::System.Windows.Forms.TextBox targetUserTextbox;

				private global::System.Windows.Forms.Button saveCommentUserButton;

				private global::System.Windows.Forms.ProgressBar saveProgress;

				private global::System.Windows.Forms.Button openCommentViewer;

				private global::System.Windows.Forms.Panel panel1;

				private global::System.Windows.Forms.Label label10;
	}
}
