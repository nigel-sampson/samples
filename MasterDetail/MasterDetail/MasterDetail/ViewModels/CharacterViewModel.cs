using System;
using Caliburn.Micro;

namespace MasterDetail.ViewModels
{
    public class CharacterViewModel : PropertyChangedBase
    {
        public CharacterViewModel(string name, string tagline, string image)
        {
            Name = name;
            Tagline = tagline;
            Image = image;
        }

        public string Name { get; }
        public string Tagline { get; }
        public string Image { get; }
    }
}
