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
			// Using read all text
			//string originalText = File.ReadAllText(InputFilePath);
			//string processedText = originalText.ToUpperInvariant();
			//File.WriteAllText(OutputFilePath, processedText);

			// Using read all lines
			string[] lines = File.ReadAllLines(InputFilePath);
			lines[1] = lines[1].ToUpperInvariant(); // Assumes there is a line 2 in the file

			try
			{
				File.WriteAllLines(OutputFilePath, lines);
			}
			catch (Exception ex)
            {
				// Retry
				// Log
				// throw
				throw;
            }
		}
	}
}
