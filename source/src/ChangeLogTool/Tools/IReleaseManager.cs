using ChangeLogTool.CommandLineOptions;
using ChangeLogTool.Config;
using System;

namespace ChangeLogTool.Tools
{
    public interface IReleaseManager
    {
        bool IsPerformRelease(GenerateReleaseOptions options);
        int CheckTheRelease(GenerateReleaseOptions options);
        void BranchCreator(GenerateReleaseOptions options, Version version, IAppSettings config);
    }
}
