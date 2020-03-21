using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace XamarinCalculator.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;
		void OnPropertyChanged([CallerMemberName] string property = null)
		{
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
		}
		private int result;
		public int Result
		{
			get { return result; }
			set { result = value; OnPropertyChanged(); }
		}
		private ICommand digitcommand;
		public ICommand DigitCommand
		{
			get { return digitcommand; }
			set { digitcommand = value; OnPropertyChanged(); }
		}
		private ICommand clearEntryCommand;

		public ICommand ClearEntryCommand
		{
			get { return clearEntryCommand; }
			set { clearEntryCommand = value; OnPropertyChanged(); }
		}
		private ICommand binaryOperation;

		public ICommand BinaryOperation
		{
			get { return binaryOperation; }
			set { binaryOperation = value; OnPropertyChanged(); }
		}

	}
}
