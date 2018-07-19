using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Trato
    {

        #region "Atributos"
        private int _numero;
        private DateTime _fecha;
        private int _monto;
        private string _estado;
        #endregion
        #region "Constructores"
        public Trato()
        {
            _numero = 0;
            _fecha = new DateTime();
            _monto = 0;
            _estado = string.Empty;
        }

        public Trato( int numero, DateTime fecha, int monto, string estado)
        {
            _numero = numero;
            _fecha = fecha;
            _monto = monto;
            _estado = estado;
        }
        #endregion
        #region "Propiedades"
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public int Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        #endregion
        #region "Métodos"
        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Número      : {0} \n", _numero);
            sb.AppendFormat("Estado      : {0} \n", _estado);
            sb.AppendFormat("Monto       : {0} \n", _monto);
            return sb.ToString();

        }
        #endregion
    }
}
