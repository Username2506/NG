using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Movie
    {
        ISound sound;
        ISubtitles subtitles;

        public Movie(ILanguage lang)
        {
            sound = lang.sound();
            subtitles = lang.subtitles();
        }

        public void setLanguage(ILanguage lang)
        {
            sound = lang.sound();
            subtitles = lang.subtitles();
        }

        public void showMovie()
        {
            sound.playSound();
            subtitles.showSubtitles();
        }
    }
}
