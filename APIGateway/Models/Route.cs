using System;
namespace APIGateway.Models
{
    public class Route
    {

        public string ExternalEndPoint { get; set; }
        public InternalEndPoint InternalEndPoint { get; set; }

        public Route()
        {
        }
    }
}
