//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenCredentialsPublisher.ApiClient.EndPoints;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OpenCredentialsPublisher.ApiClient.EndPoints.Tests
//{
//    [TestClass()]
//    public class CredentialsTests
//    {
//        [TestMethod()]
//        public void GetCredentialsTest() {
//            var pubResult = ApiClient.Tests.ApiTestHelper.GetPublish();

//            var req = Requests.GetRequest(pubResult.RequestId, ApiClient.Tests.ApiTestHelper.GetToken().AccessToken).Result;

//            while(req.Status != "Complete") {
//                System.Threading.Thread.Sleep(5000);
//                req = Requests.GetRequest(pubResult.RequestId, ApiClient.Tests.ApiTestHelper.GetToken().AccessToken).Result;
//            }

//            //string ak = "f3fb97d3-fd48-49b6-b399-9e10b9652a82";

//            //var result = ApiClient.Tests.ApiTestHelper.GetCredentials(ak);
//            var result = ApiClient.Tests.ApiTestHelper.GetCredentials(req.AccessKey);

//            Assert.IsNotNull(result);
//        }
//    }
//}