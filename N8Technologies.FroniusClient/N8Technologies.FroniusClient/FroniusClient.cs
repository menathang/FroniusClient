using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace N8Technologies.FroniusClient
{
    public class FroniusClient
    {

        public enum RequestScope { System = 1, Device = 2};
        public enum InverterDataCollection {
            CumulationInverterData = 0,
            CommonInverterData = 1,
            ThreePhaseInverterData = 2,
            MinMaxInverterData = 3
        };

        private static readonly string API_EP = "/solar_api/v1/";

        HttpClient _httpClient { get; set; }

        /// <summary>
        /// The device API
        /// </summary>
        public string Server { get; private set; }

        /// <summary>
        /// Base URL string for the Fronius API
        /// </summary>
        private string BaseUrlString {
            get {
                return $"{Server}{API_EP}".Replace("//","/").Replace(":/","://");
            }
        }

        /// <summary>
        /// A client for accessing a Fronius solar network
        /// </summary>
        /// <param name="server">The HTTP address of the connected master data logger</param>
        public FroniusClient(string server)
        {
            this.Server = server;

            _httpClient = new HttpClient();
        }



        #region "GetThreePhaseData"
        /// <summary>
        /// Retrieves three phase inverter data for the given device asyncronously
        /// </summary>
        /// <param name="deviceId">Device to address</param>
        /// <returns>Three phase specific data on the selected inverter</returns>
        public async Task<ThreePhaseInverterData> GetThreePhaseInverterDataAsync(int deviceId = 1)
        {
            Uri ep = new Uri($"{BaseUrlString}GetInverterRealtimeData.cgi?Scope=Device&DataCollection=3PInverterData&DeviceId={deviceId}");

            HttpResponseMessage m = await _httpClient.GetAsync(ep);

            string content = await m.Content.ReadAsStringAsync();

            SolarApiResponse<ThreePhaseInverterData> r = JsonConvert.DeserializeObject<SolarApiResponse<ThreePhaseInverterData>>(content);

            return r.Body.Data;
        }
        /// <summary>
        /// Retrieves three phase inverter data for the given device
        /// </summary>
        /// <param name="deviceId">Device to address</param>
        /// <returns>Three phase specific data on the selected inverter</returns>
        public ThreePhaseInverterData GetThreePhaseInverterData(int deviceId = 1)
        {
            Task<ThreePhaseInverterData> t = GetThreePhaseInverterDataAsync(deviceId);
            t.Wait();
            return t.Result;
        }

        #endregion

        #region "GetMinMaxInverterData"
        /// <summary>
        /// Retrieves Min and Max data from a specific inverter asyncronously
        /// </summary>
        /// <param name="deviceId">Inverter to retrieve data from</param>
        /// <returns>Min and Max data for the given inverter</returns>
        public async Task<MinMaxInverterData> GetMinMaxInverterDataAsync(int deviceId = 1)
        {
            Uri ep = new Uri($"{BaseUrlString}GetInverterRealtimeData.cgi?Scope=Device&DataCollection=MinMaxInverterData&DeviceId={deviceId}");

            HttpResponseMessage m = await _httpClient.GetAsync(ep);

            string content = await m.Content.ReadAsStringAsync();

            SolarApiResponse<MinMaxInverterData> r = JsonConvert.DeserializeObject<SolarApiResponse<MinMaxInverterData>>(content);

            return r.Body.Data;
        }
        /// <summary>
        /// Retrieves Min and Max data from a specific inverter
        /// </summary>
        /// <param name="deviceId">Inverter to retrieve data from</param>
        /// <returns>Min and Max data for the given inverter</returns>
        public MinMaxInverterData GetMinMaxInverterData(int deviceId = 1)
        {
            Task<MinMaxInverterData> t = GetMinMaxInverterDataAsync(deviceId);
            t.Wait();
            return t.Result;
        }

        #endregion

        #region "GetCommonInverterData"

        /// <summary>
        /// Get common data for the selected inverter asyncronously
        /// </summary>
        /// <param name="deviceId">Device to retrieve data from. The default is 1</param>
        /// <returns>Common data for the addressed inverter</returns>
        public async Task<CommonInverterData> GetCommonInverterDataAsync(int deviceId = 1)
        {
            Uri ep = new Uri($"{BaseUrlString}GetInverterRealtimeData.cgi?Scope=Device&DataCollection=CommonInverterData&DeviceId={deviceId}");

            HttpResponseMessage m = await _httpClient.GetAsync(ep);

            string content = await m.Content.ReadAsStringAsync();

            SolarApiResponse<CommonInverterData> r = JsonConvert.DeserializeObject<SolarApiResponse<CommonInverterData>>(content);

            return r.Body.Data;
        }

        /// <summary>
        /// Get common data for the selected inverter
        /// </summary>
        /// <param name="deviceId">Device to retrieve data from. The default is 1</param>
        /// <returns>Common data for the addressed inverter</returns>
        public CommonInverterData GetCommonInverterData(int deviceId = 1)
        {
            Task<CommonInverterData> t = GetCommonInverterDataAsync(deviceId);
            t.Wait();
            return t.Result;
        }

        #endregion

        #region "GetCumulationInverterData"
        /// <summary>
        /// Retrieves system-wide cumulation data for all connected inverters asyncronously
        /// </summary>
        /// <returns>Cumulation data for the system</returns>
        public async Task<CumulationInverterData> GetSystemCumulationInverterDataAsync()
        {
            Uri ep = new Uri($"{BaseUrlString}GetInverterRealtimeData.cgi?Scope=System&DataCollection=CumulationInverterData");

            HttpResponseMessage m = await _httpClient.GetAsync(ep);

            string content = await m.Content.ReadAsStringAsync();

            SolarApiResponse<CumulationInverterData> r = JsonConvert.DeserializeObject<SolarApiResponse<CumulationInverterData>>(content);

            return r.Body.Data;
        }

        /// <summary>
        /// Retrieves system-wide cumulation data for all connected inverters
        /// </summary>
        /// <returns>Cumulation data for the system</returns>
        public CumulationInverterData GetSystemCumulationInverterData()
        {
            Task<CumulationInverterData> t = GetSystemCumulationInverterDataAsync();
            t.Wait();
            return t.Result;
        }

        /// <summary>
        /// Retrieves cumulation inverter data for the addressed inverter asyncronously
        /// </summary>
        /// <param name="deviceId">Inverter ID to retrieve data from</param>
        /// <returns>Cumulation data from the given inverter</returns>
        public async Task<CumulationInverterData> GetCumulationInverterDataAsync(int deviceId = 1)
        {
            Uri ep = new Uri($"{BaseUrlString}GetInverterRealtimeData.cgi?Scope=Device&DataCollection=CumulationInverterData&DeviceId={deviceId}");

            HttpResponseMessage m = await _httpClient.GetAsync(ep);

            string content = await m.Content.ReadAsStringAsync();

            SolarApiResponse<CumulationInverterData> r = JsonConvert.DeserializeObject<SolarApiResponse<CumulationInverterData>>(content);

            return r.Body.Data;
        }

        /// <summary>
        /// Retrieves cumulation inverter data for the addressed inverter
        /// </summary>
        /// <param name="deviceId">Inverter ID to retrieve data from</param>
        /// <returns>Cumulation data from the given inverter</returns>
        public CumulationInverterData GetCumulationInverterData(int deviceId = 1)
        {
            Task<CumulationInverterData> t = GetCumulationInverterDataAsync(deviceId);
            t.Wait();
            return t.Result;
        }

        #endregion

    }
}
