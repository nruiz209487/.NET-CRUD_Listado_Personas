using PracticasBindingCommandUI.VM;

namespace PracticasBindingCommandUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }


    }

}
