using System;
using System.Diagnostics;
using Localhost;

namespace LocalhostSample
{
    public static class Sample
    {
        public static void Run()
        {
            Debug.WriteLine(CrossLocalhost.Current.Ip);
        }

        public static string GetIP()
        {
            return CrossLocalhost.Current.Ip;
        }
    }
}
