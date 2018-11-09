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
        new Item item1, item2, item3;
        
        new List<Label> amazonNameLabel, amazonPriceLabel;
        new List<Item> amazonItemList;

        new List<Label> walMartNameLabel, walMartPriceLabel;
        new List<Item> walMartItemList;

        new List<Label> targetNameLabel, TargetPriceLabel;
        new List<Item> targetItemList;

        public Form1()
        {
            InitializeComponent();
            
            
             
            var options = new ChromeOptions();
            options.AddArgument("headless");
            options.AddArguments("--incognito");
            GCDriver = new ChromeDriver(options);
             
            amazonItemList = new List<Item>();
            amazonNameLabel = new List<Label>() { amazonLabel1, amazonLabel2,amazonLabel3 };
            amazonPriceLabel = new List<Label>(){ amazonPrice1, amazonPrice2,amazonPrice3 };

            walMartItemList = new List<Item>();
            walMartNameLabel = new List<Label>() { WalMartLabel1, walMartLabel2, walMartLabel3 };
            walMartPriceLabel = new List<Label>() { walMartPrice1, walMartPrice2, walrMartPrice3 };

            targetItemList = new List<Item>();
            targetNameLabel = new List<Label>() { TargetName1, targetName2, targetName3 };
            TargetPriceLabel = new List<Label>() { targetPrice1, targetPrice2, targetPrice3 };
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            inputSearch = inputTextBox.Text;
            if(amazonCheckBx.Checked==true)
            {
                AmazonSearch(inputSearch);
                AmazonLoadLabel();
            }

            if(walMartCheckBx.Checked==true)
            {
                WalMartSearch(inputSearch);
                WalMartLoadLabel();
            }

            if(targetCheckBx.Checked==true)
            {
                TargetSearch(inputSearch);
                TargetLoad();
            }


            
        }
        /// <summary>
        /// Searches Amazon for the provided item and populates the amazon lists<>
        /// </summary>
        /// <param name="input"></param>
        private void AmazonSearch(string input)
        {
            Item item;
            GCDriver.Navigate().GoToUrl("https://www.amazon.com/");
            GCDriver.FindElement(By.Name("field-keywords")).SendKeys(input);
            GCDriver.FindElement(By.ClassName("nav-input")).Click();

            //first
            string name=GCDriver.FindElement(By.XPath("//*[@id='result_2']/div/div/div/div[2]/div[1]/div[1]/a/h2")).Text;
            string price="$"+GCDriver.FindElements(By.ClassName("sx-price-whole"))[2].Text;
            item = new Item(name, price);
            amazonItemList.Add(item);
            //second
            name=GCDriver.FindElement(By.XPath("//*[@id='result_3']/div/div/div/div[2]/div[1]/div[1]/a/h2")).Text;
            price="$" + GCDriver.FindElements(By.ClassName("sx-price-whole"))[3].Text;
            item2 = new Item(name, price);
            amazonItemList.Add(item2);
            //third
            name =GCDriver.FindElement(By.XPath("//*[@id='result_4']/div/div/div/div[2]/div[1]/div[1]/a/h2")).Text;
            price="$" + GCDriver.FindElements(By.ClassName("sx-price-whole"))[4].Text;
            item3 = new Item(name, price);
            amazonItemList.Add(item3);
        }
        /// <summary>
        /// populates the amazon labels with the information from the search
        /// </summary>
        private void AmazonLoadLabel()
        {
            for(int i=0;i<=amazonItemList.Count-1;i++)
            {
                amazonNameLabel[i].Text = amazonItemList[i].Name;
                amazonPriceLabel[i].Text = amazonItemList[i].Price;
            }
        }
        public void WalMartSearch(string input)
        {
            Item item;
            GCDriver.Navigate().GoToUrl("https://www.walmart.com/");
            GCDriver.FindElement(By.Name("query")).SendKeys(input);
            GCDriver.FindElement(By.XPath("//*[@id='global-search-form']/div/div[3]/div/button/span/span")).Click();
            //first
           string name = GCDriver.FindElement(By.XPath("//*[@id='searchProductResult']/ul/li[1]/div/div[2]/div[5]/div/span[2]/a/span")).Text;
           string price ="$"+GCDriver.FindElement(By.XPath("//*[@id='searchProductResult']/ul/li[1]/div/div[2]/div[7]/div/span/div/div/div/span/span/span[2]")).Text;
            item = new Item(name, price);
            walMartItemList.Add(item);
            //2nd
            name = GCDriver.FindElement(By.XPath("//*[@id='searchProductResult']/ul/li[2]/div/div[2]/div[5]/div/span[2]/a/span")).Text;
            price = "$" + GCDriver.FindElement(By.XPath("//*[@id='searchProductResult']/ul/li[2]/div/div[2]/div[7]/div/span/div/div/div/span/span/span[2]")).Text;
            item2 = new Item(name, price);
            walMartItemList.Add(item2);
            //3rd
            name = GCDriver.FindElement(By.XPath("//*[@id='searchProductResult']/ul/li[3]/div/div[2]/div[5]/div/span[2]/a/span")).Text;
            price = "$" + GCDriver.FindElement(By.XPath("//*[@id='searchProductResult']/ul/li[3]/div/div[2]/div[7]/div/span/div/div/div/span[1]/span/span/span[2]")).Text;
            item3 = new Item(name, price);
            walMartItemList.Add(item3);

        }
        private void WalMartLoadLabel()
        {
            for (int i = 0; i <= walMartItemList.Count - 1; i++)
            {
                walMartNameLabel[i].Text = walMartItemList[i].Name;
                walMartPriceLabel[i].Text = walMartItemList[i].Price;
            }
        }
        private void TargetSearch(string input)
        {
            Item item;
            GCDriver.Navigate().GoToUrl("https://www.target.com/");
            GCDriver.FindElement(By.XPath("//*[@id='search']")).SendKeys(input);
            GCDriver.FindElement(By.XPath("//*[@id='headerMain']/div[1]/form/button[2]")).Click();

            System.Threading.Thread.Sleep(3000);
            //first
            string name = GCDriver.FindElements(By.ClassName("h-display-flex"))[20].Text;
            string price = GCDriver.FindElement(By.XPath("//*[@id='mainContainer']/div[4]/div/div/div[1]/div[3]/div/ul/li[1]/div/div[2]/div/div/div/div[2]/span")).Text;
            item = new Item(name, price);
            targetItemList.Add(item);
            //2nd
            //name = GCDriver.FindElements(By.ClassName("h-display-flex"))[27].Text;
            name = GCDriver.FindElement(By.XPath("//*[@id='mainContainer']/div[4]/div/div/div[1]/div[3]/div/ul/li[2]/div/div[2]/div/div/div/div[1]/div/div[1]")).Text;
            price =GCDriver.FindElement(By.XPath("//*[@id='mainContainer']/div[4]/div/div/div[1]/div[3]/div/ul/li[2]/div/div[2]/div/div/div/div[2]/span")).Text;
            item2 = new Item(name, price);
            targetItemList.Add(item2);
            //3rd
            //name = GCDriver.FindElements(By.ClassName("h-display-flex"))[34].Text;
            name = GCDriver.FindElement(By.XPath("//*[@id='mainContainer']/div[4]/div/div/div[1]/div[3]/div/ul/li[3]/div/div[2]/div/div/div/div[1]/div/div[1]")).Text;
            price =GCDriver.FindElement(By.XPath("//*[@id='mainContainer']/div[4]/div/div/div[1]/div[3]/div/ul/li[3]/div/div[2]/div/div/div/div[2]/span")).Text;
            item3 = new Item(name, price);
            targetItemList.Add(item3);

        }
        private void TargetLoad()
        {
            for (int i = 0; i <= targetItemList.Count - 1; i++)
            {
                targetNameLabel[i].Text = targetItemList[i].Name;
                TargetPriceLabel[i].Text = targetItemList[i].Price;
            }
        }
    }
}
