using Newtonsoft.Json;
using System;
using System.IO;

namespace WinScreen.Core
{
    public static class DataWorker
    {
        /// <summary>
        /// Static property for saving all image
        /// </summary>
        public static string ImagePath = Environment.CurrentDirectory + @"\Images";

        /// <summary>
        /// Copy image from path
        /// </summary>
        /// <param name="from">Path to local image</param>
        /// <returns>Path where image is saved</returns>
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

        /// <summary>
        /// Deserialize object from the path
        /// </summary>
        /// <param name="path">Path to JSON file</param>
        /// <param name="type">Object type</param>
        /// <returns>Object after deserialize</returns>
        /// <exception cref="FileNotFoundException">File is not found</exception>
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

        /// <summary>
        /// Serialize object to the path
        /// </summary>
        /// <param name="path">Path where JSON file is saved</param>
        /// <param name="ject">Object</param>
        /// <exception cref="FileNotFoundException">File is not found</exception>
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