using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Http
{
    public static class HttpHelper
    {
        public static async Task<string> PostData(string uri, string content)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var post = new StringContent(content, Encoding.UTF8, "application/json");
                    var responseMessage = await httpClient.PostAsync(uri, post);
                    if (responseMessage.IsSuccessStatusCode)
                        return await responseMessage.Content.ReadAsStringAsync();
                    else
                        throw new Exception("Remote server returns error code: " + responseMessage.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
