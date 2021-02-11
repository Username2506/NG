using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class EnLanguage : ILanguage
    {
        public ISound sound()
        {
            return new EnSound();
        }

        public ISubtitles subtitles()
        {
            return new EnSubtitles();
        }
    }
}
