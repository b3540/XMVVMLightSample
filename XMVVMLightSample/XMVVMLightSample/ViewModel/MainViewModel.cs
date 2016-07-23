using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using XMVVMLightSample.View;

namespace XMVVMLightSample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _inputText;
        public string InputText
        {
            get { return _inputText; }
            set { _inputText = value; RaisePropertyChanged(); RaisePropertyChanged(nameof(LabelText)); }
        }

        public string LabelText => _inputText + _inputText;

        public RelayCommand Command { get; private set; }

        public MainViewModel() {
            Command = new RelayCommand(() => {
                App.Current.MainPage.Navigation.PushModalAsync(ServiceLocator.Current.GetInstance<SecondView>());
            });
        }

    }
}