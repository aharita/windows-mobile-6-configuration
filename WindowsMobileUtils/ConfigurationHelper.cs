using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace WindowsMobileUtils
{
    public class ConfigurationHelper
    {
        #region Properties

        private Dictionary<string, string> _settings;
        private static readonly ConfigurationHelper _instance = new ConfigurationHelper();

        public string ConfigurationFile = Path.Combine(DirectoryHelper.CurrentDirectory, "Configuration.xml");
        public static ConfigurationHelper Instance
        {
            get
            {
                return _instance;
            }
        }

        #endregion

        #region Constructors

        private ConfigurationHelper()
        {
             _settings = new Dictionary<string, string>();

            Load();
        }

        #endregion

        #region
        public void Add(string key, string value)
        {
            if (_settings.ContainsKey(key))
            {
                _settings[key] = value;
            }
            else
            {
                _settings.Add(key, value);
            }
        }

        public string Get(string key)
        {
            if (_settings.ContainsKey(key))
            {
                return _settings[key];
            }
            else
            {
                return null;
            }
        }

        public void Load()
        {
            _settings.Clear();

            XDocument doc = XDocument.Load(this.ConfigurationFile);

            foreach (var e in doc.Descendants("setting"))
            {
                _settings.Add(e.Attribute("name").Value, e.Attribute("value").Value);
            }
        }

        public void Save()
        {
            XDocument doc = XDocument.Load(this.ConfigurationFile);

            doc.Descendants("setting").Remove();

            foreach (KeyValuePair<string, string> i in _settings)
            {
                doc.Element("Configuration").Element("Settings").Add(
                    new XElement("setting",
                        new XAttribute("name", i.Key),
                        new XAttribute("value", i.Value)));
            }

            doc.Save(this.ConfigurationFile);
        }
        #endregion
    }
}