using RestSharp;
using RestSharp.Serializers;
using HubSpotApi.Exceptions;
using System.Net;

namespace HubSpotApi.Requests
{
    public class RequestBase
    {
        protected readonly IRestClient _client;

        public RequestBase()
        {

        }
        public RequestBase(IRestClient client)
        {
            _client = client;
        }


        /*public RestRequest BuildGetRequest(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.GET) { RequestFormat = DataFormat.Json };

            request.JsonSerializer = new JsonNetSerializer();

            return request;
        }
        public RestRequest BuildPostRequest(string endpoint, object entity)
        {
            var request = new RestRequest(endpoint, Method.POST) { RequestFormat = DataFormat.Json };

            request.JsonSerializer = new JsonNetSerializer();

            request.AddBody(entity);

            return request;
        }
        public RestRequest BuildDeleteRequest(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.DELETE) { RequestFormat = DataFormat.Json };

            request.JsonSerializer = new JsonNetSerializer();

            return request;
        }
        public RestRequest BuildPutRequest(string endpoint, object entity)
        {
            var request = new RestRequest(endpoint, Method.PUT) { RequestFormat = DataFormat.Json };

            request.JsonSerializer = new JsonNetSerializer();

            request.AddBody(entity);

            return request;
        }*/


        /*public T GetResponse<T>(string endpoint) where T : new()
        {
            var request = BuildGetRequest(endpoint);

            var response = buildResponse<T>(request);

            return response;
        }

        public T PostResponse<T>(string endpoint, T obj) where T : new()
        {
            var request = BuildPostRequest(endpoint, obj);

            return buildResponse<T>(request);
        }

        public T PutResponse<T>(string endpoint, T obj) where T : new()
        {
            var request = BuildPutRequest(endpoint, obj);

            return buildResponse<T>(request);
        }

        public T DeleteResponse<T>(string endpoint) where T : new()
        {
            var request = BuildDeleteRequest(endpoint);

            return buildResponse<T>(request);
        }

        private T buildResponse<T>(RestRequest request) where T : new()
        {
            var response = _client.Execute<T>(request);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                case HttpStatusCode.NonAuthoritativeInformation:
                case HttpStatusCode.NoContent:
                case HttpStatusCode.ResetContent:
                case HttpStatusCode.PartialContent:
                    return response.Data;
                case HttpStatusCode.MultipleChoices:
                    throw new HubspotException("300 - Ambigious");
                case HttpStatusCode.Moved:
                    throw new HubspotException("301 - Moved / Moved Permanently");
                case HttpStatusCode.Redirect:
                    throw new HubspotException("302 - Redirect / Found");
                case HttpStatusCode.SeeOther:
                    throw new HubspotException("303 - See Other / Redirect");
                case HttpStatusCode.NotModified:
                    throw new HubspotException("304 - Not Mofidied");
                case HttpStatusCode.UseProxy:
                    throw new HubspotException("305 - Use Proxy");
                case HttpStatusCode.Unused:
                    throw new HubspotException("306 - Unused");
                case HttpStatusCode.TemporaryRedirect:
                    throw new HubspotException("307 - Temporary Redirect / Redirect keep verb");
                case HttpStatusCode.BadRequest:
                    throw new HubspotException("400 - Bad request (check that all fields have been entered");
                case HttpStatusCode.Unauthorized:
                    throw new HubspotException("401 - Unauthorized");
                case HttpStatusCode.PaymentRequired:
                    throw new HubspotException("402 - Payment Required");
                case HttpStatusCode.Forbidden:
                    throw new HubspotException("403 - Forbidden");
                case HttpStatusCode.NotFound:
                    return default(T);
                case HttpStatusCode.MethodNotAllowed:
                    throw new HubspotException("405 - Method Not Allowed");
                case HttpStatusCode.NotAcceptable:
                    throw new HubspotException("406 - Not Acceptable");
                case HttpStatusCode.ProxyAuthenticationRequired:
                    throw new HubspotException("407 - Proxy Authentication Required");
                case HttpStatusCode.RequestTimeout:
                    throw new HubspotException("408 - Request Timeout");
                case HttpStatusCode.Conflict:
                    throw new HubspotException("409 - Conflict (Did you already post that resource?)");
                case HttpStatusCode.Gone:
                    throw new HubspotException("410 - Gone");
                case HttpStatusCode.LengthRequired:
                    throw new HubspotException("411 - Length Required");
                case HttpStatusCode.PreconditionFailed:
                    throw new HubspotException("412 - Precondition Failed");
                case HttpStatusCode.RequestEntityTooLarge:
                    throw new HubspotException("413 - Request Entity Too Large");
                case HttpStatusCode.RequestUriTooLong:
                    throw new HubspotException("414 - Request URI Too Long");
                case HttpStatusCode.UnsupportedMediaType:
                    throw new HubspotException("415 - Unsupported Media Type");
                case HttpStatusCode.RequestedRangeNotSatisfiable:
                    throw new HubspotException("416 - Requested Range Not Satisfiable");
                case HttpStatusCode.ExpectationFailed:
                    throw new HubspotException("417 - Expectation Failed");
                case HttpStatusCode.UpgradeRequired:
                    throw new HubspotException("426 - Upgrade Required");
                case HttpStatusCode.InternalServerError:
                    throw new HubspotException("500 - Internal Server Error (Something went wrong with Hubspot API)");
                case HttpStatusCode.NotImplemented:
                    throw new HubspotException("501 - Not Implemented");
                case HttpStatusCode.BadGateway:
                    throw new HubspotException("502 - Bad Gateway");
                case HttpStatusCode.ServiceUnavailable:
                    throw new HubspotException("503 - Service Unavailable");
                case HttpStatusCode.GatewayTimeout:
                    throw new HubspotException("504 - Gateway Timeout");
                case HttpStatusCode.HttpVersionNotSupported:
                    throw new HubspotException("505 - HTTP Version Not Supported");
                default:
                    throw new HubspotException("Unknown Error");
            }
        }*/
    }
}
