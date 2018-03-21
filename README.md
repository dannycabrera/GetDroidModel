GetDroidModel
=============

Simple Xamarin.Android library to return the device model.
*******
Will keep device list updated with devices that work with Google Play. At current moment 3/20/2018 list contains 18,554 devices.

If you need an iOS library check out my other repo https://github.com/dannycabrera/Get-iOS-Model.

Updates:<br/>
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
Console.WriteLine(GetDroidModel.DeviceHardware.Model());
```

Result: "Galaxy S9"


```
// Return name including manufacturer
Console.WriteLine(GetDroidModel.DeviceHardware.Model(defaultValue: "Unknown", includeManufacturer: true));
```

Result: "Samsung Galaxy S9"


```
// If device is not listed:
Console.WriteLine(GetDroidModel.DeviceHardware.Model(defaultValue: "Unknown"));
```

Result: "Unknown"