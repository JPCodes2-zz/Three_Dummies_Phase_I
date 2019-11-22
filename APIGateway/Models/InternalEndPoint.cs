using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace APIGateway.Models
{
    public class InternalEndPoint
    {
        public string Uri { get; set; }
        public bool IsAuthenticationRequired { get; set; }

        public static HttpClient httpClient =new HttpClient();

        public InternalEndPoint(string uri, bool isAuthenticationRequired)
        {
            Uri = uri;
            IsAuthenticationRequired = isAuthenticationRequired;
        }

        public InternalEndPoint(string uri):this(uri,false)
        {
        }

        public InternalEndPoint():this("/",false)
        {
        }

        private string CreateInternalFullUri(HttpRequest request)
        {
            string requestPath = request.Path.ToString();
            string queryString = request.QueryString.ToString();
            string endpoint = "";
            string[] endpointSplit = requestPath.Substring(1).Split('/');
            if (endpointSplit.Length > 1)
                endpoint = endpointSplit[1];
            return Uri + endpoint + queryString;
        }

        public async Task<HttpResponseMessage> SendRequest(HttpRequest request)
        {
            string requestContent;
            using Stream receiveStream = request.Body;
                using StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    requestContent = await readStream.ReadToEndAsync();

            using var newRequest = new HttpRequestMessage(new HttpMethod(request.Method), CreateInternalFullUri(request));
                    newRequest.Content = new StringContent(requestContent, Encoding.UTF8, request.ContentType);

                using var response = await httpClient.SendAsync(newRequest);
                    return response;
        }
    }
}   