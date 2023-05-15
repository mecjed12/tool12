using ChangeLogTool.CommandLineOptions;


namespace ChangeLogTool.Tools
{
    public interface IEntryCreator
    {
        int ParseAndExecuteAddMessageOptions(AddMessageOptions options);
    }
}
