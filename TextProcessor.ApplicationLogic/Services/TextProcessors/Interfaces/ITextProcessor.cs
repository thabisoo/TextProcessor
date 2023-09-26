using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Enums;

namespace TextProcessor.ApplicationLogic.Services.TextProcessors.Interfaces
{
    public interface ITextProcessor
    {
        public ProcessType ProcessType { get; }

        string Process(string text);
    }
}
