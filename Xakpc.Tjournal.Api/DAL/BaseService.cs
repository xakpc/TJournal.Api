using System;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    public class BaseService
    {
        private const string SchemaJson = @" 
            {
                'error': {
                    'type': 'object',
                    'properties': {
                        'code': {
                            'type': 'integer'
                            },
                        'message': {
                            'type': 'string'
                            }
                        }   
                    }
            }";
        private const int Version = 2;
        private const string BaseUrl = @"https://api.tjournal.ru/";
        private readonly RestClient _client = new RestClient(BaseUrl);
        private readonly JsonSchema _errorSchema;

        public BaseService()
        {
            _errorSchema = JsonSchema.Parse(SchemaJson);
        }

        protected async Task<T> ExecuteRequest<T>(RestRequest request)
        {
            var response = await _client.Execute(request).ConfigureAwait(false);

            var content = Encoding.UTF8.GetString(response.RawBytes, 0, response.RawBytes.Length);
            //var jobj = JObject.Parse(content);

            //if (jobj.IsValid(_errorSchema))
            //{
            //    throw new InvalidRequestException(await DeserializeObjectAsync<Error>(content).ConfigureAwait(false));
            //}

            //return response.Data;
            return await DeserializeObjectAsync<T>(content);
        }

        private static Task<T> DeserializeObjectAsync<T>(string json)
        {
            return Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(json));
        }

        protected static string FormRequestUrl(string section)
        {
            return string.Format("{0}/{1}", Version, section);
        }

        protected string FormRequestUrl(string section, string action)
        {
            return string.Format("{0}/{1}/{2}", Version, section, action);
        }

        protected static void ValidateIntegerParam(string param, int value, int @from, int to)
        {
            if ((value < @from) || (value > to))
                throw new ArgumentException(string.Format("Argument must be in {0} – {1} range", @from, to == int.MaxValue ? "∞" : to.ToString()), param);
        }
    }

    public class InvalidRequestException : Exception
    {
        public InvalidRequestException(Error error)
        {
            RequestError = error;
        }

        public Error RequestError { get; set; }
    }
}