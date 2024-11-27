using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectoCalculadora.Models
{
    public class CalculadoraVM : INotifyPropertyChanged
    {
        private double _OperadorX;
        private double _OperadorY;
        private double _Resultado;
        public double OperadorX
        {
            get => _OperadorX;
            set
            {
                if (_OperadorX != value)
                {
                    _OperadorX = value;
                    OnPropertyChanged(nameof(OperadorX)); 
                }
            }
        }
        public double OperadorY
        {
            get => _OperadorY;
            set
            {
                if (_OperadorY != value)
                {
                    _OperadorY = value;
                    OnPropertyChanged(nameof(OperadorY)); 
                }
            }
        }
        public double Resultado
        {
            get => _Resultado;
            set
            {
                if (_Resultado != value)
                {
                    _Resultado = value;
                    OnPropertyChanged(nameof(Resultado)); 
                }
            }
        }
    
        public ICommand Suma { get; }
        public ICommand Resta { get; }
        public ICommand Producto { get; }
        public ICommand Division { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public CalculadoraVM()
        {
            Suma = new Command(OperacionSuma);
            Resta = new Command(OpeacionResta);
            Producto = new Command(OperacionProducto);
            Division = new Command(OperacionDivision);
        }

        private void OperacionDivision()
        {
            Resultado = ClsCalculadora.division(OperadorX, OperadorY);
        }

        private void OperacionProducto()
        {
            Resultado = ClsCalculadora.producto(OperadorX, OperadorY);
        }

        private void OpeacionResta()
        {
            Resultado = ClsCalculadora.resta(OperadorX, OperadorY);
        }

        private void OperacionSuma()
        {
            Resultado = ClsCalculadora.suma(OperadorX, OperadorY);
        }
    }



}
