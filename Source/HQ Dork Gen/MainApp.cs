using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.IO;

namespace HQ_Dork_Gen
{
    /* 
    *  Software Development By: Pix4Devs
    *  Website: Pix4.dev
    *  Developed by: Z3NTL3
    *  
    *  This application is made for educational purposes only
    *  -- It is not allowed to earn money from this application we have made
    *  
    *  By opening the source of this application you automatically apply to this usage conditions
    */
    public partial class MainApp : Form
    {

        public MainApp()
        {
            InitializeComponent();
        }

        public class Global
        {
            public static string content;
            public static bool processDone;
            public static bool started;
            public static bool fileErr;
            public static List<string> ourGithub = new List<string>()
            {
                "https://github.com/Pix4Devs",
                "https://github.com/Z3NTL3"
            };
        }
        public class ScrapedContentReader
        {
            private string Content;
            public ScrapedContentReader(string content)
            {
                this.Content = content;
            }

            public HtmlAgilityPack.HtmlNodeCollection Parser()
            {
                var htmDocument = new HtmlAgilityPack.HtmlDocument();
                htmDocument.LoadHtml(Content);

                var hqWords = htmDocument.DocumentNode.SelectNodes("//*[@id='result']/li");
                return hqWords;

            }
        }

        private IWebDriver ConfigBot()
        {
            var chromeOptions = new ChromeOptions();

            List<string> jobsToDo = new List<string>()
            {
                "headless",
                "--silent",
                "--window-size=1920,1080"
            };

            foreach (string job in jobsToDo)
            {
                chromeOptions.AddArgument(job);
            }
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(service, chromeOptions);

            return driver;
        }

        public class XPATH
        {
            private string Xpath;
            private int Time;
            private IWebDriver Driver;

            public XPATH(IWebDriver driver, string path, int time)
            {
                var elem = new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(path)));
                this.Xpath = path;
                this.Time = time;
                this.Driver = driver;
            }

            public void Click()
            {
                Driver.FindElement(By.XPath(Xpath)).Click();
            }

            public void SendKeys(string key)
            {
                Driver.FindElement(By.XPath(Xpath)).SendKeys(key);
            }
            public void Clear()
            {
                Driver.FindElement(By.XPath(Xpath)).Clear();
            }

            public string GetContent()
            {
                string cnt = Driver.FindElement(By.XPath(Xpath)).GetAttribute("innerHTML");

                return cnt;
            }

