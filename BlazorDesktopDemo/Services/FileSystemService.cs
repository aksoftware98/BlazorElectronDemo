using System;
using System.IO;

namespace BlazorDesktopDemo
{
    
    public interface IFilesService
    {
        void WriteToFile(string filePath, string content); 

        string ReadFromFile(string filePath); 
    }

    public class FilesService : IFilesService
    {
        public string ReadFromFile(string filePath)
        {
            using(var stream = new StreamReader(filePath))
                return stream.ReadToEnd(); 
        }

        public void WriteToFile(string filePath, string content)
        {
            using(var stream = new StreamWriter(filePath))
                stream.Write(content); 
        }
    }

}