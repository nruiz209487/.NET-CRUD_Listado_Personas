using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI__ModeloMaui.VM
{
    using BL;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Input;

    namespace UI__ModeloMaui.VM
    {
        public class PersonasViewModel : INotifyPropertyChanged
        {
            public clsPersonaConNombreDept PersonaSeleccionada { get; set; }

            public ICommand AgregarCommand { get; }
            public ICommand EliminarCommand { get; }
            public ICommand ModificarCommand { get; }

            public PersonasViewModel()
            {
                AgregarCommand = new Command(AgregarPersona);
                EliminarCommand = new Command(EliminarPersona);
                ModificarCommand = new Command(ModificarPersona);
            }

            public static ObservableCollection<clsPersonaConNombreDept> ObtenerPersonas()
            {
                return new ObservableCollection<clsPersonaConNombreDept>(ClsListadoDePersonas.ObtenerListado());
            }

            public void AgregarPersona()
            {
                var nuevaPersona = new clsPersonaConNombreDept(
                    PersonaSeleccionada.id,
                    PersonaSeleccionada.nombre,
                    PersonaSeleccionada.apellidos,
                    PersonaSeleccionada.fechaNac,
                    PersonaSeleccionada.direccion,
                    PersonaSeleccionada.img,
                    PersonaSeleccionada.telefono,
                    PersonaSeleccionada.dept
                );

                ListaPersonasBL.AnyadirPersona(nuevaPersona);
            }

            public void EliminarPersona()
            {
                ListaPersonasBL.EliminarPersona(PersonaSeleccionada.id);
            }

            public void ModificarPersona()
            {
                ListaPersonasBL.ModificarPersona(PersonaSeleccionada);
            }

            public event PropertyChangedEventHandler PropertyChanged;
            private void NotificarCambio(string propiedad) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }
    }

}
