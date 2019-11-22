using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using APIGateway.Infra;
using APIGateway.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace APIGateway
{
    public class UriRouter
    {
        //source code courtecy
        //https://medium.com/streamwriter/api-gateway-aspnet-core-a46ef259dc54
        public List<Route> Routes { get; set; }

        //TODO:: Add Authentication service and enable this feature
       // public InternalEndPoint AuthenticationService { get; set; }

        public UriRouter(string routeConfigFilePath)
        {
            dynamic router = JsonParser.LoadUrisFromFile<dynamic>(routeConfigFilePath);
            Routes = JsonParser.Deserialize<List<Route>>(Convert.ToString(router.routes));
            //AuthenticationService = JsonParser.Deserialize<InternalEndPoint>(Convert.ToString(router.authenticationService));
        }


        public async Task<HttpResponseMessage> RouteRequest(HttpRequest request)
        {
            string path = request.Path.ToString();
            string basePath = '/' + path.Split('/')[1];

            InternalEndPoint destination;
            try
            {
                destination = Routes.First(r => r.ExternalEndPoint.Equals(basePath)).InternalEndPoint;
            }
            catch
            {
                return ConstructErrorMessage("The path could not be found.");
            }

            //TODO:: Add Authentication service and enable this feature

            //if (destination.IsAuthenticationRequired)
            //{
              //  string token = request.Headers["token"];
              //  request.Query.Append(new KeyValuePair<string, StringValues>("token", new StringValues(token)));
              //  HttpResponseMessage authResponse = await AuthenticationService.SendRequest(request);
              //  if (!authResponse.IsSuccessStatusCode) return ConstructErrorMessage("Authentication failed.");
            //}

            return await destination.SendRequest(request);
        }

        private HttpResponseMessage ConstructErrorMessage(string error)
        {
            HttpResponseMessage errorMessage = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.NotFound,
                Content = new StringContent(error)
            };
            return errorMessage;
        }
    }
}