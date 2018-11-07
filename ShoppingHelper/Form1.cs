using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ShoppingHelper
{
    public partial class Form1 : Form
    {
        static IWebDriver GCDriver;
        bool targetCheck, amazonCheck, walMartCheck;
        string inputSearch;
        new List<string> amazonNameList, amazonPriceList;
        new List<Label> amazonNameLabel, amazonPriceLabel;
        public Form1()
        {
            InitializeComponent();
            GCDriver = new ChromeDriver();
            /*
             * option for hiding chrome
            var options = new ChromeOptions();
            options.AddArgument("headless");
            ptions.AddArguments("--incognito");
            GCDriver = new ChromeDriver(options);
             */
            amazonPriceList = new List<string>();
            amazonNameList = new List<string>();
            amazonNameLabel = new List<Label>();
            amazonPriceLabel = new List<Label>();

        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            inputSearch = inputTextBox.Text;
            if(amazonCheckBx.Checked==true)
            {
                AmazonSearch(inputSearch);
            }

        }
        /// <summary>
        /// Searches Amazon for the provided item and populates the amazon lists<>
        /// </summary>
        /// <param name="input"></param>
        private void AmazonSearch(string input)
        {
            GCDriver.Navigate().GoToUrl("https://www.amazon.com/");
            GCDriver.FindElement(By.Name("field-keywords")).SendKeys(input);
            GCDriver.FindElement(By.ClassName("nav-input")).Click();

            //first
            amazonNameList.Add(GCDriver.FindElement(By.XPath("//*[@id='result_2']/div/div/div/div[2]/div[1]/div[1]/a/h2")).Text);
            amazonPriceList.Add(amazonPrice1.Text = "$"+GCDriver.FindElements(By.ClassName("sx-price-whole"))[2].Text);
            //second
            amazonNameList.Add(GCDriver.FindElement(By.XPath("//*[@id='result_3']/div/div/div/div[2]/div[1]/div[1]/a/h2")).Text);
            amazonPriceList.Add(amazonPrice1.Text = "$" + GCDriver.FindElements(By.ClassName("sx-price-whole"))[3].Text);
            //third
            amazonNameList.Add(GCDriver.FindElement(By.XPath("//*[@id='result_4']/div/div/div/div[2]/div[1]/div[1]/a/h2")).Text);
            amazonPriceList.Add(amazonPrice1.Text = "$" + GCDriver.FindElements(By.ClassName("sx-price-whole"))[4].Text);
        }
        /// <summary>
        /// populates the amazon labels with the information from the search
        /// </summary>
        private void AmazonLoadLabel()
        {
            for(int i=0;i<amazonNameList.Count-1;i++)
            {
                amazonNameLabel[i].Text = amazonNameList[i];
                amazonPriceLabel[i].Text = amazonPriceList[i];
            }
        }
    }
}
