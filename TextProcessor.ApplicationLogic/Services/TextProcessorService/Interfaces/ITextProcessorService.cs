using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor.ApplicationLogic.Enums;

namespace TextProcessor.ApplicationLogic.Services.TextProcessorService.Interfaces
{
    public interface ITextProcessorService
    {
        public List<string> ProcessText(char[] operations, string text);
    }
}
