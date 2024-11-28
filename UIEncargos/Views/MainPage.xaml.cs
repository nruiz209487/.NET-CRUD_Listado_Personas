using UIEncargos.VM;

namespace UIEncargos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MisionesConCandidatos();
        }
    }
}
