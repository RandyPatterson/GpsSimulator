
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;

namespace IoTGpsSimulator
{
    static class AzureIoTHub
    {
        

        private static DeviceClient ConnectToDevice(string deviceConnectionString)
        {
            return DeviceClient.CreateFromConnectionString(deviceConnectionString, TransportType.Mqtt);
        }

        public static async Task SendDeviceToCloudMessageAsync(Payload payload, string deviceConnectionString)
        {
            
            payload.DeviceId = GetDeviceId(deviceConnectionString);

            string data = JsonConvert.SerializeObject(payload);
            Console.WriteLine(data);
            var message = new Message(Encoding.ASCII.GetBytes(data));

            //Connect to Hub as Device
            DeviceClient deviceClient = ConnectToDevice(deviceConnectionString);
            
            //Send message to IoT Hub
            await deviceClient.SendEventAsync(message);
        }
        /// <summary>
        /// Extract DeviceId from Connection String
        /// </summary>
        /// <returns></returns>
        private static string GetDeviceId(string deviceConnectionString)
        {
            var match = Regex.Match(deviceConnectionString, @"(?i);\s*deviceid\s*=\s*(\w+);");
            return match.Groups[1].ToString();
            
        }
    }
}
