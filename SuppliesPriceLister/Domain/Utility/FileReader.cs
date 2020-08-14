using CsvHelper;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace buildxact_supplies.Domain.Utility
{
    public static class FileReader
    {
        /// <summary>
        /// Read A CSV file and return the provided type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static IEnumerable<T> ReadCsvFile<T>(string filePath) 
        {
            using (var streamReader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                csvReader.Read();
                return csvReader.GetRecords<T>().ToList();
            }
        }

        /// <summary>
        /// Read a JSOn file and return the provided type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static IEnumerable<T> ReadJsonFile<T>(string filePath) 
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                yield return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            }
        }
    }
}
