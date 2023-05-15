using ChangeLogTool.ChangeLog;
using System.Collections.Generic;
using System.IO;

namespace ChangeLogTool.Helper
{
    public interface IFileHelper
    {
        void WriteObjectToJson<T>(T obj, string path) where T : class;
        FileInfo[] GetAllChangelogFiles(DirectoryInfo unreleasedDirInfo);
        string[] ReadAllLineOfTheFiles(string filePath);
        string GetFileContent(string path);
        void WriteAllLinesOfTheFiles(string changeLogFilePath, IList<string> masterChangeLogContent);
        void DeleteTheFile(string path);
        void WriteChangeLogEntry(ChangeLogEntry changeLogEntry);
    }
}
