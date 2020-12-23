using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenCredentialsPublisher.ApiClient.EndPoints
{
    [Serializable]
    public class Credentials
    {
        #region Statics
        public static async Task<Credentials> GetCredentials(string AccessKey, string BearerToken) {
            Dictionary<string, string> data = new Dictionary<string, string>() {
                { "accessKey", AccessKey }
            };

            return await EndPointBase.ConnectForm<Credentials>("api/credentials", data, BearerToken);
        }

        [JsonProperty("@context")]
        public string Contex { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuanceDate")]
        public DateTime IssuanceDate { get; set; }

        [JsonProperty("credentialSubject")]
        public CredentialSubjectType[] CredentialSubject { get; set; }

        [JsonProperty("credentialStatus")]
        public CredentialStatusType CredentialStatus { get; set; }

        [JsonProperty("proof")]
        public ProofType Proof { get; set; }

        [Serializable]
        public class CredentialSubjectType
        {
            [JsonProperty("id")]
            public string ID { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }
        }

        [Serializable]
        public class CredentialStatusType
        {
            [JsonProperty("id")]
            public string ID { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }
        }

        [Serializable]
        public class ProofType
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("created")]
            public DateTime Created { get; set; }

            [JsonProperty("proofPurpose")]
            public string ProofPurpose { get; set; }

            [JsonProperty("verificationMethod")]
            public string VerificationMethod { get; set; }

            [JsonProperty("domain")]
            public string Domain { get; set; }

            [JsonProperty("challenge")]
            public string Challenge { get; set; }

            [JsonProperty("signature")]
            public string Signature { get; set; }
        }
        #endregion
    }
}
