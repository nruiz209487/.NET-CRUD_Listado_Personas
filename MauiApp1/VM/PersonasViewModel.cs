using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using BL;
using ENT_Modelo;

namespace MauiApp1.VM
{
    public class PersonasViewModel : INotifyPropertyChanged
    {
        // Propiedad ObservableCollection para mantener las personas
        public ObservableCollection<clsPersonaConNombreDept> Personas { get; } = new ObservableCollection<clsPersonaConNombreDept>(ClsListadoDePersonas.ObtenerListado());

        private clsPersonaConNombreDept _personaSeleccionada;

        // Propiedad para la persona seleccionada
        public clsPersonaConNombreDept PersonaSeleccionada
        {
            get => _personaSeleccionada;
            set
            {
                if (_personaSeleccionada != value)
                {
                    _personaSeleccionada = value;
                    OnPropertyChanged(nameof(PersonaSeleccionada)); // Notifica el cambio
                }
            }
        }

        // Comandos para agregar, eliminar, modificar y actualizar
        public ICommand AgregarCommand { get; }
        public ICommand EliminarCommand { get; }
        public ICommand ModificarCommand { get; }
        public ICommand ActualizarCommand { get; } // Comando de actualización

        public PersonasViewModel()
        {
            // Inicializamos los comandos
            AgregarCommand = new Command(AgregarPersona);
            EliminarCommand = new Command(EliminarPersona);
            ModificarCommand = new Command(ModificarPersona);
            ActualizarCommand = new Command(ActualizarListadoPersonas); // Asignamos el comando de actualización
        }

        // Método para actualizar la lista de personas
        public void ActualizarListadoPersonas()
        {
            // Actualiza la lista desde la capa DAL
            var listadoActualizado = ClsListadoDePersonas.ObtenerListado();

            // Limpiar la colección y agregar los nuevos elementos sin duplicados
            Personas.Clear();

            // Asegúrate de que no haya duplicados en la lista.
            foreach (var persona in listadoActualizado)
            {
     
          
                    Personas.Add(persona);
                
            }
        }


        // Método para agregar una persona
        public void AgregarPersona()
        {
            if (PersonaSeleccionada != null)
            {
                int id = ListaPersonasBL.ObtenerListadoPersonas().Count + 1;
                ClsPersona nuevaPersona = new ClsPersona(
                   id,
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
        }

        // Método para eliminar una persona
        public void EliminarPersona()
        {
            if (PersonaSeleccionada != null)
            {
                ListaPersonasBL.EliminarPersona(PersonaSeleccionada.id);
                Personas.Remove(PersonaSeleccionada);
            }
        }

        // Método para modificar una persona
        public void ModificarPersona()
        {
            if (PersonaSeleccionada != null)
            {
               int  id = PersonaSeleccionada.id;
                ClsPersona nuevaPersona = new ClsPersona(
                    PersonaSeleccionada.id,
                    PersonaSeleccionada.nombre,
                    PersonaSeleccionada.apellidos,
                    PersonaSeleccionada.fechaNac,
                    PersonaSeleccionada.direccion,
                    PersonaSeleccionada.img,
                    PersonaSeleccionada.telefono,
                    PersonaSeleccionada.dept
                );
                ListaPersonasBL.ModificarPersona(nuevaPersona);
            }
        }

        // Evento que notifica los cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
