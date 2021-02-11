using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface ILanguage
    {
        ISound sound();
        ISubtitles subtitles();
    }
}
