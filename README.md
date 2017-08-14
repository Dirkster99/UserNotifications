[![Release](https://img.shields.io/github/release/Dirkster99/UserNotifications.svg)](https://github.com/Dirkster99/UserNotifications/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.UserNotifications.svg)](http://nuget.org/packages/Dirkster.UserNotifications)
## Overview

Lightweight notifications for WPF project based on

Lightweight growl notifications for WPF project from here:
http://www.codeproject.com/Articles/499241/Growl-Alike-WPF-Notifications

## Theming

Load *Light* or *Dark* brush resources in you resource dictionary to take advantage of existing definitions.

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/UserNotifications;component/Themes/DarkBrushs.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/UserNotifications;component/Themes/LightBrushs.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

These definitions do not theme all controls used within this library. You should use a standard theming library, such as:
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro),
- [MLib](https://github.com/Dirkster99/MLib), or
- [MUI](https://github.com/firstfloorsoftware/mui)

to also theme standard elements, such as, button and textblock etc.

## Requirements

 - Visual Studio 2012 / 2010 or later

## Sample Screenshots
![Screenshot](https://github.com/Dirkster99/Docu/blob/master/UserNotifications/screenshot1.png?raw=true)
![Screenshot](https://github.com/Dirkster99/Docu/blob/master/UserNotifications/screenshot2.png?raw=true)
![Screenshot](https://github.com/Dirkster99/Docu/blob/master/UserNotifications/screenshot3.png?raw=true)
