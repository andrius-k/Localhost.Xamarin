# Localhost for Xamarin

When running our apps in development environment we often want to access some kind of backed service running on our development machine. It is simple on iOS simulator because it uses host machine network so we can reach our development machine with `localhost` or `127.0.0.1`. On Android there is an alias `10.0.2.2` to your host loopback interface. But when running on device we have to use actual IP address of our machine in local network. Localhost allows us to use different IP address to access local development machine depending on the platform the app runs on. There are 4 supported platform variations: iOS simulator, iOS device, Android emulator and Android device. This library takes advantage  of bait-and-switch pattern so it can be used from shared code.

Note that nuget package has to be installed in both PCL and platform specific projects.

# Sample Usage

```csharp
// Get IP address for current platform variation
string ip = CrossLocalhost.Current.Ip;

// Set IP address that must be used when running on iOS simulator
CrossLocalhost.Current.SetForiOSSimulator(ip);

// Set IP address that must be used when running on iOS device
CrossLocalhost.Current.SetForiOSDevice(ip);

// Set IP address that must be used when running on Android emulator
CrossLocalhost.Current.SetForAndroidEmulator(ip);

// Set IP address that must be used when running on Android device
CrossLocalhost.Current.SetForAndroidDevice(ip);
```

# Default Values

These are the default values for each platform variation:

| iOS simulator     | iOS device          | Android emulator | Android device      |
| ----------------- | ------------------- | ---------------- | ------------------- |
| 127<nolink>.0.0.1 | 192<nolink>.168.1.1 | 10<nolink>.0.2.2 | 192<nolink>.168.1.1 | 

But you can override them like shown in sample usage section.