using Util;
using System.Text.Json;

namespace DataFiles
{
    static class DataFileHelper
    {
        public static T? ReadJson<T>(string path)
        {
            string? json = Reader.ReadFile(path);
            if (json != null){
                return JsonSerializer.Deserialize<T>(json);
            }
            return default;
        }

        public static string GetValueOfXML<T>(string xml, string key){
            //
            return "";
        }
    }
}