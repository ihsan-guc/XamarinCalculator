using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinCalculator.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
		public CalculatorViewModel()
		{
			digitcommand = new Command(Digit);
		}
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
		private ICommand enterCommand;
		public ICommand EnterCommand
		{
			get { return enterCommand; }
			set { enterCommand = value; OnPropertyChanged(); }
		}
		private ICommand backspaceCommand;
		public ICommand BackspaceCommand
		{
			get { return backspaceCommand; }
			set { backspaceCommand = value; OnPropertyChanged(); }
		}
		private ICommand unaryOperation;
		public ICommand UnaryOperation
		{
			get { return unaryOperation; }
			set { unaryOperation = value;OnPropertyChanged(); }
		}
		void Digit(object param)
		{
			Result = Convert.ToInt32(param);
		}
		void RefreshCanExecutes()
		{
			((Command)BackspaceCommand).ChangeCanExecute();
			((Command)UnaryOperation).ChangeCanExecute();
			((Command)BinaryOperation).ChangeCanExecute();
			((Command)DigitCommand).ChangeCanExecute();
		}
	}
}
