using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class UaLanguageFactory : ILanguageFactory
    {
        public ISound sound()
        {
            return new UaSound();
        }

        public ISubtitles subtitles()
        {
            return new UaSubtitles();
        }
    }
}
