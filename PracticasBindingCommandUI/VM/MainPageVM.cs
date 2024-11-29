using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace PracticasBindingCommandUI.VM
{
    internal class MainPageVM : INotifyPropertyChanged
    {
        private string _texto;
        private string _entrytexto;
        private int _longitudTexto;

        // Longitud del texto mostrado
        public int LongitudTexto
        {
            get => _longitudTexto;
            set
            {
                if (_longitudTexto != value)
                {
                    _longitudTexto = value;
                    OnPropertyChanged(nameof(LongitudTexto));
                }
            }
        }

        // Texto principal mostrado en el Label
        public string Texto
        {
            get => _texto;
            set
            {
                if (_texto != value)
                {
                    _texto = value;
                    OnPropertyChanged(nameof(Texto));
                    ObtenerLongitudTexto();
                }
            }
        }

        // Texto introducido en el Entry
        public string Entrytexto
        {
            get => _entrytexto;
            set
            {
                if (_entrytexto != value)
                {
                    _entrytexto = value;
                    OnPropertyChanged(nameof(Entrytexto));
                    OnPropertyChanged(nameof(CanUpdate)); // Actualiza el estado del botón
                }
            }
        }

        // Propiedad calculada para habilitar o deshabilitar el botón
        public bool CanUpdate => !string.IsNullOrWhiteSpace(Entrytexto);

        // Comandos
        public ICommand ActualizarCommand { get; }
        public ICommand TextoInvertidoCommand { get; }

        public MainPageVM()
        {
            ActualizarCommand = new Command(ActualizarTexto, () => CanUpdate); // Comando habilitado según `CanUpdate`
            TextoInvertidoCommand = new Command(TextoInvertido);
            Texto = "Texto inicial";
            Entrytexto = string.Empty;
        }

        // Lógica del comando "Actualizar"
        private void ActualizarTexto()
        {
            Texto = Entrytexto;
        }

        // Lógica del comando "Invertir Texto"
        private void TextoInvertido()
        {
            Texto = new string((Texto ?? string.Empty).Reverse().ToArray());
        }

        // Calcula la longitud del texto
        private void ObtenerLongitudTexto()
        {
            LongitudTexto = Texto?.Length ?? 0;
        }

        // Evento que notifica los cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            // Refresca el estado del botón cuando cambie `CanUpdate`
            if (propertyName == nameof(CanUpdate))
            {
                ((Command)ActualizarCommand).ChangeCanExecute();
            }
        }
    }
}
