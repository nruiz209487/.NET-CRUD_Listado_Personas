using BL_Encargos;
using ENT_Encargos;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace UIEncargos.VM
{
    public class MisionesConCandidatos : INotifyPropertyChanged
    {
        // Propiedades observables para enlazar con la vista
        public ObservableCollection<Mision> Misiones { get; set; }
        public ObservableCollection<Candidato> CandidatosPorMision { get; set; }

        private Mision _misionSeleccionada;
        private Candidato _candidatoSeleccionado;
        // Propiedad para la misión seleccionada
        public Mision MisionSeleccionada
        {
            get => _misionSeleccionada;
            set
            {
                if (_misionSeleccionada != value)
                {
                    _misionSeleccionada = value;
                    OnPropertyChanged(nameof(MisionSeleccionada));
                    FiltrarCandidatos(); // Actualizar candidatos automáticamente
                }
            }
        }
        public Candidato CandidatoSeleccionado
        {
            get => _candidatoSeleccionado;
            set
            {
                if (_candidatoSeleccionado != value)
                {
                    _candidatoSeleccionado = value;
                    OnPropertyChanged(nameof(CandidatoSeleccionado));

                    // Invocar el comando directamente al seleccionar un candidato
                    if (NavegarADetallesCommand.CanExecute(null))
                    {
                        NavegarADetallesCommand.Execute(null);
                    }
                }
            }
        }

        public ICommand NavegarADetallesCommand { get; }
        public MisionesConCandidatos()
        {
            // Inicializar las colecciones
            Misiones = new ObservableCollection<Mision>(ServiceBL.ObtenerListadoDeMisiones());
            CandidatosPorMision = new ObservableCollection<Candidato>();
            NavegarADetallesCommand = new Command(MostrarDetallesCandidato);
        }
        private async void MostrarDetallesCandidato()
        {
            if (CandidatoSeleccionado != null)
            {

                await Application.Current.MainPage.Navigation.PushAsync(new DetallesCandidatoPage(CandidatoSeleccionado));
            
           
            }
        }
        // Método para filtrar candidatos según la misión seleccionada
        private void FiltrarCandidatos()
        {
            if (MisionSeleccionada != null)
            {
                // Obtener la lista filtrada desde el servicio
                var candidatosFiltrados = ServiceBL.ObtenerListadoDeCandidatosPorMision(MisionSeleccionada.Dificultad);

                // Actualizar la colección observable
                CandidatosPorMision.Clear();
                foreach (var candidato in candidatosFiltrados)
                {
                    CandidatosPorMision.Add(candidato);
                }
            }
            else
            {
                // Si no hay misión seleccionada, limpiar la lista
                CandidatosPorMision.Clear();
            }
        }

        // Implementación de PropertyChanged para notificar cambios
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
