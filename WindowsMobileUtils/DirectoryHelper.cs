using System.IO;
using System.Reflection;

namespace WindowsMobileUtils
{
    public class DirectoryHelper
    {
        public static readonly string CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
    }
}