using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using N8Technologies.FroniusClient.ApiDataTypes;

namespace N8Technologies.FroniusClient.Test
{
    [TestClass]
    public class GetRealtimeInverterData
    {
        FroniusClient _client;
        private static int RT_REQ_TIMEOUT = 3000;
        
        public GetRealtimeInverterData() {
            _client = new FroniusClient("http://10.1.100.54/");
        }

        bool ValidateCumulationInverterData(CumulationInverterData d)
        {
            return true;
        }

        bool ValidateThreePhaseInverterData(ThreePhaseInverterData d)
        {
            return true;
        }

        bool ValidateMinMaxInverterData(MinMaxInverterData d)
        {
            return true;
        }

        bool ValidateCommonInverterData(CommonInverterData d)
        {
            return true;
        }

        /// <summary>
        /// Generic method for retrieving async data, and testing timeout
        /// </summary>
        /// <typeparam name="T">Inverter data type</typeparam>
        /// <param name="rMethod">Retrieval methof to use</param>
        /// <returns>Inverter data, if successful</returns>
        T RetrieveAsync<T>(Func<Task<T>> rMethod)
        {
            Task<T> t = rMethod();
            t.Wait(RT_REQ_TIMEOUT);
            Assert.IsTrue(t.IsCompletedSuccessfully);
            return t.Result;
        }


        //Cumulation

        [TestMethod]
        public void GetAsyncCumulationInverterData()
        {
            
            CumulationInverterData d = RetrieveAsync(() => { return _client.GetCumulationInverterDataAsync(); });
            Assert.IsTrue(ValidateCumulationInverterData(d));
        }

        [TestMethod]
        public void GetCumulationInverterData()
        {
            Assert.IsTrue(ValidateCumulationInverterData(_client.GetCumulationInverterData()));
        }

        //Common

        [TestMethod]
        public void GetAsyncCommonInverterData()
        {
            CommonInverterData d = RetrieveAsync(() => { return _client.GetCommonInverterDataAsync(); });
            Assert.IsTrue(ValidateCommonInverterData(d));
        }

        [TestMethod]
        public void GetCommonInverterData()
        {
            Assert.IsTrue(ValidateCommonInverterData(_client.GetCommonInverterData()));
        }

        //Three Phase
        [TestMethod]
        public void GetAsyncThreePhaseInverterData()
        {
            ThreePhaseInverterData d = RetrieveAsync(() => { return _client.GetThreePhaseInverterDataAsync();  });
            Assert.IsTrue(ValidateThreePhaseInverterData(d));
        }

        [TestMethod]
        public void GetThreePhaseInverterData()
        {
            Assert.IsTrue(ValidateThreePhaseInverterData(_client.GetThreePhaseInverterData()));
        }

        //Min Max
        [TestMethod]
        public void GetMinMaxInverterData()
        {
            MinMaxInverterData d = RetrieveAsync(() => { return _client.GetMinMaxInverterDataAsync(); });
            Assert.IsTrue(ValidateMinMaxInverterData(d));
        }

    }
}
