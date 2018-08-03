using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace AutoFB.Action
{
    public class FbAction
    {
        private IWebDriver driver;

        private static FbAction _instance = new FbAction();

        public const string HOME_PAGE = "https://www.facebook.com";

        /// <summary>
        /// Constructor FbAction
        /// </summary>
        protected FbAction()
        {           
            #region chrome driver
            ChromeOptions option = new ChromeOptions();            
            option.AddArgument("--disable-notifications"); //this option for disable notification on browser
            //option.AddArgument("-headless");//this option for show/hide browser
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.SuppressInitialDiagnosticInformation = true;
            service.HideCommandPromptWindow = true;
            driver = new ChromeDriver(service, option);
            #endregion
        }

        /// <summary>
        /// Unique FbAction
        /// </summary>
        /// <returns></returns>
        public static FbAction GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FbAction();
            }

            return _instance;
        }

        /// <summary>
        /// Login Function
        /// </summary>
        /// <param name="_user"></param>
        /// <param name="_pass"></param>
        public void Login(string _user, string _pass)
        {
            try
            {
                if (!EncodeAction.Login(_user, _pass))
                {
                    return;
                }
                //check if not login
                if (!driver.PageSource.Contains("_1vp5"))
                {
                    //set url drvier
                    driver.Url = "https://www.facebook.com/login";
                    //set username
                    driver.FindElement(By.Id("email")).SendKeys(_user);
                    //set password
                    driver.FindElement(By.Id("pass")).SendKeys(_pass);
                    //click login button
                    driver.FindElement(By.Id("loginbutton")).Click();
                }
                //if login
                else
                {
                    //go to HOME_PAGE
                    driver.Navigate().GoToUrl(HOME_PAGE);
                }
            }
            catch(Exception ex)
            {
                return;
            }
            
        }

        /// <summary>
        /// Like post function
        /// </summary>
        /// <param name="_urlList"></param>
        public void LikePost(string [] _urlList)
        {
            try
            {
                //if not login then return
                if (!driver.PageSource.Contains("_1vp5"))
                {
                    return;
                }

                //loop in list url need to be liked
                foreach (string url in _urlList)
                {
                    //go to url
                    driver.Navigate().GoToUrl(url);
                    //get all button have classname UFILikeLink
                    ReadOnlyCollection<IWebElement> likeButtons = driver.FindElements(By.ClassName("UFILikeLink"));
                    //check exists element in collection likeButtons
                    if (likeButtons.Count > 0)
                    {
                        //like button is first element
                        IWebElement like = likeButtons[0];
                        //like action
                        if (like.GetAttribute("aria-pressed") == "false")
                        {
                            like.Click();
                        }
                        //love action
                        else
                        {
                            Actions action = new Actions(driver);
                            action.MoveToElement(like).Perform();
                            Thread.Sleep(1000);
                            driver.FindElement(By.XPath("//*[@data-testid='reaction_2']")).Click();
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            catch(Exception ex)
            {
                return;
            }
                  
        }

        /// <summary>
        /// Post status function
        /// </summary>
        /// <param name="_contentList"></param>
        public void PostStatus(string[] _contentList)
        {
            try
            {
                if (!driver.PageSource.Contains("_1vp5"))
                {
                    return;
                }
                foreach (string data in _contentList)
                {
                    driver.Navigate().GoToUrl("https://www.facebook.com");
                    //post status
                    IWebElement status = driver.FindElement(By.XPath("//*[@name='xhpc_message']"));
                    status.Click();
                    status.SendKeys(data);
                    Thread.Sleep(3000);
                    ReadOnlyCollection<IWebElement> buttons = driver.FindElements(By.TagName("button"));
                    foreach (var button in buttons)
                    {
                        if ("Post".Equals(button.Text) || "Đăng".Equals(button.Text))
                        {
                            button.Click();
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                    Thread.Sleep(2000);
                }
            }
            catch(Exception ex)
            {
                return;
            }            
        }

        /// <summary>
        /// Post comment
        /// </summary>
        /// <param name="_urlList"></param>
        /// <param name="_content"></param>
        public void PostComment(string[] _urlList, string _content)
        {
            try
            {
                if (!driver.PageSource.Contains("_1vp5"))
                {
                    return;
                }
                foreach (string url in _urlList)
                {
                    driver.Navigate().GoToUrl(url);
                    driver.FindElement(By.ClassName("comment_link")).Click();
                    Thread.Sleep(500);
                    IWebElement textbox = driver.FindElement(By.XPath("//*[@role='textbox']"));
                    textbox.SendKeys(_content);
                    textbox.SendKeys(Keys.Enter);
                    Thread.Sleep(1000);
                }
            }
            catch(Exception ex)
            {
                return;
            }              
        }

        /// <summary>
        /// Close driver
        /// </summary>
        public void Close()
        {
            try
            {
                driver.Quit();
            }
            catch(Exception ex)
            {
                return;
            }
        }
            
    }
}
