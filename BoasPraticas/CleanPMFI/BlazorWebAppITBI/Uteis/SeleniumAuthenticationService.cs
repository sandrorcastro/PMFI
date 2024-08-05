using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;
namespace BlazorWebAppITBI.Uteis
{
    
    public class SeleniumAuthenticationService
    {
        public async Task<string> AuthenticateAndGetSessionIdAsync(string username, string password)
        {
            var options = new ChromeOptions();
            options.AddArgument("headless"); // Executa o navegador em modo headless (sem interface gráfica)

            using (var driver = new ChromeDriver(options))
            {
                try
                {
                    driver.Navigate().GoToUrl("http://www2.pmfi.pr.gov.br/GiiG/Autenticacao/defaultpmfi.aspx");

                    // Preencha o formulário de login
                    var usernameField = driver.FindElement(By.Name("txtlogin"));
                    var passwordField = driver.FindElement(By.Name("txtsenha"));
                    var loginButton = driver.FindElement(By.Name("btnlogin"));

                    usernameField.SendKeys(username);
                    passwordField.SendKeys(password);
                    loginButton.Click();

                    // Aguarde um tempo para a resposta e redirecionamentos
                    await Task.Delay(2000);

                    // Captura os cookies
                    var cookies = driver.Manage().Cookies.AllCookies;
                    foreach (var cookie in cookies)
                    {
                        if (cookie.Name == "ASP.NET_SessionId")
                        {
                            return cookie.Value;
                        }
                    }

                    throw new Exception("Session ID not found in cookies");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw;
                }
            }
        }
    }

}


/* para usar crie um método como:
 *   
 public async Task TestAuthentication()
    {
        var authService = new SeleniumAuthenticationService();
        var sessionId = await authService.AuthenticateAndGetSessionIdAsync("Sandro.src", "S@ndro1972");

        Console.WriteLine($"Session ID: {sessionId}");
    }
*/