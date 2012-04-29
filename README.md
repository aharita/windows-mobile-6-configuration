Windows Mobile 6 Utils
=======

The purpose of this library is to provide helper classes that you can use to ease your
development on the Windows Mobile 6 platform.

ConfigurationHelper.cs
-------------
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
public void Add(string key, string value)
public string Get(string key)
public void Load()
public void Save()
```
