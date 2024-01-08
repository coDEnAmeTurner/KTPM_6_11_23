using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _63_Tuan_KTPM_B78_N2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpenBrowser_Click(object sender, EventArgs e)
        {
            // Huy 76 - Cau 2
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://thanhnien.vn/");

            //IReadOnlyCollection <IWebElement> links = driver.FindElements(By.TagName("a"));

            //foreach (IWebElement link in links)
            //    listBox1.Items.Add(link.Text);

            // Huy 76 - Cau 3:
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demo.guru99.com/test/upload/");
            //IWebElement fileInput = driver.FindElement(By.CssSelector("input[type=file]"));
            //fileInput.SendKeys(@"D:\dothiluc.jpg");
            //driver.FindElement(By.Id("submitbutton")).Click();


            // Huy 76 - Cau 4:
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/delete_customer.php");

            driver.FindElement(By.Name("cusid")).SendKeys("53920");
            driver.FindElement(By.Name("submit")).Submit();

            IAlert alr = driver.SwitchTo().Alert();
            Console.WriteLine(alr.Text);
            alr.Accept();
        }
    }
}
