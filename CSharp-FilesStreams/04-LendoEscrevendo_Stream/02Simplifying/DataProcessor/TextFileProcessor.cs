using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
	public class TextFileProcessor
	{
		public string InputFilePath { get; }
		public string OutputFilePath { get; }

		public TextFileProcessor(string inputFilePath, string outputFilePath)
		{
			InputFilePath = inputFilePath;
			OutputFilePath = outputFilePath;
		}

		public void Process()
		{
			using var inputFileStream = new FileStream(InputFilePath, FileMode.Open);
			using var inputStreamReader = new StreamReader(inputFileStream);

			using var outputFileStream = new FileStream(OutputFilePath, FileMode.CreateNew);
			using var outputStreamWriter = new StreamWriter(outputFileStream);

			while (!inputStreamReader.EndOfStream)
            {
				string inputLine = inputStreamReader.ReadLine();
				string processedLine = inputLine.ToUpperInvariant();
				outputStreamWriter.WriteLine(processedLine);
			}

		}
	}
}
