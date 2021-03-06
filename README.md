GetDroidModel
=============
Simple Xamarin.Android library to return the device model.
*******

|  Build Status  |
|:----------|
[![Build status](https://build.appcenter.ms/v0.1/apps/ac246072-f75a-410e-9850-5b622b4595f2/branches/master/badge)](https://appcenter.ms)

|  Package  |
|:----------|
|[![NuGet Badge GetDroidModel](https://buildstats.info/nuget/dannycabrera.GetDroidModel)](https://www.nuget.org/packages/dannycabrera.GetDroidModel)|
*******
Will keep device list updated with devices that work with Google Play. As of 9/29/2020 list contains 29,766 devices.

If you need an iOS library check out my other repo https://github.com/dannycabrera/Get-iOS-Model.

**Updates:**<br/>
09/29/2020 - Updated to v1.5, 1,805 updates (changes + new additions):<br/>
https://gist.github.com/dannycabrera/3f0192fefa68008c949dcaaa5593aba7<br/>
<br/>
04/01/2020 - Updated to v1.4, 1,417 updates (changes + new additions):<br/>
https://gist.github.com/dannycabrera/65cd5b32a6ef7361b6aa6f9cf659580e<br/>
<br/>
01/26/2020 - Updated to v1.3, 6,694 updates (changes + new additions):<br/>
https://gist.github.com/dannycabrera/7cdf76be183063b5394362d10f0ecd7c<br/>
<br/>
08/24/2018 - Updated to v1.2, 1,880 device changes from previous version:
https://gist.github.com/dannycabrera/235a14afbc6584976d052cf18d64ee46<br/>
<br/>
03/30/2018 - Updated to v1.1, 277 device changes from previous version:<br/>
https://gist.github.com/dannycabrera/fc941ca987cb576994d61748edb57fcc<br/>
<br/>
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
