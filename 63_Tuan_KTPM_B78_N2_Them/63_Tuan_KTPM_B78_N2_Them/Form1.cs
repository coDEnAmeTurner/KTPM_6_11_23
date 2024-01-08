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
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;

namespace _63_Tuan_KTPM_B78_N2_Them
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLoginFB_Click(object sender, EventArgs e)
        {
            //====================================== KHỞI TẠO =====================================================
            // 63 - Khởi tạo trình duyệt Chrome 
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(service, options);


            //====================================== ĐĂNG NHẬP =====================================================
            // 63 - Mở trang Facebook
            driver  .Navigate().GoToUrl("https://www.facebook.com");

            // 63 - Điền thông tin đăng nhập
            driver  .FindElement(By.Id("email")) // tai khoan
                    .SendKeys("weary15@gmail.com");

            driver  .FindElement(By.Id("pass")) // mat khau
                    .SendKeys("NRk:jeTxV_KC4Dq");

            // 63 - Click nút Đăng nhập
            driver  .FindElement(By.Name("login"))
                    .Click();

            // 63 - Khởi tạo biến chờ các phần tử trang web trong 10 giây
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // 63 - Đợi cho trang đăng nhập thành công
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("facebook.com"));

            // 63 - Nhấn ESC để thoát màn hình xám ban đầu
            Actions exitFirstBox = new Actions(driver);
            exitFirstBox.SendKeys(OpenQA.Selenium.Keys.Escape).Build().Perform();


            //====================================== ĐĂNG BÀI =====================================================
            // 63 - Mở giao diện đăng bài
            driver  .FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div/div[3]/div/div[2]/div/div/div/div[2]/div[2]/div[1]"))
                    .Click();
            Thread  .Sleep(3000); // đợi 3s để các phần tử của cửa sổ đăng bài load hoàn toàn

            driver  .FindElement(By.CssSelector("p[class='xdj266r x11i5rnm xat24cr x1mh8g0r x16tdsg8']"))
                    .SendKeys("This is an automated post using Selenium WebDriver!");

            // 63 - upload picture
            driver  .FindElement(By.CssSelector("input[class='x1s85apg']"))
                    .SendKeys(@"D:\infoSSD.jpg");

            // 63 - Tag
            Thread  .Sleep(3000);
            driver  .FindElement(By.CssSelector("img[src='https://static.xx.fbcdn.net/rsrc.php/v3/yq/r/b37mHA1PjfK.png']"))
                    .Click();

            // 63 - Tìm kiếm bạn bè:
            wait    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementIsVisible(By.CssSelector("input[aria-label='Tìm kiếm bạn bè']")))
                    .SendKeys("T");

            // 63 - Chọn người đầu tiên tìm thấy:
            wait    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementIsVisible(By.CssSelector("div[class='xexx8yu x1sxyh0 x18d9i69 xurb0ha x111uhmu']")))
                    .Click();
            
            // 63 - Quay lại và Đăng bài:
            wait    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementIsVisible(By.CssSelector("[aria-label='Quay lại']")))
                    .Click();

            wait    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementIsVisible(By.CssSelector("[aria-label='Đăng']")))
                    .Click();


            //====================================== BÌNH LUẬN =====================================================
            // 63 - Đợi cho bài viết được đăng thành công
            Thread.Sleep(5000);

            // 63 - Gửi comment
            driver  .FindElement(By.CssSelector("[aria-label='Viết bình luận...']"))
                    .SendKeys("Selenium Comment!");

            Thread  .Sleep(3000);
            driver  .FindElement(By.CssSelector("[aria-label='Bình luận']"))
                    .Click();

            // 63 - Đợi cho comment được gửi thành công

        }
    }
}
