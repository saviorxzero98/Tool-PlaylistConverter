using System.Collections.Generic;

namespace PlaylistPathConverters.Core.Converters
{
    public class ConvertResult
    {
        public List<string> SuccessPath { get; set; } = new List<string>();

        public List<string> FailurePath { get; set; } = new List<string>();

        public int SuccessCount { get => SuccessPath.Count; }

        public int FailureCount { get => FailurePath.Count; }

        public int TotalCount { get => SuccessCount + FailureCount; }


        public void AddSuccess(string filePath)
        {
            SuccessPath.Add(filePath);
        }

        public void AddFailure(string filePath)
        {
            FailurePath.Add(filePath);
        }
    }
}
