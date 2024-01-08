using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _63_Tuan_N2_B6_Them
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGetById_Click(object sender, EventArgs e)
        {
            // 76 - Huy
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            driver.Navigate().GoToUrl("https://www.google.com.vn/");
            driver.FindElement(By.Id("APjFqb")).SendKeys(txtInput.Text);

            Thread.Sleep(3000);
            driver.FindElement(By.Name("btnK")).Click();

        }

        private void btByClassName_Click(object sender, EventArgs e)
        {
            // 76 - Huy
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            driver.Navigate().GoToUrl("https://www.google.com.vn");
            driver.FindElement(By.ClassName("gb_B")).Click();

            txtURL.Text = driver.Url;
        }

        private void btByTagName_Click(object sender, EventArgs e)
        {
            // 76 - Huy
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://thanhnien.vn/");

            IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.TagName("li"));

            foreach (IWebElement element in elements)
                listBox1.Items.Add(element.Text);
        }

        private void btByLinkText_Click(object sender, EventArgs e)
        {
            // 76 - Huy
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://thanhnien.vn/");
            driver.FindElement(By.LinkText("Thời sự")).Click();
            txtURL2.Text = driver.Url; 
        }

        private void btByCssSelector_Click(object sender, EventArgs e)
        {
            // 76 - Huy
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://facebook.com/login");

            driver.FindElement(By.CssSelector("input[class='inputtext _55r1 inputtext _1kbt inputtext _1kbt']")).SendKeys(txtTK.Text);

            driver.FindElement(By.CssSelector("#pass")).SendKeys(txtMK.Text);

            driver.FindElement(By.CssSelector("div._xkt>button")).Click();
        }

        private void btByXPath_Click(object sender, EventArgs e)
        {
            // 76 - Huy
            IWebDriver driver = new ChromeDriver();
            driver  .Navigate().GoToUrl("https://facebook.com/login");

            // đường dẫn tương đối email 
            driver.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys("username"); 

            // đường dẫn tuyệt đối password
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[2]/div[2]/form/div/div[2]/div/div/input")).SendKeys("password");

        }
    }
}
