using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using static System.Console;

namespace DataProcessor
{
    class Program
    {
        private static ConcurrentDictionary<string, string> FilesToProcess =
            new ConcurrentDictionary<string, string>();

        static void Main(string[] args)
        {
            WriteLine("Parsing command line options");

            var directoryToWatch = args[0];

            if (!Directory.Exists(directoryToWatch))
            {
                WriteLine($"ERROR: {directoryToWatch} does not exist");
            }
            else
            {
                WriteLine($"Watching directory {directoryToWatch} for changes");

                using var inputFileWatcher = new FileSystemWatcher(directoryToWatch);
                using var timer = new Timer(ProcessFiles, null, 0, 1000);

                inputFileWatcher.IncludeSubdirectories = false;
                inputFileWatcher.InternalBufferSize = 32768; // 32 KB
                inputFileWatcher.Filter = "*.*"; // this is the default
                inputFileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

                inputFileWatcher.Created += FileCreated;
                inputFileWatcher.Changed += FileChanged;
                inputFileWatcher.Deleted += FileDeleted;
                inputFileWatcher.Renamed += FileRenamed;
                inputFileWatcher.Error += WatcherError;

                inputFileWatcher.EnableRaisingEvents = true;

                WriteLine("Press enter to quit.");
                ReadLine();
            }
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            WriteLine($"* File created: {e.Name} - type: {e.ChangeType}");

            FilesToProcess.TryAdd(e.FullPath, e.FullPath);
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            WriteLine($"* File changed: {e.Name} - type: {e.ChangeType}");

            FilesToProcess.TryAdd(e.FullPath, e.FullPath);
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            WriteLine($"* File deleted: {e.Name} - type: {e.ChangeType}");
        }
        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            WriteLine($"* File renamed: {e.OldName} to {e.Name} - type: {e.ChangeType}");
        }
        private static void WatcherError(object sender, ErrorEventArgs e)
        {
            WriteLine($"ERROR: file system watching may no longer be active: {e.GetException()}");
        }


        private static void ProcessFiles(object stateInfo)
        {
            foreach (var fileName in FilesToProcess.Keys)
            {
                if (FilesToProcess.TryRemove(fileName, out _))
                {
                    var fileProcessor = new FileProcessor(fileName);
                    fileProcessor.Process();
                }
            }
        }




    }
}
