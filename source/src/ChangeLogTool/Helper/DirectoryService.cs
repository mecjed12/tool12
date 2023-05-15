using System.IO;

namespace ChangeLogTool.Helper
{
    public class DirectoryService : IDirectoryService
    {
        public DirectoryInfo EnsureDirectory(string path)
        {
            var unreleasedDirInfo = new DirectoryInfo(path);
            if (!unreleasedDirInfo.Exists)
            {
                unreleasedDirInfo.Create();
            }
            return unreleasedDirInfo;
        }
    }
}
