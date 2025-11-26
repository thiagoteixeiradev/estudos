using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    public class BinaryFileProcessor
    {
        public string InputFilePath { get; }
        public string OutputFilePath { get; }

        public BinaryFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void Process()
        {
            using FileStream inputFileStream = File.Open(InputFilePath, FileMode.Open, FileAccess.Read);
            using FileStream outputFileStream = File.OpenWrite(OutputFilePath);

            const int endOfStream = -1;

            int largestByte = 0;

            int currentByte = inputFileStream.ReadByte();
            while (currentByte != endOfStream)
            {
                outputFileStream.WriteByte((byte)currentByte);

                if (currentByte > largestByte)
                {
                    largestByte = currentByte;
                }

                currentByte = inputFileStream.ReadByte();
            }
            outputFileStream.WriteByte((byte)largestByte);
        }
    }
}
