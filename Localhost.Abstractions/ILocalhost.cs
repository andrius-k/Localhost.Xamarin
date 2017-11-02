using System;
namespace Localhost.Abstractions
{
    public interface ILocalhost : IDisposable
    {
        /// <summary>
        /// Sets the ip address that will be returned when running in iOS simulator.
        /// </summary>
        /// <param name="ip">Ip.</param>
        void SetForiOSSimulator(string ip);

		/// <summary>
		/// Sets the ip address that will be returned when running in iOS device.
		/// </summary>
		/// <param name="ip">Ip.</param>
		void SetForiOSDevice(string ip);

		/// <summary>
		/// Sets the ip address that will be returned when running in Android emulator.
		/// </summary>
		/// <param name="ip">Ip.</param>
		void SetForAndroidEmulator(string ip);

		/// <summary>
		/// Sets the ip address that will be returned when running in Android device.
		/// </summary>
		/// <param name="ip">Ip.</param>
		void SetForAndroidDevice(string ip);

        /// <summary>
        /// Returns ip address for current platform.
        /// </summary>
        /// <value>The ip.</value>
        string Ip { get; }
    }
}
