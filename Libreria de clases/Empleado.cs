using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Empleado
    {
        #region "Atributos"
        private string _rut;
        private ArrayList _tratos;
        #endregion

        #region "Constructores"
        public Empleado()
        {
            _rut = string.Empty;
            _tratos = new ArrayList();
        }

        public Empleado( string rut, ArrayList tratos)
        {
            _rut = rut;
            _tratos = tratos;
        }
        #endregion

        #region "Propiedades"
        public string Rut

        {
            get { return _rut; }
            set { _rut = value; }
        }

        public ArrayList Tratos
        {
            get { return _tratos; }
            set { _tratos = value; }
        }
        #endregion

        #region "Métodos"
        public void agregarTrato(Trato trato)
        {
            _tratos.Add(trato);
        }

        public void eliminarTrato(int index)
        {
            foreach (Trato e in _tratos)
            {
                if (e.Numero == index)
                {
                    _tratos.Remove(e);
                    break;
                }
            }
        }

        public string obtenerPorEstadoTrato(string estado)
        {
            int contador = 0;
            int monto = 0;
            StringBuilder datos = new StringBuilder();
            foreach (Trato e in _tratos)
            {
                if (e.Estado.Equals(estado))
                {
                    contador++;
                    monto += e.Monto;
                }
            }
            datos.AppendFormat("Cantidad      : {0} \n", contador);
            datos.AppendFormat("Monto      : {0} \n", monto);
            return datos.ToString();

        }
        #endregion

    }
}
