using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver chrom = new ChromeDriver();
            chrom.Navigate().GoToUrl("http://www.google.com/");
            chrom.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            chrom.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys("8886140959");
            chrom.FindElement(By.XPath("//*[@id=\"pass\"]")).SendKeys("140959");
            chrom.FindElement(By.XPath("//button[@class=\"_42ft _4jy0 _6lth _4jy6 _4jy1 selected _51sy\"]")).Click();


        }
    }
}
