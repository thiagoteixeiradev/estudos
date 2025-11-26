using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    class CsvFileProcessor
    {
        public string InputFilePath { get; }
        public string OutputFilePath { get; }

        public CsvFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void Process()
        {
            using StreamReader inputReader = File.OpenText(InputFilePath);

            var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Comment = '@',
                AllowComments = true,
                TrimOptions = TrimOptions.Trim,
                IgnoreBlankLines = true // default
            };
            using CsvReader csvReader = new CsvReader(inputReader, csvConfiguration);

            IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();

            foreach (dynamic record in records)
            {
                Console.WriteLine(record.OrderNumber);
                Console.WriteLine(record.CustomerNumber);
                Console.WriteLine(record.Description);
                Console.WriteLine(record.Quantity);
            }
        }
    }
}
