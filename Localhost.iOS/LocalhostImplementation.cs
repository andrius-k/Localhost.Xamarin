using System;
using Localhost.Abstractions;
using ObjCRuntime;

namespace Localhost
{
    public class LocalhostImplementation : ILocalhost
    {
        private string _deviceIp = "192.168.1.1";
        private string _simulatorIp = "127.0.0.1";

		public void SetForiOSSimulator(string ip)
        {
            _simulatorIp = ip;
        }

		public void SetForiOSDevice(string ip)
        {
            _deviceIp = ip;
        }

		public void SetForAndroidEmulator(string ip)
        {
            // Implementation required only in Android version
        }

		public void SetForAndroidDevice(string ip)
        {
			// Implementation required only in Android version
		}

		public string Ip 
        { 
            get
            {
                if (Runtime.Arch == Arch.DEVICE)
				{
                    Console.WriteLine("Localhost: running on iOS device.");
                    return _deviceIp;
				}
				else
				{
                    Console.WriteLine("Localhost: running on iOS simulator.");
                    return _simulatorIp;
				}
            }
        }

        public void Dispose()
        {
            
        }
    }
}
