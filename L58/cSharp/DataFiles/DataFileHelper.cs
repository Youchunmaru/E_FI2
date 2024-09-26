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

        public static void WriteJson<T>(string path, T obj){
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(path, json);
        }

        public static string? GetValueOfXML(this string xml, string key){
            //
            return "";
        }

        public static string? GetValueOfCSV(this string csv, int row, int col){
            //
            return "";
        }
    }
}