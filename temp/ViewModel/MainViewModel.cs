using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using temp.Tools;

namespace temp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string textProp;
        private string selectedFood;
        private ObservableCollection<string> foolList = new() { "Pizza", "Fish", "Rice" };

        public ICommand ButtonTapCommand { get; private set; }

        //Constructor
        public MainViewModel()
        {
            ButtonTapCommand = new CommandHandler(DoSth);
            TextProp = "kasra";
            SelectedFood = "Fish";
        }

        private void DoSth()
        {
            TextProp = "AmirReza";
        }


        #region Properties
        public string TextProp
        {
            get => textProp;
            set
            {
                textProp = value;
                OnPropertyChanged("TextProp");
            }

        }

        public ObservableCollection<string> FoolList
        {
            get => foolList;
            set
            {
                foolList = value;
                OnPropertyChanged("FoolList");
            }
            
        }
        public string SelectedFood
        {
            get => selectedFood;
            set
            {
                selectedFood = value;
                OnPropertyChanged("SelectedFood");
            }

        }

        #endregion
    }
}
