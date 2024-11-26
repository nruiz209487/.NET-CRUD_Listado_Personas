using UI__ModeloMaui.VM.UI__ModeloMaui.VM;

namespace UI__ModeloMaui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            // Establecer el BindingContext con una instancia de PersonasViewModel
            BindingContext = new PersonasViewModel();
        }

    }

}
