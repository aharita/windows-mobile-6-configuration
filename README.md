Windows Mobile 6 Utils
======================

The purpose of this library is to provide helper classes that you can use to ease your
development on the Windows Mobile 6 platform.

ConfigurationHelper.cs
----------------------
Windows Mobile does not support application configuration out of the box. In this library
you will find a light and easy to use configuration setup. You just need to add a Configuration.xml file as follows:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Configuration>
  <Settings>
    <setting name="Hello" value="World" />
  </Settings>
</Configuration>
```

Currently supports the following methods

```c#
// Adds a new key/value
public void Add(string key, string value)

// Gets the value of a key, null if it does not exist
public string Get(string key)

// Loads Configuration.xml file into internal dictionary
public void Load()

// Saves the current keys/values in the Configuration.xml file
public void Save()
```

And this are usage examples

```c#
string myValue = ConfigurationHelper.Instance.Get("Hello");
ConfigurationHelper.Instance.Add("URL", "http://localhost:8080");
ConfigurationHelper.Instance.Save();
```

DirectoryHelper.cs
------------------
This class contains a useful property that helps you determine the current application folder

TODO:
-----

- ImageConverterHelper
- XmlSerializationHelper
- LoggingHelper