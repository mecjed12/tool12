using System.IO;

namespace ChangeLogTool.Helper
{
    public interface IDirectoryService
    {
        DirectoryInfo EnsureDirectory(string path);
    }
}
