using Newtonsoft.Json;
using System;
using System.IO;

namespace WinScreen.Core
{
    public static class DataWorker
    {
        public static string ImagePath = Environment.CurrentDirectory + @"\Images";

        public static string Copy(string from)
        {
            if (!Directory.Exists(ImagePath))
                Directory.CreateDirectory(ImagePath);
            var to = ImagePath + @"\" + from.GetLastPart();
            if (File.Exists(to))
            {
                var key = to.GetDotPart();
                to = to.Replace(key, "Copy." + key);
            }
            File.Copy(from, to, true);
            return to;
        }

        public static object Deserialize(string path, Type type)
        {
            if (File.Exists(path))
                using (StreamReader file = File.OpenText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return serializer.Deserialize(file, type);
                }
            else
                Serialize(path, null);
            return null;
        }

        public static void Serialize(string path, object ject)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, ject);
            }
        }
    }
}