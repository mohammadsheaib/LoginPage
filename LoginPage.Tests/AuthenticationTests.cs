//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

namespace LoginPage.Tests
{
    public class AuthenticationTests
    {
        //        private IWebDriver driver;

        //        [SetUp]
        //        public void Setup()
        //        {
        //            // Create a new instance of ChromeDriver
        //            driver = new ChromeDriver();
        //        }

        //        [TearDown]
        //        public void TearDown()
        //        {
        //            // Close the browser after each test
        //            driver.Quit();
        //        }

        //        [Test]
        //        public void TestLogin_ValidCredentials()
        //        {
        //            // Navigate to the login page
        //            driver.Navigate().GoToUrl("http://localhost:5237/api/authentication/login");

        //            // Find the username and password input fields
        //            var usernameInput = driver.FindElement(By.Id("username"));
        //            var passwordInput = driver.FindElement(By.Id("password"));

        //            // Enter valid credentials
        //            usernameInput.SendKeys("username");
        //            passwordInput.SendKeys("pass");

        //            // Find and click the login button
        //            var loginButton = driver.FindElement(By.Id("loginButton"));
        //            loginButton.Click();

        //            // Wait for the page to load and get the message element
        //            var messageElement = driver.FindElement(By.Id("message"));

        //            // Assert that the message is "Login successful!"
        //            Assert.AreEqual("Login successful!", messageElement.Text);
        //        }

        //        [Test]
        //        public void TestLogin_InvalidCredentials()
        //        {
        //            // Navigate to the login page
        //            driver.Navigate().GoToUrl("http://localhost:5173/login");

        //            // Find the username and password input fields
        //            var usernameInput = driver.FindElement(By.Id("username"));
        //            var passwordInput = driver.FindElement(By.Id("password"));

        //            // Enter invalid credentials
        //            usernameInput.SendKeys("invalid_username");
        //            passwordInput.SendKeys("invalid_password");

        //            // Find and click the login button
        //            var loginButton = driver.FindElement(By.Id("loginButton"));
        //            loginButton.Click();v

        //            // Wait for the page to load and get the message element
        //            var messageElement = driver.FindElement(By.Id("message"));

        //            // Assert that the message is "Invalid credentials."
        //            Assert.AreEqual("Invalid credentials.", messageElement.Text);
        //        }
    }
}
