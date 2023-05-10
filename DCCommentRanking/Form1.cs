using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DCCommentRanking.Properties;
using Newtonsoft.Json;

namespace DCCommentRanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.InitializeSettings();
            this.debugFolderPathTextbox.Text = Directory.GetCurrentDirectory() + "\\debug";
            string path = Directory.GetCurrentDirectory() + "\\debug";
            string path2 = Directory.GetCurrentDirectory() + "\\results";
            string path3 = Directory.GetCurrentDirectory() + "\\temp";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!Directory.Exists(path3))
            {
                Directory.CreateDirectory(path3);
            }
            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }
            this.startDatePicker.Value = DateTime.Today;
            this.endDatePicker.Value = DateTime.Today;
        }

        private void InitializeSettings()
        {
            this.debugCommentCheckBox.Checked = Settings.Default.DebugComment;
            this.targetUserTextbox.Text = Settings.Default.DebugCommentUserName;
        }

        private void DCEventHandler(object sender, DCEventArgs e)
        {
            if (this.logConsole.InvokeRequired)
            {
                base.Invoke(new MethodInvoker(delegate ()
                {
                    this.DCEventHandler(sender, e);
                }));
                return;
            }
            if (this.logConsole.Lines.Length > 1000)
            {
                this.logConsole.Clear();
            }
            this.logConsole.AppendText(Environment.NewLine + e.DCLogger);
        }

        private void OnStatusChanged(object sender, DCStatusEventArgs e)
        {
            if (this.pageStatusProgress.InvokeRequired)
            {
                base.Invoke(new MethodInvoker(delegate ()
                {
                    this.OnStatusChanged(sender, e);
                }));
                return;
            }
            int tc = e.DCStatus.tc;
            int cc = e.DCStatus.cc;
            this.pageStatusProgress.Maximum = tc;
            this.pageStatusProgress.Value = cc;
            if (this.pageStatusText.InvokeRequired)
            {
                base.Invoke(new MethodInvoker(delegate ()
                {
                    this.OnStatusChanged(sender, e);
                }));
                return;
            }
            this.pageStatusText.Text = tc.ToString() + " 중 " + cc.ToString() + " 처리중";
        }

        public bool checkIsDateInRange(DateTime dateToCheck)
        {
            return dateToCheck >= this.startDate && dateToCheck <= this.endDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.gallIDTextBox.Text.Length == 0 || this.gallIDTextBox.Text.ToString() == "")
            {
                MessageBox.Show("갤러리 ID를 입력해야합니다");
                return;
            }
            this.button1.Enabled = false;
            if (this.dc.CheckGallery(this.gallIDTextBox.Text, this.isMinorCheckbox.Checked))
            {
                this.button1.Enabled = true;
                this.gallIDCheckStatus.Visible = true;
                this.gallIDCheckStatus.Text = "갤러리 ID 검증을 완료했습니다\n" + this.dc.gallName;
                this.gallIDCheckStatus.ForeColor = Color.Green;
                this.isGallCheckComplete = true;
                return;
            }
            this.button1.Enabled = true;
            this.gallIDCheckStatus.Visible = true;
            this.gallIDCheckStatus.Text = "갤러리 ID 검증에 실패했습니다\n존재하지 않는 갤러리인가요?";
            this.gallIDCheckStatus.ForeColor = Color.Red;
            this.isGallCheckComplete = false;
        }

        private void GalleryIDTextbox_Changed(object sender, EventArgs e)
        {
            if (this.isGallCheckComplete)
            {
                this.gallIDCheckStatus.Text = "갤러리 ID가 변동되었습니다\n다시 검증 버튼을 눌러주세요";
                this.gallIDCheckStatus.ForeColor = Color.Black;
                this.isGallCheckComplete = false;
            }
        }

        private void analyzeStartButton_Click(object sender, EventArgs e)
        {
            if (!this.isGallCheckComplete)
            {
                MessageBox.Show("갤러리 ID 검증을 완료해야합니다\n상단에서 갤러리 ID 입력후 검증 버튼을 눌러주세요");
                return;
            }
            if (this.startPageNumberTextbox.Text == "")
            {
                MessageBox.Show("시작 페이지 번호를 입력해야합니다");
                return;
            }
            if (this.endPageNumberTextbox.Text != "" && int.Parse(this.startPageNumberTextbox.Text) > int.Parse(this.endPageNumberTextbox.Text))
            {
                MessageBox.Show("시작 페이지 번호가 끝 페이지 번호보다 클 수 없습니다.");
                return;
            }
            int num = DateTime.Compare(this.startDatePicker.Value, this.endDatePicker.Value);
            if (num != 0 && num > 0)
            {
                MessageBox.Show("시작 날짜가 끝 날짜보다 늦을 수 없습니다.\n\n올바른 예시) 시작 날짜 : 5월 1일, 끝 날짜 : 5월 6일");
                return;
            }
            this.pageStatusProgress.Visible = true;
            this.pageStatusText.Visible = true;
            this.pageStatusText.Text = "처리중...";
            DateTime dateTime = new DateTime(this.startDatePicker.Value.Year, this.startDatePicker.Value.Month, this.startDatePicker.Value.Day, 0, 0, 0);
            DateTime dateTime2 = new DateTime(this.endDatePicker.Value.Year, this.endDatePicker.Value.Month, this.endDatePicker.Value.Day, 23, 59, 59);

            this.dc.eventHandler += this.DCEventHandler;
            this.dc.statusChanged += this.OnStatusChanged;
            this.dc.AnalyzeGallery(this.startPageNumberTextbox.Text, this.endPageNumberTextbox.Text, dateTime, dateTime2);
            this.logConsole.AppendText(Environment.NewLine + Environment.NewLine + "[[댓글 기록 수집 완료]]");
            this.notifyIcon1.ShowBalloonTip(5000, "수집 완료", "댓글 수집을 완료했습니다.\n프로그램으로 돌아와 결과를 생성해주세요.", ToolTipIcon.Info);
            this.dc.saveTempFile();
            this.dc = new DCHelper();
            this.gallIDTextBox.Text = "";
            this.gallIDCheckStatus.ForeColor = Color.Black;
            this.gallIDCheckStatus.Text = "작업 완료.\n다시 시작하려면 검증을 해주세요";
            this.pageStatusText.Visible = false;
            this.pageStatusProgress.Visible = false;
        }

        private void testGetButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.startDatePicker.Value.ToString() + " | " + this.endDatePicker.Value.ToString());
            this.startDatePicker.Value = default(DateTime);
            if (DateTime.Compare(this.startDatePicker.Value, this.endDatePicker.Value) > 0)
            {
                MessageBox.Show("시작 날짜가 끝 날짜보다 일찍 시작될 수 없습니다.\n\n올바른 예시) 시작 날짜 : 5월 1일, 끝 날짜 : 5월 6일");
                return;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://amusemap.notion.site/76800a341d05447aaa8fed8f8378b6ba");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/OFox213/DCRanking");
        }

        private void onlyNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void loadingTextUpdate_Tick(object sender, EventArgs e)
        {
        }

        private void openTempFileButton_Click(object sender, EventArgs e)
        {
            OpenTempForm openTempForm = new OpenTempForm("temp");
            if (openTempForm.ShowDialog() == DialogResult.OK)
            {
                this.rankFileName = openTempForm.selectedFileName;
                this.fileNameTextbox.Text = this.rankFileName;
                string path = Directory.GetCurrentDirectory() + "\\temp\\" + this.rankFileName;
                try
                {
                    using (StreamReader streamReader = new StreamReader(path))
                    {
                        string value = streamReader.ReadToEnd();
                        this.uir = JsonConvert.DeserializeObject<List<DCHelper.UserInfoRank>>(value);
                    }
                    IOrderedEnumerable<DCHelper.UserInfoRank> source = from usr in this.uir
                                                                       orderby usr.replyCount descending
                                                                       select usr;
                    this.uir = source.ToList<DCHelper.UserInfoRank>();
                    this.userRankList.Items.Clear();
                    int num = 0;
                    foreach (DCHelper.UserInfoRank userInfoRank in this.uir)
                    {
                        num++;
                        ListViewItem value2 = new ListViewItem(new string[]
                        {
                            num.ToString() + "위",
                            userInfoRank.name,
                            userInfoRank.replyCount.ToString() + "개"
                        });
                        this.userRankList.Items.Add(value2);
                    }
                    this.userRankList.Refresh();
                }
                catch
                {
                    MessageBox.Show("아무것도 선택하지 않았거나 파일이 삭제되었습니다.");
                }
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (this.rankFileName == null)
            {
                MessageBox.Show("저장하려면 먼저 전처리한 파일을 선택해야합니다.");
                return;
            }
            SaveRanking saveRanking = new SaveRanking(this.rankFileName.Split(new char[]
            {
                '_'
            })[0] + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss-fff") + ".댓글랭킹.txt", this.uir);
            if (saveRanking.ShowDialog() == DialogResult.OK)
            {
                this.SaveToText(saveRanking.fileName, saveRanking.maximumRankingNum, saveRanking.miniumReplyCount);
            }
        }

        private void listSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.userRankList.Items)
            {
                ((ListViewItem)obj).Checked = true;
            }
        }

        private void listDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.userRankList.Items)
            {
                ((ListViewItem)obj).Checked = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.userRankList.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.SubItems[1].Text.Contains(this.searchTextBox.Text))
                {
                    listViewItem.Checked = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (object obj in this.userRankList.SelectedItems)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                list.Add(listViewItem.Index);
            }
            this.userRankList.Items.Clear();
            list.Min();
            foreach (int num in list)
            {
            }
        }

        public void SaveToText(string filename, int maximumRank, int minimumCount)
        {
            this.saveProgress.Visible = true;
            string text = Directory.GetCurrentDirectory() + "\\results\\";
            Directory.CreateDirectory(text);
            using (StreamWriter streamWriter = new StreamWriter(text + filename))
            {
                int num = 0;
                foreach (DCHelper.UserInfoRank userInfoRank in this.uir)
                {
                    num += userInfoRank.replyCount;
                }
                this.saveProgress.Maximum = num;
                streamWriter.WriteLine("DCRanking 댓글 랭킹 by OFox");
                streamWriter.WriteLine("총 댓글 수: " + num.ToString());
                streamWriter.WriteLine("랭킹\t닉\t댓글 수\t갤 지분");
                int num2 = 0;
                int num3 = 0;
                for (int i = 0; i < this.uir.Count; i++)
                {
                    num2++;
                    this.saveProgress.Value = i;
                    if (num2 == 1)
                    {
                        num3 = 1;
                    }
                    else if (this.uir[i - 1].replyCount != this.uir[i].replyCount)
                    {
                        num3 = num2;
                    }
                    if (num3 > maximumRank || this.uir[i].replyCount < minimumCount)
                    {
                        break;
                    }
                    double num4 = (double)(10000 * this.uir[i].replyCount / num) / 100.0;
                    string text2 = this.uir[i].name;
                    if (!this.uir[i].isFluid)
                    {
                        text2 = text2 + " (" + this.uir[i].uid + ")";
                    }
                    string value = string.Concat(new string[]
                    {
                        num3.ToString(),
                        "위\t",
                        text2,
                        "\t",
                        this.uir[i].replyCount.ToString(),
                        "개\t",
                        num4.ToString(),
                        "%"
                    });
                    streamWriter.WriteLine(value);
                }
                streamWriter.Close();
                this.notifyIcon1.ShowBalloonTip(2000, "저장 완료", filename + "을 저장하였습니다.", ToolTipIcon.Info);
                this.saveProgress.Visible = false;
            }
        }

        private void saveCommentUserButton_Click(object sender, EventArgs e)
        {
            Settings.Default.DebugCommentUserName = this.targetUserTextbox.Text;
            Settings.Default.Save();
            this.notifyIcon1.ShowBalloonTip(2000, "설정 변경됨", "대상 유저를 지정하였습니다.", ToolTipIcon.Info);
        }

        private void debugCommentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DebugComment = this.debugCommentCheckBox.Checked;
            Settings.Default.Save();
        }

        private void openCommentViewer_Click(object sender, EventArgs e)
        {
            OpenTempForm openTempForm = new OpenTempForm("debug");
            if (openTempForm.ShowDialog() == DialogResult.OK)
            {
                this.rankFileName = openTempForm.selectedFileName;
                this.fileNameTextbox.Text = this.rankFileName;
                string dir = Directory.GetCurrentDirectory() + "\\debug\\" + this.rankFileName;
                try
                {
                    new CommentViewer(dir).ShowDialog();
                }
                catch
                {
                    MessageBox.Show("아무것도 선택하지 않았거나 파일이 삭제되었습니다.");
                }
            }
        }

        private DCHelper dc = new DCHelper();

        private DateTime startDate;

        private DateTime endDate;

        private bool isGallCheckComplete;

        private string rankFileName;

        public List<DCHelper.UserInfoRank> uir = new List<DCHelper.UserInfoRank>();
    }
}
