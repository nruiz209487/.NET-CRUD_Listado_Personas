using ENT_Encargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIEncargos.VM
{
    public class DetallesCandidato
    {

        public CandidatoConEdad candidatoSeleccionado { get; set; }

        public ICommand VolverAtrasCommand { get; set; }

        public DetallesCandidato(Candidato x)
        {

            candidatoSeleccionado = new CandidatoConEdad(x.Id, x.Nombre, x.Apellidos, x.Direccion, x.Pais, x.Telefono, x.FechaNacimiento, x.Precio);
            VolverAtrasCommand = new Command(NavegarAtras);
        }




        private async void NavegarAtras(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
    }
}
