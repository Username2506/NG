using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface ILanguageFactory
    {
        ISound sound();
        ISubtitles subtitles();
    }
}
