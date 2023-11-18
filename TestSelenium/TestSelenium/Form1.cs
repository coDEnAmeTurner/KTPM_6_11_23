using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestSelenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpenBrowser_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.vn/");
            driver.FindElement(By.Id("email")).SendKeys("");
            textBox1.Text = driver.Url;
        }
    }
}