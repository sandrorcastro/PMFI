using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
//using HtmlAgilityPack; // Biblioteca para parsear HTML
namespace BlazorWebAppITBI.Uteis
{

    public class AuthenticationService
    {
        private readonly HttpClient _httpClient;

        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AuthenticateAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password must not be null or empty");
            }

            // Passo 1: Obter a página de login e extrair os valores de campos ocultos
            var loginPageResponse = await _httpClient.GetAsync("http://www2.pmfi.pr.gov.br/GiiG/Autenticacao/defaultpmfi.aspx");
            var loginPageContent = await loginPageResponse.Content.ReadAsStringAsync();

            var doc = new HtmlDocument();
            doc.LoadHtml(loginPageContent);

            var viewState = doc.DocumentNode.SelectSingleNode("//input[@id='__VIEWSTATE']")?.GetAttributeValue("value", "");
            var eventValidation = doc.DocumentNode.SelectSingleNode("//input[@id='__EVENTVALIDATION']")?.GetAttributeValue("value", "");
            var viewStateGenerator = doc.DocumentNode.SelectSingleNode("//input[@id='__VIEWSTATEGENERATOR']")?.GetAttributeValue("value", "");

            var loginData = new Dictionary<string, string>
        {
            { "txtlogin", username },
            { "txtsenha", password },
            { "__VIEWSTATE", viewState },
            { "__EVENTVALIDATION", eventValidation },
            { "__VIEWSTATEGENERATOR", viewStateGenerator },
            { "btnlogin", "Entrar" }
        };

            var content = new FormUrlEncodedContent(loginData);

            try
            {
                Console.WriteLine("Sending authentication request...");

                var response = await _httpClient.PostAsync("http://www2.pmfi.pr.gov.br/GiiG/Autenticacao/defaultpmfi.aspx", content);

                Console.WriteLine($"Response received with status code: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Authentication successful. Processing cookies...");

                    foreach (var header in response.Headers)
                    {
                        Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
                    }

                    foreach (var header in response.Content.Headers)
                    {
                        Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
                    }

                    var responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response content: {responseBody}");

                    if (response.Headers.TryGetValues("Set-Cookie", out IEnumerable<string> cookies))
                    {
                        var sessionId = ExtractSessionIdFromCookies(cookies);
                        return sessionId;
                    }
                    else
                    {
                        throw new Exception("Set-Cookie header not found in the response");
                    }
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"HttpRequestException: {httpEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception("Error during authentication", ex);
            }
        }

        private string ExtractSessionIdFromCookies(IEnumerable<string> cookies)
        {
            Console.WriteLine("Extracting session ID from cookies...");

            foreach (var cookie in cookies)
            {
                Console.WriteLine($"Cookie: {cookie}");

                if (cookie.Contains("ASP.NET_SessionId"))
                {
                    var parts = cookie.Split(';');
                    foreach (var part in parts)
                    {
                        if (part.Contains("ASP.NET_SessionId"))
                        {
                            var sessionId = part.Split('=')[1];
                            Console.WriteLine($"Extracted Session ID: {sessionId}");
                            return sessionId;
                        }
                    }
                }
            }

            Console.WriteLine("Failed to extract Session ID from cookies");
            return null;
        }
    }

}

/*
 *  utiliza o código abaixo na página 
 *    string username;
        string password;
        string message;
        try
        {


            var sessionId = await AuthService.AuthenticateAsync("Sandro.src","S@ndro1972");
            if (!string.IsNullOrEmpty(sessionId))
            {
                message = "Login successful. Session ID: " + sessionId;
                // Store the sessionId for further use
            }
            else
            {
                message = "Login failed";
            }
        }catch(Exception ex)
        {
            // Log exception details
            Console.WriteLine($"Authentication error: {ex.Message}");
            message = $"Error: {ex.Message}";
            
        }
*/