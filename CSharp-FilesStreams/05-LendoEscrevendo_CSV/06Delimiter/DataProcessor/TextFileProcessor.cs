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
			//using var inputFileStream = new FileStream(InputFilePath, FileMode.Open);
			using StreamReader inputStreamReader = File.OpenText(InputFilePath);

			//using var outputFileStream = new FileStream(OutputFilePath, FileMode.CreateNew);
			using var outputStreamWriter = new StreamWriter(OutputFilePath);

			var currentLineNumber = 1;
			while (!inputStreamReader.EndOfStream)
            {
				string inputLine = inputStreamReader.ReadLine();
				
				if (currentLineNumber == 2)
                {
					inputLine = inputLine.ToUpperInvariant();
				}

				bool isLastLine = inputStreamReader.EndOfStream;

				if (isLastLine)
				{
					outputStreamWriter.Write(inputLine);
				}
				else
				{
					outputStreamWriter.WriteLine(inputLine);
				}

				currentLineNumber++;
			}

		}
	}
}
