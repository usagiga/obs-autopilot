using System;
using System.Net.Mime;
using System.Windows.Forms;
using obs_autopilot.Configs;

namespace obs_autopilot
{
    internal class Program
    {
        public static int Main(string host = null, int port = -1, string password = null)
        {
            var obsConnectInfo = new ObsConnectInfo()
            {
                Host = host,
                Port = port,
                Password = password,
            };
            if (!obsConnectInfo.Validate())
            {
                Console.WriteLine("OBS connect info must be specified. See help using -h option");
                return 1;
            }

            return 0;
        }
    }
}