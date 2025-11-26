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
            using BinaryReader binaryReader = new BinaryReader(inputFileStream);

            using FileStream outputFileStream = File.OpenWrite(OutputFilePath);
            using BinaryWriter binaryWriter = new BinaryWriter(outputFileStream);

            int largest = 0;

            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                int currentByte = binaryReader.ReadByte();

                binaryWriter.Write(currentByte); // writing a .NET int here

                if (currentByte > largest)
                {
                    largest = currentByte;
                }
            }

            binaryWriter.Write(largest); // writing a .NET int here
        }
    }
}
