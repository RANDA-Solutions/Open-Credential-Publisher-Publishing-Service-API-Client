using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenCredentialsPublisher.ApiClient.EndPoints
{
    [Serializable]
    public class Requests
    {
        #region Statics
        /// <summary>
        /// A publisher can use this endpoint to get the current state of a publish request
        /// </summary>
        /// <param name="RequestId"></param>
        /// <param name="BearerToken"></param>
        /// <returns></returns>
        public static async Task<Requests> GetRequest(string RequestId, string BearerToken) {
            return await EndPointBase.ConnectGet<Requests>("api/requests", $"/{RequestId}", BearerToken);
        }

        /// <summary>
        /// Revoke a request
        /// </summary>
        /// <param name="RequestId"></param>
        /// <param name="BearerToken"></param>
        /// <returns></returns>
        public static async Task<Requests> RevokeRequest(string RequestId, string BearerToken) {
            return await EndPointBase.ConnectDelete<Requests>("api/requests", $"/{RequestId}", BearerToken);
        }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("accessKey")]
        public string AccessKey { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("qrCode")]
        public QrCodeType QrCode { get; set; }

        [Serializable]
        public class QrCodeType
        {
            [JsonProperty("mimeType")]
            public string MimeType { get; set; }

            [JsonProperty("data")]
            public string Data { get; set; }
        }
    }
}
