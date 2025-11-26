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
                IgnoreBlankLines = true, // default
                HasHeaderRecord = true, // default
                Delimiter = "," // default
            };
            using CsvReader csvReader = new CsvReader(inputReader, csvConfiguration);
            csvReader.Context.RegisterClassMap<ProcessedOrderMap>();

            IEnumerable<ProcessedOrder> records = csvReader.GetRecords<ProcessedOrder>();

            foreach (ProcessedOrder order in records)
            {
                Console.WriteLine($"OrderNumber: {order.OrderNumber}");
                Console.WriteLine($"Customer: {order.Customer}");                
                Console.WriteLine($"Amount: {order.Amount}");

                //Console.WriteLine(record.Field1);
                //Console.WriteLine(record.Field2);
                //Console.WriteLine(record.Field3);
                //Console.WriteLine(record.Field4);
            }
        }
    }
}
