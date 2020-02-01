using System;
using System.Collections.Generic;

namespace CodeBreakerGameBlazor.Models
{
    public class GameResult
    {
        public bool IsFailure { get; set; }

        public int Moves { get; set; }

        public IEnumerable<string> CorrectResult { get; set; }

        public IEnumerable<string> Answer { get; set; }

        public TimeSpan GameTime { get; set; }
    }
}
