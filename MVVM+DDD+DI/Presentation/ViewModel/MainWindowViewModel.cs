using System.Windows.Input;
using MVVM_DDD_DI.Common;

namespace MVVM_DDD_DI.Presentation.ViewModel
{
	public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _currentView;

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

		public ICommand ShowDataListCommand { get; }

		private readonly StartViewModel _startViewModel;
		private readonly DataListViewModel _dataListViewModel;

		public MainWindowViewModel()
		{
			_startViewModel = new StartViewModel();
			_dataListViewModel = new DataListViewModel();

			CurrentView = _startViewModel;

			ShowDataListCommand = new RelayCommand<object>(param =>
			{
				CurrentView = _dataListViewModel;
			});
		}
	}
}
