using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace WindowsMobileUtils
{
    public class ConfigurationHelper
    {
        #region Properties
        private static readonly ConfigurationHelper _instance = new ConfigurationHelper();
        public static ConfigurationHelper Instance
        {
            get
            {
                return _instance;
            }
        }

        private Dictionary<string, string> _settings = new Dictionary<string, string>();
        public Dictionary<string, string> Settings
        {
            get
            {
                return _settings;
            }
        }
        #endregion

        #region Constructors
        static ConfigurationHelper()
        {

        }

        private ConfigurationHelper()
        {
            XDocument doc = XDocument.Load(Path.Combine(DirectoryHelper.CurrentDirectory, "Configuration.xml"));

            foreach (XElement element in doc.Descendants("setting"))
            {
                this.Settings.Add(element.Attribute("name").Value, element.Attribute("value").Value);
            }
        }
        #endregion
    }
}