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
        /// <summary>
        /// variable para hacer operaciones
        /// </summary>
        private double _OperadorX;
        /// <summary>
        /// variable para hacer operaciones
        /// </summary>
        private double _OperadorY;
        /// <summary>
        /// Resultado de la operacion
        /// </summary>
        private double _Resultado;



        /// <summary>
        /// Enlace entre la variable privada y el get y set que sirve para manejar el valor del propertychange
        /// </summary>
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

        /// <summary>
        /// Enlace entre la variable privada y el get y set que sirve para manejar el valor del propertychange
        /// </summary>
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

        /// <summary>
        /// Enlace entre la variable privada y el get y set que sirve para manejar el valor del propertychange
        /// </summary>
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
        /// <summary>
        /// Lista de comandos para cada funcion
        /// </summary>
        public ICommand Suma { get; }
        public ICommand Resta { get; }
        public ICommand Producto { get; }
        public ICommand Division { get; }
        public ICommand Potencia { get; }
        public ICommand Resto { get; }



        /// <summary>
        /// Contructor de la clase inicializa los command (haven referencia a la funcion)
        /// </summary>
        public CalculadoraVM()
        {
            Suma = new Command(OperacionSuma);
            Resta = new Command(OpeacionResta);
            Producto = new Command(OperacionProducto);
            Division = new Command(OperacionDivision);
            Potencia = new Command(OperacionPotencia);
            Resto = new Command(OperacioResto);
        }
        /// <summary>
        /// llama a la interfaz y devuelve el resultado de una operacion division
        /// </summary>
        private void OperacionDivision()
        {
            Resultado = ClsCalculadora.division(OperadorX, OperadorY);
        }
        /// <summary>
        /// llama a la interfaz y devuelve el resultado de una operacion producto
        /// </summary>
        private void OperacionProducto()
        {
            Resultado = ClsCalculadora.producto(OperadorX, OperadorY);
        }
        /// <summary>
        /// llama a la interfaz y devuelve el resultado de una operacion resta
        /// </summary>
        private void OpeacionResta()
        {
            Resultado = ClsCalculadora.resta(OperadorX, OperadorY);
        }
        /// <summary>
        /// llama a la interfaz y devuelve el resultado de una operacion suma
        /// </summary>s
        private void OperacionSuma()
        {
            Resultado = ClsCalculadora.suma(OperadorX, OperadorY);
        }
        /// <summary>
        /// llama a la interfaz y devuelve el resultado de una operacion potencia
        /// </summary>
        private void OperacionPotencia()
        {
            Resultado = ClsCalculadora.potencia(OperadorX, OperadorY);
        }


        /// <summary>
        /// llama a la interfaz y devuelve el resultado de una operacion resta
        /// </summary>
        private void OperacioResto()
        {
            Resultado = ClsCalculadora.resto(OperadorX, OperadorY);
        }

        /// <summary>
        /// implementacion INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
