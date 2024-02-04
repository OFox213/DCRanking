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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pageStatusText = new System.Windows.Forms.Label();
            this.pageStatusProgress = new System.Windows.Forms.ProgressBar();
            this.logConsole = new System.Windows.Forms.TextBox();
            this.gallIDCheckStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.analyzeStartButton = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.endPageNumberTextbox = new System.Windows.Forms.TextBox();
            this.startPageNumberTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gallIDTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveProgress = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.autoMergeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.listDeselectAllButton = new System.Windows.Forms.Button();
            this.listSelectAllButton = new System.Windows.Forms.Button();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.openTempFileButton = new System.Windows.Forms.Button();
            this.userRankList = new System.Windows.Forms.ListView();
            this.rankNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.replyNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.debugCommentCheckBox = new System.Windows.Forms.CheckBox();
            this.openCommentViewer = new System.Windows.Forms.Button();
            this.targetUserTextbox = new System.Windows.Forms.TextBox();
            this.saveCommentUserButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.debugFolderPathTextbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.loadingTextUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.isMiniRadio = new System.Windows.Forms.RadioButton();
            this.isMinorRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isMajorRadio = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pageStatusText);
            this.tabPage1.Controls.Add(this.pageStatusProgress);
            this.tabPage1.Controls.Add(this.logConsole);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "갤러리 설정";
            // 
            // pageStatusText
            // 
            this.pageStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageStatusText.AutoSize = true;
            this.pageStatusText.Location = new System.Drawing.Point(137, 332);
            this.pageStatusText.Name = "pageStatusText";
            this.pageStatusText.Size = new System.Drawing.Size(89, 12);
            this.pageStatusText.TabIndex = 15;
            this.pageStatusText.Text = "0 중 0 처리중...";
            this.pageStatusText.Visible = false;
            // 
            // pageStatusProgress
            // 
            this.pageStatusProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageStatusProgress.Location = new System.Drawing.Point(138, 306);
            this.pageStatusProgress.Name = "pageStatusProgress";
            this.pageStatusProgress.Size = new System.Drawing.Size(121, 18);
            this.pageStatusProgress.TabIndex = 16;
            this.pageStatusProgress.Visible = false;
            // 
            // logConsole
            // 
            this.logConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logConsole.Location = new System.Drawing.Point(387, 11);
            this.logConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logConsole.Multiline = true;
            this.logConsole.Name = "logConsole";
            this.logConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logConsole.Size = new System.Drawing.Size(456, 333);
            this.logConsole.TabIndex = 22;
            // 
            // gallIDCheckStatus
            // 
            this.gallIDCheckStatus.AutoSize = true;
            this.gallIDCheckStatus.ForeColor = System.Drawing.Color.Green;
            this.gallIDCheckStatus.Location = new System.Drawing.Point(15, 399);
            this.gallIDCheckStatus.Name = "gallIDCheckStatus";
            this.gallIDCheckStatus.Size = new System.Drawing.Size(117, 12);
            this.gallIDCheckStatus.TabIndex = 15;
            this.gallIDCheckStatus.Text = "검증을 완료했습니다";
            this.gallIDCheckStatus.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "갤러리 ID 검증";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(81, 255);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 21);
            this.endDatePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "끝 날짜";
            // 
            // analyzeStartButton
            // 
            this.analyzeStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.analyzeStartButton.Location = new System.Drawing.Point(6, 301);
            this.analyzeStartButton.Name = "analyzeStartButton";
            this.analyzeStartButton.Size = new System.Drawing.Size(116, 50);
            this.analyzeStartButton.TabIndex = 14;
            this.analyzeStartButton.Text = "집계 시작";
            this.analyzeStartButton.UseVisualStyleBackColor = true;
            this.analyzeStartButton.Click += new System.EventHandler(this.analyzeStartButton_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(81, 228);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 21);
            this.startDatePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "시작 날짜";
            // 
            // endPageNumberTextbox
            // 
            this.endPageNumberTextbox.Location = new System.Drawing.Point(122, 167);
            this.endPageNumberTextbox.Name = "endPageNumberTextbox";
            this.endPageNumberTextbox.Size = new System.Drawing.Size(100, 21);
            this.endPageNumberTextbox.TabIndex = 6;
            this.endPageNumberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // startPageNumberTextbox
            // 
            this.startPageNumberTextbox.Location = new System.Drawing.Point(122, 138);
            this.startPageNumberTextbox.Name = "startPageNumberTextbox";
            this.startPageNumberTextbox.Size = new System.Drawing.Size(100, 21);
            this.startPageNumberTextbox.TabIndex = 5;
            this.startPageNumberTextbox.Text = "1";
            this.startPageNumberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "끝 페이지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "시작 페이지 (필수)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "갤러리 ID";
            // 
            // gallIDTextBox
            // 
            this.gallIDTextBox.Location = new System.Drawing.Point(6, 33);
            this.gallIDTextBox.Name = "gallIDTextBox";
            this.gallIDTextBox.Size = new System.Drawing.Size(177, 21);
            this.gallIDTextBox.TabIndex = 1;
            this.gallIDTextBox.TextChanged += new System.EventHandler(this.GalleryIDTextbox_Changed);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveProgress);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "결과 후처리/저장";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveProgress
            // 
            this.saveProgress.Location = new System.Drawing.Point(533, 316);
            this.saveProgress.Name = "saveProgress";
            this.saveProgress.Size = new System.Drawing.Size(311, 34);
            this.saveProgress.TabIndex = 11;
            this.saveProgress.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "닉네임 검색";
            // 
            // autoMergeButton
            // 
            this.autoMergeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoMergeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.autoMergeButton.Font = new System.Drawing.Font("굴림", 9F);
            this.autoMergeButton.ForeColor = System.Drawing.Color.White;
            this.autoMergeButton.Location = new System.Drawing.Point(536, 236);
            this.autoMergeButton.Name = "autoMergeButton";
            this.autoMergeButton.Size = new System.Drawing.Size(308, 35);
            this.autoMergeButton.TabIndex = 8;
            this.autoMergeButton.Text = "유저 자동 병합";
            this.autoMergeButton.UseVisualStyleBackColor = false;
            this.autoMergeButton.Click += new System.EventHandler(this.autoMergeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(756, 95);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 26);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(534, 97);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(215, 21);
            this.searchTextBox.TabIndex = 6;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileButton.Location = new System.Drawing.Point(533, 316);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(311, 35);
            this.saveFileButton.TabIndex = 5;
            this.saveFileButton.Text = "파일 저장";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // listDeselectAllButton
            // 
            this.listDeselectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listDeselectAllButton.Location = new System.Drawing.Point(534, 191);
            this.listDeselectAllButton.Name = "listDeselectAllButton";
            this.listDeselectAllButton.Size = new System.Drawing.Size(311, 26);
            this.listDeselectAllButton.TabIndex = 4;
            this.listDeselectAllButton.Text = "모두 선택 해제";
            this.listDeselectAllButton.UseVisualStyleBackColor = true;
            this.listDeselectAllButton.Click += new System.EventHandler(this.listDeselectAllButton_Click);
            // 
            // listSelectAllButton
            // 
            this.listSelectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listSelectAllButton.Location = new System.Drawing.Point(534, 159);
            this.listSelectAllButton.Name = "listSelectAllButton";
            this.listSelectAllButton.Size = new System.Drawing.Size(311, 26);
            this.listSelectAllButton.TabIndex = 3;
            this.listSelectAllButton.Text = "모두 선택";
            this.listSelectAllButton.UseVisualStyleBackColor = true;
            this.listSelectAllButton.Click += new System.EventHandler(this.listSelectAllButton_Click);
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextbox.Location = new System.Drawing.Point(626, 18);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.ReadOnly = true;
            this.fileNameTextbox.Size = new System.Drawing.Size(218, 21);
            this.fileNameTextbox.TabIndex = 2;
            this.fileNameTextbox.Text = "이곳에 파일 이름이 표시됩니다";
            // 
            // openTempFileButton
            // 
            this.openTempFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openTempFileButton.Location = new System.Drawing.Point(533, 6);
            this.openTempFileButton.Name = "openTempFileButton";
            this.openTempFileButton.Size = new System.Drawing.Size(87, 44);
            this.openTempFileButton.TabIndex = 1;
            this.openTempFileButton.Text = "데이터\r\n불러오기";
            this.openTempFileButton.UseVisualStyleBackColor = true;
            this.openTempFileButton.Click += new System.EventHandler(this.openTempFileButton_Click);
            // 
            // userRankList
            // 
            this.userRankList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userRankList.CheckBoxes = true;
            this.userRankList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rankNum,
            this.userNick,
            this.replyNum});
            this.userRankList.FullRowSelect = true;
            this.userRankList.HideSelection = false;
            this.userRankList.Location = new System.Drawing.Point(6, 6);
            this.userRankList.Name = "userRankList";
            this.userRankList.Size = new System.Drawing.Size(521, 345);
            this.userRankList.TabIndex = 0;
            this.userRankList.UseCompatibleStateImageBehavior = false;
            this.userRankList.View = System.Windows.Forms.View.Details;
            // 
            // rankNum
            // 
            this.rankNum.Text = "순위";
            // 
            // userNick
            // 
            this.userNick.Text = "닉네임/IP";
            this.userNick.Width = 250;
            // 
            // replyNum
            // 
            this.replyNum.Text = "댓글 수";
            this.replyNum.Width = 120;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.debugFolderPathTextbox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(851, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "디버깅";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.debugCommentCheckBox);
            this.panel1.Controls.Add(this.openCommentViewer);
            this.panel1.Controls.Add(this.targetUserTextbox);
            this.panel1.Controls.Add(this.saveCommentUserButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(15, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 119);
            this.panel1.TabIndex = 7;
            // 
            // debugCommentCheckBox
            // 
            this.debugCommentCheckBox.AutoSize = true;
            this.debugCommentCheckBox.Location = new System.Drawing.Point(12, 13);
            this.debugCommentCheckBox.Name = "debugCommentCheckBox";
            this.debugCommentCheckBox.Size = new System.Drawing.Size(132, 16);
            this.debugCommentCheckBox.TabIndex = 0;
            this.debugCommentCheckBox.Text = "유저 댓글 내용 기록";
            this.debugCommentCheckBox.UseVisualStyleBackColor = true;
            this.debugCommentCheckBox.CheckedChanged += new System.EventHandler(this.debugCommentCheckBox_CheckedChanged);
            // 
            // openCommentViewer
            // 
            this.openCommentViewer.Location = new System.Drawing.Point(12, 65);
            this.openCommentViewer.Name = "openCommentViewer";
            this.openCommentViewer.Size = new System.Drawing.Size(296, 41);
            this.openCommentViewer.TabIndex = 6;
            this.openCommentViewer.Text = "댓글 내용 뷰어 열기";
            this.openCommentViewer.UseVisualStyleBackColor = true;
            this.openCommentViewer.Click += new System.EventHandler(this.openCommentViewer_Click);
            // 
            // targetUserTextbox
            // 
            this.targetUserTextbox.Location = new System.Drawing.Point(113, 37);
            this.targetUserTextbox.Name = "targetUserTextbox";
            this.targetUserTextbox.Size = new System.Drawing.Size(114, 21);
            this.targetUserTextbox.TabIndex = 3;
            // 
            // saveCommentUserButton
            // 
            this.saveCommentUserButton.Location = new System.Drawing.Point(233, 36);
            this.saveCommentUserButton.Name = "saveCommentUserButton";
            this.saveCommentUserButton.Size = new System.Drawing.Size(75, 23);
            this.saveCommentUserButton.TabIndex = 5;
            this.saveCommentUserButton.Text = "저장";
            this.saveCommentUserButton.UseVisualStyleBackColor = true;
            this.saveCommentUserButton.Click += new System.EventHandler(this.saveCommentUserButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "대상 유저 닉네임";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "디버그 기록 저장 위치";
            // 
            // debugFolderPathTextbox
            // 
            this.debugFolderPathTextbox.Location = new System.Drawing.Point(144, 14);
            this.debugFolderPathTextbox.Name = "debugFolderPathTextbox";
            this.debugFolderPathTextbox.ReadOnly = true;
            this.debugFolderPathTextbox.Size = new System.Drawing.Size(321, 21);
            this.debugFolderPathTextbox.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(699, 440);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "이 프로그램의 제작자 GITHUB";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "DC 댓글 랭킹 프로그램";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(746, 419);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(121, 12);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "사용방법 도움말 보기";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // loadingTextUpdate
            // 
            this.loadingTextUpdate.Tick += new System.EventHandler(this.loadingTextUpdate_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            // 
            // isMiniRadio
            // 
            this.isMiniRadio.AutoSize = true;
            this.isMiniRadio.Location = new System.Drawing.Point(6, 65);
            this.isMiniRadio.Name = "isMiniRadio";
            this.isMiniRadio.Size = new System.Drawing.Size(123, 16);
            this.isMiniRadio.TabIndex = 23;
            this.isMiniRadio.TabStop = true;
            this.isMiniRadio.Text = "미니 갤러리입니다";
            this.isMiniRadio.UseVisualStyleBackColor = true;
            // 
            // isMinorRadio
            // 
            this.isMinorRadio.AutoSize = true;
            this.isMinorRadio.Location = new System.Drawing.Point(6, 43);
            this.isMinorRadio.Name = "isMinorRadio";
            this.isMinorRadio.Size = new System.Drawing.Size(135, 16);
            this.isMinorRadio.TabIndex = 24;
            this.isMinorRadio.TabStop = true;
            this.isMinorRadio.Text = "마이너 갤러리입니다";
            this.isMinorRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isMajorRadio);
            this.groupBox1.Controls.Add(this.isMinorRadio);
            this.groupBox1.Controls.Add(this.isMiniRadio);
            this.groupBox1.Location = new System.Drawing.Point(189, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 90);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "갤러리 타입";
            // 
            // isMajorRadio
            // 
            this.isMajorRadio.AutoSize = true;
            this.isMajorRadio.Checked = true;
            this.isMajorRadio.Location = new System.Drawing.Point(6, 21);
            this.isMajorRadio.Name = "isMajorRadio";
            this.isMajorRadio.Size = new System.Drawing.Size(135, 16);
            this.isMajorRadio.TabIndex = 25;
            this.isMajorRadio.TabStop = true;
            this.isMajorRadio.Text = "메이저 갤러리입니다";
            this.isMajorRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gallIDCheckStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

				private global::System.Windows.Forms.Label label9;

				private global::System.Windows.Forms.TextBox targetUserTextbox;

				private global::System.Windows.Forms.Button saveCommentUserButton;

				private global::System.Windows.Forms.ProgressBar saveProgress;

				private global::System.Windows.Forms.Button openCommentViewer;

				private global::System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton isMajorRadio;
        private System.Windows.Forms.RadioButton isMinorRadio;
        private System.Windows.Forms.RadioButton isMiniRadio;
    }
}
