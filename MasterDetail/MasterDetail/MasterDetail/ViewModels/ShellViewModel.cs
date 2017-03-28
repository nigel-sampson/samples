using System;
using Caliburn.Micro;

namespace MasterDetail.ViewModels
{
    public class ShellViewModel : Screen
    {
        private CharacterViewModel selectedCharacter;
        private bool masterListAvailable;

        public ShellViewModel()
        {
            MasterListAvailable = true;

            Characters = new BindableCollection<CharacterViewModel>
            {
                new CharacterViewModel("Shadow Moon", "The Ex-Con", "character1.jpg"),
                new CharacterViewModel("Mr Wednesday", "The Con Man", "character2.jpg"),
                new CharacterViewModel("Laura Moon", "The Dead Wife", "character3.jpg"),
                new CharacterViewModel("Bilquis", "The Goddess of Love", "character4.jpg"),
                new CharacterViewModel("Mr World", "His name says it all", "character5.jpg"),
                new CharacterViewModel("Czernobog", "The God of Evil", "character6.jpg"),
                new CharacterViewModel("Mr Nancy", "The Trickster God", "character7.jpg"),
                new CharacterViewModel("Mad Sweeny", "The Leprechaun", "character8.jpg"),
                new CharacterViewModel("Technical Boy", "The God of Technology", "character9.jpg"),
                new CharacterViewModel("Easter", "The Godess of Spring", "character10.jpg"),
            };
        }

        public BindableCollection<CharacterViewModel> Characters { get; }

        public CharacterViewModel SelectedCharacter
        {
            get { return selectedCharacter; }
            set
            {
                selectedCharacter = value;
                NotifyOfPropertyChange();

                MasterListAvailable = SelectedCharacter == null;
            }
        }

        public bool MasterListAvailable
        {
            get { return masterListAvailable; }
            set
            {
                masterListAvailable = value;
                NotifyOfPropertyChange();
            }
        }
    }
}
