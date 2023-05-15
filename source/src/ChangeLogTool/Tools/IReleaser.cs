using ChangeLogTool.CommandLineOptions;

namespace ChangeLogTool.Tools
{
    public interface IReleaser
    {
        int ParseAndExecuteGenerateReleaseOptions(GenerateReleaseOptions options);
    }
}
