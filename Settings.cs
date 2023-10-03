using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DarkModeFromIni
{
    internal class Settings
    {
        public string IniPath = Application.StartupPath + @"\config.ini";

        public StringBuilder SbTheme;
        public string Theme { get; set; }

        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string sectionName, string keyName, string defaultValue,
            StringBuilder returnedString, int size, string fileName);

        [DllImport("Kernel32")]
        private static extern long WritePrivateProfileString(string section, string keyname, string value, string path);

        public void ReadIni()
        {
            SbTheme = new StringBuilder(10);
            var resultSize = GetPrivateProfileString("SECTION", "key", "", SbTheme, SbTheme.Capacity, IniPath);
            Theme = SbTheme.ToString();
        }

        public void WriteIni(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, IniPath);
        }
    }
}