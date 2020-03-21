
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCalculator.ViewModel;

namespace XamarinCalculator.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}