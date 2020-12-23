using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCredentialsPublisher.ApiClient.EndPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCredentialsPublisher.ApiClient.EndPoints.Tests
{
    [TestClass()]
    public class CredentialsTests
    {
        [TestMethod()]
        public void GetCredentialsTest() {
            string accessKey = "fad17efa-58a8-46b4-ad0f-699b92553a2f";

            var result = ApiClient.Tests.ApiTestHelper.GetCredentials(accessKey);
        }
    }
}