            public void Quit()
            {
                Driver.Quit();
            }
        }

 
        private void GenerateDorks_Click(object sender, EventArgs e)
        {
            if (Global.processDone == true)
            {
                try
                {
                    if (dorkCollection.Items.Contains(dorkCollection.SelectedItem))
                    {
                        statusTXT.ForeColor = Color.Green;
                        statusTXT.Text = "   BOT Scraped";
                        ScrapedContentReader readerScrap = new ScrapedContentReader(Global.content);
                        var words = readerScrap.Parser();

                        dorkListBox.Text = "";
                        foreach (var w in words)
                        {

                            dorkListBox.Text = dorkListBox.Text + dorkCollection.SelectedItem + w.InnerText + "\n";
                        }

                        dorkListBox.Text = dorkListBox.Text.Trim(' ');
                        dorkListBox.Text = dorkListBox.Text.Trim('\n');
                        Logger("Generated HQ Dorks");
                    }
                    else
                    {
                        MessageBox.Show("Bot is currently started please wait", "Bot started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Please select a item", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                

            }
            else if(Global.started == false)
            {
                MessageBox.Show("Bot is not being started please start the bot", "Bot not started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bot is scraping please wait","Bot is scraping wait",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.fileErr = false;
            var dir = Directory.GetCurrentDirectory();
            List<string> dlls = new List<string>()
            {
                "Bunifu_UI_v1.5.3.dll",
                "chromedriver.exe",
                "HtmlAgilityPack.dll",
                "SeleniumExtras.WaitHelpers.dll",
                "WebDriver.dll",
                "WebDriver.Support.dll"
            };

            if (Global.processDone != true)
            {
                statusTXT.ForeColor = Color.Red;
                statusTXT.Text = "Not Scraped Yet";
            }
            
            foreach(var dll in dlls)
            {

                if (File.Exists(dir + "\\" + dll))
                {

                }
                else
                {
                    Global.fileErr = true;
                }
            }
            if (Global.fileErr)
            {
                MessageBox.Show("You are missing required file for this application. DDLS not found", "DLL Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void ScraperBot()
        {
            Global.processDone = false;

            IWebDriver driver = ConfigBot();
            driver.Navigate().GoToUrl("https://randomwordgenerator.com/");

            XPATH awaiterX = new XPATH(driver, "/html/body/div[7]/div[2]/div[1]/div[2]/div[2]/button[1]/p", 15);
            awaiterX.Click();

            List<string> jobsToDo = new List<string>()
            {
                "//input[@id='qty']",
                "//input[@name='submit']"
            };

            foreach (var job in jobsToDo)
            {
                if (job == jobsToDo[0])
                {
                    XPATH amount = new XPATH(driver, job, 15);
                    amount.Clear();
                    amount.SendKeys("50");
                }
                else
                {
                    XPATH submitBtn = new XPATH(driver, job, 15);
                    submitBtn.Click();
                }
            }

            XPATH awaiter = new XPATH(driver, "//*[@id='loading_result']", 15);
            string cnt = awaiter.GetContent();

            Global.content = cnt;
            driver.Quit();

            Global.processDone = true;
            Global.started = true;
            
        }
        private void Logger(string msg){
            consoleLogs.ForeColor = Color.Green;
            consoleLogs.Text = consoleLogs.Text + DateTime.Now + $" | {msg}\n\n";    
        }
        private void LoadBot_Click(object sender, EventArgs e)
        {
            Global.started = false;
            Global.processDone = false;
            Global.started = true;
            statusTXT.ForeColor = Color.Red;
            statusTXT.Text = "Not Scraped Yet";
            Thread th = new Thread(ScraperBot);
            try
            {
                Logger("Bot started");
                th.IsBackground = true;
                th.Start();


               
            }
            catch{
                th.Abort();
            }
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var beSure = MessageBox.Show("Are you sure you want to close the application?",
                "Software Exit Attempt",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (beSure == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.started)
            {
                if (Global.processDone)
                {
                    statusTXT.ForeColor = Color.Green;
                    statusTXT.Text = "   BOT Scraped";
                    Logger("Bot operations are done you can generate now");
                }
                else
                {
                    MessageBox.Show("Bot started scraping please wait","Process loading just wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                MessageBox.Show("Bot is not started, start it by clicking on 'Load Bot'","Bot not started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addDorkBTN_Click(object sender, EventArgs e)
        {
            if(dorkCollection.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("This dork exists already", "Dork Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dorkCollection.Items.Add(textBox1.Text);
                Logger("Dork is been added");
            }
           
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var thisDir = Directory.GetCurrentDirectory();
            var saveDir = thisDir + "\\dorks";

            SaveFileDialog saveScript = new SaveFileDialog();
            saveScript.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveScript.Title = "Save your LUA Script";

            if (saveScript.ShowDialog() == DialogResult.OK)

            {
                if (saveScript.FileName != "")
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(saveScript.FileName);
                        writer.Write(dorkListBox.Text.ToString());
                        writer.Flush();
                        writer.Close();
                        MessageBox.Show(
                       "Dorks are saved",
                       "Dorks saved",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);


                    }
                    catch
                    {
                        MessageBox.Show(
                       "File is used by another process. Cannot access it!",
                       "Error: file is in use",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                    );
                    }

                }
                else
                {
                    MessageBox.Show(
                       "Empty filename",
                       "Filename error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }
        private void OurGithubOpener()
        {
            foreach (var github in Global.ourGithub)
            {
                System.Diagnostics.Process.Start(github);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OurGithubOpener);
            th.Start();
        }
    }
}
