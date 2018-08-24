GetDroidModel
=============
[![Build status](https://build.appcenter.ms/v0.1/apps/ac246072-f75a-410e-9850-5b622b4595f2/branches/master/badge)](https://appcenter.ms)

Simple Xamarin.Android library to return the device model.
*******
Will keep device list updated with devices that work with Google Play. At current moment 8/24/2018 list contains 20,550 devices.

If you need an iOS library check out my other repo https://github.com/dannycabrera/Get-iOS-Model.

Updates:<br/>
08/24/2018 - Updated to v1.2, 1,880 device changes from previous version: https://gist.github.com/dannycabrera/235a14afbc6584976d052cf18d64ee46<br/>
03/30/2018 - Updated to v1.1, 277 device changes from previous version: https://gist.github.com/dannycabrera/fc941ca987cb576994d61748edb57fcc<br/>
03/19/2018 - Created<br/>
*******

## Install

#### [NuGet Gallery](https://www.nuget.org/packages/dannycabrera.GetDroidModel)
```
Install-Package dannycabrera.GetDroidModel
```

Sample
-------

```
// Example for model SM-G960F
Console.WriteLine(GetDroidModel.DeviceHardware.GetModel());
```

Result: "Galaxy S9"


```
// Return name including manufacturer
Console.WriteLine(GetDroidModel.DeviceHardware.GetModel(defaultValue: "Unknown", includeManufacturer: true));
```

Result: "Samsung Galaxy S9"


```
// If device is not listed:
Console.WriteLine(GetDroidModel.DeviceHardware.GetModel(defaultValue: "Unknown"));
```

Result: "Unknown"
