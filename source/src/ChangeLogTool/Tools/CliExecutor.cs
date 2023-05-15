using ChangeLogTool.CommandLineOptions;
using ChangeLogTool.Exceptions;
using ChangeLogTool.Helper;
using CommandLine;
using System;

namespace ChangeLogTool.Tools
{
    public class CliExecutor : ICliExecutor
    {
        private readonly IEntryCreator _entryCreator;
        private readonly IReleaser _releaser;
        private readonly IConsoleHelper _consoleHelper;

        public CliExecutor(IEntryCreator entryCreator, IReleaser releaser,IConsoleHelper consoleHelper)
        {
            _entryCreator = entryCreator;
            _releaser = releaser;
            _consoleHelper = consoleHelper;
        }

        public void Execute(string[] args)
        {
            try
            {
                Parser.Default.ParseArguments<AddMessageOptions, GenerateReleaseOptions>(args)
                            .MapResult(
                                (AddMessageOptions addMessageOptions) => _entryCreator.ParseAndExecuteAddMessageOptions(addMessageOptions),
                                (GenerateReleaseOptions generateReleaseOptions) => _releaser.ParseAndExecuteGenerateReleaseOptions(generateReleaseOptions),
                                errs => 1);
            }
            catch (AddMessageOptionException ex)
            {
                _consoleHelper.LogException("An error in using the verb add has occurred", ex);
            }
            catch (GenerateReleaseOptionException ex)
            {
                _consoleHelper.LogException("An error in using the verb generate-release has occurred", ex);
            }
            catch (Exception e)
            {
                _consoleHelper.LogException("An error has occured:", e);
            }
        }
    }
}
