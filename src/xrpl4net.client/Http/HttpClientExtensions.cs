using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Http
{
    public static class HttpClientExtensions
    {
        public static async Task<string> PostJsonContent(string uri, HttpClient httpClient, string content)
        {
            try
            {
                var post = new StringContent(content, Encoding.UTF8, "application/json");
                var responseMessage = await httpClient.PostAsync(uri, post);
                if (responseMessage.IsSuccessStatusCode)
                    return await responseMessage.Content.ReadAsStringAsync();
                else
                    throw new Exception("Remote server returns error code: " + responseMessage.StatusCode);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
