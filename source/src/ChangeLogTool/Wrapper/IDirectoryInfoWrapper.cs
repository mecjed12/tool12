

using System.IO;

namespace ChangeLogTool.Wrapper
{
    public interface IDirectoryInfoWrapper
    {
        FileInfo[] GetFiles(DirectoryInfo directoryinfo,string searchPatterns);
        DirectoryInfo GetDirectoryInfo();
        FileInfo[] GeFiles(string serachPattern);
        DirectoryInfo CreatSubDirectory(string path);
    }
}
