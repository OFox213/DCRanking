using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using DCCommentRanking.Properties;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace DCCommentRanking
{
    public class DCHelper
    {
        public string gallID, gallName, gallUrl;
        private int startPage,endPage;
        public DateTime startDate,endDate;

        public List<DCHelper.UserInfo> userInfos = new List<DCHelper.UserInfo>();
        public List<DCHelper.UserInfoRank> userRanks = new List<DCHelper.UserInfoRank>();
        private Dictionary<DCHelper.UserInfo, int[]> userDic = new Dictionary<DCHelper.UserInfo, int[]>();
        private List<DCHelper.UserCommentDebugData> userCommentDebug = new List<DCHelper.UserCommentDebugData>();

        private bool commentDebugger;
        private string commentDebuggerTarget = "";
        public delegate void LogMessageEventHandler(object sender, DCEventArgs args);
        public delegate void StatusChangedEventHandler(object sender, DCStatusEventArgs args);
        public event DCHelper.LogMessageEventHandler eventHandler;

        private bool loggerEnabled = false;

        protected virtual void OnNewLog(string logMessage)
        {
            if (this.eventHandler != null)
            {
                this.eventHandler(this, new DCEventArgs(logMessage));
            }
        }

        public event DCHelper.StatusChangedEventHandler statusChanged;

        protected virtual void OnStatusChanged(int tc, int cc)
        {
            if (this.statusChanged != null)
            {
                this.statusChanged(this, new DCStatusEventArgs(tc, cc));
            }
        }

        public void AnalyzeGallery(string startPage, string endPage, DateTime startDate, DateTime endDate)
        {
            if (this.gallID == null || this.gallID == "")
            {
                this.OnNewLog("갤러리 검증을 먼저 해야합니다");
                return;
            }
            this.startPage = int.Parse(startPage);
            if (endPage == "")
            {
                this.endPage = -1;
            }
            else
            {
                this.endPage = int.Parse(endPage);
            }
            this.startDate = startDate;
            this.endDate = endDate;
            TimeSpan timeSpan = endDate - startDate;
            this.commentDebugger = Settings.Default.DebugComment;
            this.commentDebuggerTarget = Settings.Default.DebugCommentUserName;
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            int num = this.startPage;
            for (; ; )
            {
                string html;
                try
                {
                    html = webClient.DownloadString(this.gallUrl + "&page=" + num.ToString());
                }
                catch (Exception ex)
                {
                    html = "";
                    this.OnNewLog(ex.Message);
                }
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);
                HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//tr[@class='ub-content us-post']");
                try
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlNodeCollection))
                    {
                        int onlyInt = this.GetOnlyInt(htmlNode.SelectSingleNode("./td[@class='gall_num']").InnerText);
                        DateTime t = DateTime.ParseExact(htmlNode.SelectSingleNode("./td[@class='gall_date']").Attributes["title"].Value, "yyyy-MM-dd HH:mm:ss", null);
                        if (onlyInt >= 1000000000)
                        {
                            this.OnNewLog(onlyInt.ToString() + " | " + t.ToString() + " | GallNum Error");
                        }
                        else if (DateTime.Compare(t, startDate) < 0 || DateTime.Compare(t, endDate) > 0)
                        {
                            this.OnNewLog(onlyInt.ToString() + " | " + t.ToString() + " 날짜 스킵됨");
                        }
                        else
                        {
                            HtmlNode htmlNode2 = htmlNode.SelectSingleNode("./td[@class='gall_writer ub-writer']");
                            string value = htmlNode2.Attributes["data-nick"].Value;
                            if (htmlNode2.Attributes["data-uid"].Value == "")
                            {
                                string value2 = htmlNode2.Attributes["data-ip"].Value;
                            }
                            else
                            {
                                string value3 = htmlNode2.Attributes["data-uid"].Value;
                            }
                            HtmlNode htmlNode3 = htmlNode.SelectSingleNode("./td[2]");
                            int num2;
                            try
                            {
                                if (htmlNode3.Attributes["class"].Value == "gall_subject")
                                {
                                    htmlNode3 = htmlNode.SelectSingleNode("./td[3]");
                                }
                                if (htmlNode3.SelectNodes("./a").Count == 2)
                                {
                                    num2 = this.GetOnlyInt(htmlNode3.SelectSingleNode("./a[@class='reply_numbox']/span").InnerText);
                                }
                                else
                                {
                                    num2 = 0;
                                }
                            }
                            catch
                            {
                                num2 = 0;
                            }
                            if (loggerEnabled)
                            {
                                Console.WriteLine(string.Concat(new string[]
                           {
                                onlyInt.ToString(),
                                " | 댓글수 : ",
                                num2.ToString(),
                                " < ",
                                t.ToString()
                           }));

                            }

                            if (num2 > 0)
                            {
                                if (onlyInt > 0)
                                {
                                    if (loggerEnabled)
                                    {
                                        this.OnNewLog(string.Concat(new string[]
{
                                onlyInt.ToString(),
                                " | 댓글수 : ",
                                num2.ToString(),
                                " < ",
                                t.ToString()
}));
                                    }

                                    this.getComment(this.gallID, onlyInt.ToString(), "1");
                                }
                                else
                                {
                                    Console.WriteLine("공지 게시글 건너뜀");
                                    this.OnNewLog("공지 게시글 건너뜀");
                                }
                            }
                        }
                    }
                    DateTime dateTime = DateTime.ParseExact(htmlNodeCollection[htmlNodeCollection.Count - 1].SelectSingleNode("./td[@class='gall_date']").Attributes["title"].Value, "yyyy-MM-dd HH:mm:ss", null);
                    if (this.endPage == -1)
                    {
                        if (DateTime.Compare(dateTime, startDate) < 0)
                        {
                            break;
                        }
                        num++;
                        int days = (dateTime - startDate).Days;
                        this.OnStatusChanged(timeSpan.Days, days);
                    }
                    else
                    {
                        if (num >= this.endPage || DateTime.Compare(dateTime, startDate) < 0)
                        {
                            break;
                        }
                        num++;
                        this.OnStatusChanged(this.endPage, num);
                    }
                    continue;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        public void getTest()
        {
            if (this.gallID == null || this.gallID == "")
            {
                Console.WriteLine("갤러리 검증을 먼저 해야합니다");
                return;
            }
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            int num = 1;
            string html;
            try
            {
                html = webClient.DownloadString(this.gallUrl + "&page=" + num.ToString());
            }
            catch (Exception ex)
            {
                html = "";
                Console.WriteLine(ex.Message);
            }
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//tr[@class='ub-content us-post']");
            try
            {
                foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlNodeCollection))
                {
                    int onlyInt = this.GetOnlyInt(htmlNode.SelectSingleNode("./td[@class='gall_num']").InnerText);
                    DateTime t = DateTime.ParseExact(htmlNode.SelectSingleNode("./td[@class='gall_date']").Attributes["title"].Value, "yyyy-MM-dd HH:mm:ss", null);
                    if (onlyInt >= 1000000000)
                    {
                        Console.WriteLine("GallNum Error");
                    }
                    else if (DateTime.Compare(t, this.startDate) < 0 || DateTime.Compare(t, this.endDate) > 0)
                    {
                        Console.WriteLine("날짜 스킵됨");
                    }
                    else
                    {
                        HtmlNode htmlNode2 = htmlNode.SelectSingleNode("./td[@class='gall_writer ub-writer']");
                        string value = htmlNode2.Attributes["data-nick"].Value;
                        if (htmlNode2.Attributes["data-uid"].Value == "")
                        {
                            string value2 = htmlNode2.Attributes["data-ip"].Value;
                        }
                        else
                        {
                            string value3 = htmlNode2.Attributes["data-uid"].Value;
                        }
                        HtmlNode htmlNode3 = htmlNode.SelectSingleNode("./td[2]");
                        string text;
                        int num2;
                        try
                        {
                            if (htmlNode3.Attributes["class"].Value == "gall_subject")
                            {
                                htmlNode3 = htmlNode.SelectSingleNode("./td[3]");
                            }
                            text = htmlNode3.SelectSingleNode("./a[1]").InnerText;
                            if (htmlNode3.SelectNodes("./a").Count == 2)
                            {
                                num2 = this.GetOnlyInt(htmlNode3.SelectSingleNode("./a[@class='reply_numbox']/span").InnerText);
                            }
                            else
                            {
                                num2 = 0;
                            }
                        }
                        catch
                        {
                            text = "";
                            num2 = 0;
                        }
                        Console.WriteLine(string.Concat(new string[]
                        {
                            onlyInt.ToString(),
                            " | ",
                            num2.ToString(),
                            " < ",
                            text,
                            " | ",
                            t.ToString()
                        }));
                        if (num2 > 0)
                        {
                            if (onlyInt > 0)
                            {
                                this.getComment(this.gallID, onlyInt.ToString(), "1");
                            }
                            else
                            {
                                Console.WriteLine("공지 게시글 건너뜀");
                            }
                        }
                    }
                }
                int num3 = this.endPage;
            }
            catch (Exception)
            {
            }
        }

        public void getComment(string gallID, string gallNum, string page)
        {
            Console.WriteLine(string.Concat(new string[]
            {
                "[CommentCollector] ",
                gallID,
                " : ",
                gallNum,
                " | 페이지 : ",
                page
            }));
            this.OnNewLog(string.Concat(new string[]
            {
                "[CommentCollector] ",
                gallID,
                " : ",
                gallNum,
                " | 페이지 : ",
                page
            }));
            try
            {
                byte[] bytes = new WebClient().UploadValues("https://m.dcinside.com/ajax/response-comment", "POST", new NameValueCollection
                {
                    {
                        "id",
                        gallID
                    },
                    {
                        "no",
                        gallNum
                    },
                    {
                        "cpage",
                        page
                    },
                    {
                        "managerskill",
                        ""
                    },
                    {
                        "csort",
                        ""
                    },
                    {
                        "permission_pw",
                        ""
                    }
                });
                string @string = Encoding.UTF8.GetString(bytes);
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(@string);
                HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//li[contains(@class, 'comment')]");
                if (htmlNodeCollection != null)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlNodeCollection))
                    {
                        HtmlNode htmlNode2 = htmlNode.SelectSingleNode("./a[1]");
                        HtmlNode htmlNode3 = htmlNode.SelectSingleNode("./a/span[@class='blockCommentId']");
                        if (htmlNode2 == null)
                        {
                            Console.WriteLine(string.Concat(new string[]
                            {
                                "[CommentCollector] ",
                                gallID,
                                " : ",
                                gallNum,
                                " | 삭제된 댓글이 포함되어 있어 제외되었습니다."
                            }));
                        }
                        else
                        {
                            string innerText = htmlNode2.InnerText;
                            string text;
                            bool flag;
                            if (htmlNode3 == null)
                            {
                                htmlNode3 = htmlNode.SelectSingleNode("./a/span[@class='ip blockCommentIp']");
                                text = htmlNode3.InnerText.Replace("(", "").Replace(")", "");
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                                text = htmlNode3.Attributes["data-info"].Value;
                            }
                            DCHelper.UserInfo userInfo = new DCHelper.UserInfo(innerText);
                            if (flag)
                            {
                                userInfo.setFluidUser(text);
                            }
                            else
                            {
                                userInfo.setFixedUser(text);
                            }
                            if (this.commentDebugger && innerText == this.commentDebuggerTarget)
                            {
                                string innerText2 = htmlNode.SelectSingleNode("p").InnerText;
                                this.userCommentDebug.Add(new DCHelper.UserCommentDebugData(innerText, innerText2, gallID, gallNum));
                            }
                            if (this.userDic.ContainsKey(userInfo))
                            {
                                this.userDic[userInfo][0]++;
                            }
                            else
                            {
                                int[] value = new int[]
                                {
                                    1
                                };
                                this.userDic.Add(userInfo, value);
                            }
                        }
                    }
                    HtmlNode htmlNode4 = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='paging alg-ct']/div[@class='rt']/div[@class='sel-box']/select");
                    if (htmlNode4 != null)
                    {
                        HtmlNodeCollection htmlNodeCollection2 = htmlNode4.SelectNodes("./option");
                        Console.WriteLine("전체 " + htmlNodeCollection2.Count.ToString() + " 페이지");
                        if (htmlNodeCollection2.Count > int.Parse(page))
                        {
                            this.getComment(gallID, gallNum, (int.Parse(page) + 1).ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.OnNewLog(ex.ToString());
            }
        }

        public void saveTempFile()
        {
            foreach (KeyValuePair<DCHelper.UserInfo, int[]> keyValuePair in this.userDic)
            {
                DCHelper.UserInfo key = keyValuePair.Key;
                key.replyCount = keyValuePair.Value[0];
                this.userRanks.Add(new DCHelper.UserInfoRank(key.name, key.uid, key.ip, key.isFluid, keyValuePair.Value[0]));
            }
            string text = Directory.GetCurrentDirectory() + "\\temp\\";
            Directory.CreateDirectory(text);
            string text2 = this.gallID + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss-ff") + ".predata.json";
            using (StreamWriter streamWriter = new StreamWriter(text + text2))
            {
                streamWriter.Write(JsonConvert.SerializeObject(this.userRanks));
                streamWriter.Close();
                Console.WriteLine(text2 + " 저장완료");
            }
            if (this.commentDebugger)
            {
                string str = Directory.GetCurrentDirectory() + "\\debug\\";
                string text3 = string.Concat(new string[]
                {
                    this.gallID,
                    DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss-ff"),
                    "-",
                    this.commentDebuggerTarget,
                    ".commentDebug.json"
                });
                using (StreamWriter streamWriter2 = new StreamWriter(str + text3))
                {
                    streamWriter2.Write(JsonConvert.SerializeObject(this.userCommentDebug));
                    streamWriter2.Close();
                    Console.WriteLine(text3 + " 저장완료");
                }
            }
        }

        public bool CheckGallery(string gallID, int gallType)
        {
            string defaultAddress = "https://gall.dcinside.com/board/lists/?id=" + gallID;
            string address = defaultAddress;
            if (gallType == 0) address = defaultAddress;
            else if (gallType == 1) address = "https://gall.dcinside.com/mgallery/board/lists?id=" + gallID;
            else if (gallType == 2) address = "https://gall.dcinside.com/mini/board/lists?id=" + gallID;


            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html;
            try
            {
                html = webClient.DownloadString(address);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                this.OnNewLog(ex.Message);
                this.gallName = null;
                this.gallUrl = null;
                this.gallID = null;
                return false;
            }
            HtmlDocument htmlDocument = new HtmlDocument();
            bool result;
            try
            {
                htmlDocument.LoadHtml(html);
                HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode("//title");
                if (htmlNode != null)
                {
                    this.gallName = htmlNode.InnerText;
                    this.gallUrl = address;
                    this.gallID = gallID;
                    this.OnNewLog("갤러리 확인됨 - " + this.gallName);
                    this.OnNewLog("대상 갤러리 주소 : " + this.gallUrl);
                    result = true;
                }
                else
                {
                    this.gallName = null;
                    this.gallUrl = null;
                    this.gallID = null;
                    result = false;
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                this.OnNewLog(ex2.Message);
                this.gallName = null;
                this.gallUrl = null;
                this.gallID = null;
                result = false;
            }
            return result;
        }

        private int GetOnlyInt(string str)
        {
            Match match = new Regex("\\d+").Match(str);
            if (match.Success)
            {
                return int.Parse(match.Value);
            }
            return -1;
        }



        [Serializable]
        public class UserInfo
        {
            public UserInfo()
            {
            }

            public UserInfo(string name)
            {
                this.name = name;
            }

            public UserInfo(string name, string uid, string ip, bool isFluid)
            {
                this.name = name;
                this.uid = uid;
                this.ip = ip;
                this.isFluid = isFluid;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                DCHelper.UserInfo userInfo = obj as DCHelper.UserInfo;
                return this.name.Equals(userInfo.name) && this.ip.Equals(userInfo.ip) && this.uid.Equals(userInfo.uid);
            }

            public override int GetHashCode()
            {
                return (this.name + "(" + this.ip + ")").GetHashCode();
            }

            public void setFixedUser(string uid)
            {
                this.isFluid = false;
                this.uid = uid;
                this.ip = "";
            }

            public void setFluidUser(string ip)
            {
                this.isFluid = true;
                this.uid = "";
                this.ip = ip;
            }

            public string name;

            public string ip;

            public string uid;

            public int replyCount;

            public bool isFluid;
        }

        [Serializable]
        public class UserInfoRank
        {
            public UserInfoRank()
            {
            }

            public UserInfoRank(string name)
            {
                this.name = name;
            }

            public UserInfoRank(string name, string uid, string ip, bool isFluid, int replyCount, bool pass = false)
            {
                this.name = name;
                this.uid = uid;
                this.ip = ip;
                this.isFluid = isFluid;
                this.replyCount = replyCount;
                this.pass = pass;
            }

            public string name;

            public string ip;

            public string uid;

            public int replyCount;

            public bool isFluid;

            public bool pass;
        }

        [Serializable]
        public class UserCommentDebugData
        {
            public UserCommentDebugData(string name, string comment, string gallID, string gallNum)
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
