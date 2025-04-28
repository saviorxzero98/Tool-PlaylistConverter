using Microsoft.Extensions.Configuration;
using PlaylistPathConverters.Core.Converters;
using PlaylistPathConverters.Core.Settings;
using Spectre.Console;

namespace PlaylistPathConverters.ConsoleApp
{
    public class MainApp
    {
        protected readonly IConfiguration _configuration;

        public MainApp(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Run()
        {
            var settings = _configuration.Get<AppSetting>();

            if (settings == null)
            {
                return;
            }

            var inputFolder = PromptInputFolder(settings);
            var outputFolder = PromptOutputFolder(settings);
            var inputFileRoot = PromptPlaylistFilePath(settings);
            var profile = PromptSelectOutputProfile(settings);

            if (profile == null)
            {
                return;
            }

            var converter = new PlaylistConverter(inputFolder, outputFolder);
            var options = new ConvertOptions(inputFileRoot, profile);
            var result = converter.Convert(options);

            var message = string.Format("總共：{0}；成功：{1}", result.TotalCount, result.SuccessCount);
            AnsiConsole.MarkupLine(message);
        }

        protected string PromptInputFolder(AppSetting setting)
        {
            if (!string.IsNullOrWhiteSpace(setting.InputFolder) &&
                Directory.Exists(setting.InputFolder))
            {
                return setting.InputFolder;
            }

            var prompt = new TextPrompt<string>("輸入檔案目錄：");
            prompt = prompt.Validate(value => (!string.IsNullOrWhiteSpace(value) &&
                                               Directory.Exists(value)) ? ValidationResult.Success()
                                                                        : ValidationResult.Error("輸入檔案目錄不正確"))
                           .ValidationErrorMessage("輸入檔案目錄不正確");
            var inputFolder = AnsiConsole.Prompt(prompt);
            return inputFolder;
        }

        protected string PromptOutputFolder(AppSetting setting)
        {
            string outputFolder;

            if (!string.IsNullOrWhiteSpace(setting.OutputFolder))
            {
                outputFolder = setting.OutputFolder;
            }
            else
            {
                var prompt = new TextPrompt<string>("輸出檔案目錄：");
                prompt = prompt.Validate(value => (!string.IsNullOrWhiteSpace(value)) ? ValidationResult.Success()
                                                                                      : ValidationResult.Error("輸出檔案目錄不正確"))
                               .ValidationErrorMessage("輸出檔案目錄不正確");
                outputFolder = AnsiConsole.Prompt(prompt);
            }
            
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            return outputFolder;
        }

        protected string PromptPlaylistFilePath(AppSetting setting)
        {
            if (setting.Paths.Count != 0)
            {
                var choicePrompt = new SelectionPrompt<string>().Title("播放清單根路徑：").AddChoices(setting.Paths);

                var inputFileRoot = AnsiConsole.Prompt(choicePrompt);
                return inputFileRoot;
            }
            else
            {
                var prompt = new TextPrompt<string>("播放清單的根路徑：");
                var inputFileRoot = AnsiConsole.Prompt(prompt);
                return inputFileRoot;
            }
        }
    
        protected OutputProfile? PromptSelectOutputProfile(AppSetting setting)
        {
            if (setting.Profiles.Count != 0)
            {
                var keys = new List<string>(setting.Profiles.Keys);
                var choicePrompt = new SelectionPrompt<string>().Title("播放清單輸出格式：").AddChoices(keys);
                var profile = AnsiConsole.Prompt(choicePrompt);
                return setting.Profiles[profile];
            }
            return default;
        }
    }
}
