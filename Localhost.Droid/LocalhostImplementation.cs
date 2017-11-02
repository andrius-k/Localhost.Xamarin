using System;
using Localhost.Abstractions;
using Android.OS;

namespace Localhost
{
	public class LocalhostImplementation : ILocalhost
	{
		private string _deviceIp = "192.168.1.1";
		private string _emulatorIp = "10.0.2.2";

		public void SetForiOSSimulator(string ip)
		{
			// Implementation required only in iOS version
		}

		public void SetForiOSDevice(string ip)
		{
			// Implementation required only in iOS version
		}

		public void SetForAndroidEmulator(string ip)
		{
            _emulatorIp = ip;
		}

		public void SetForAndroidDevice(string ip)
		{
			_deviceIp = ip;
		}

		public string Ip
		{
			get
			{
				string fingerprint = Build.Fingerprint;
                bool inEmulator = false;

				if (fingerprint != null)
				{
					inEmulator = fingerprint.Contains("vbox") || fingerprint.Contains("generic");
				}

				if (inEmulator)
                {
                    Console.WriteLine("Localhost: running on Android emulator.");
                    return _emulatorIp;
                }
				else
                {
                    Console.WriteLine("Localhost: running on Android device.");
                    return _deviceIp;
                }
			}
		}

		public void Dispose()
		{

		}
	}
}
