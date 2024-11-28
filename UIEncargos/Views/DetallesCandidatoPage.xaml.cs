namespace UIEncargos;

using ENT_Encargos;
using UIEncargos.VM;
public partial class DetallesCandidatoPage : ContentPage
{
    public DetallesCandidatoPage(Candidato x)
    {
        InitializeComponent();
        BindingContext = new DetallesCandidato(x);
    }
}