using System.Text;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMB;

     
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMB = tamanioMB;
        }

        public SistemaOperativo SistemaOperativo { get => sistemaOperativo;  }
        protected virtual int Tamanio { get => tamanioMB;  }

        /// <summary>
        /// Retorna los datos de la aplicación.
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema Operativo: {sistemaOperativo}{Environment.NewLine}");
            sb.AppendLine($"Tamañio: {Tamanio}");
            return sb.ToString();
        }


        /// <summary>
        /// El operador implícito recibirá una lista de aplicaciones y devolverá la instancia de la aplicación
        /// que más tamaño tenga.
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp) 
        {
            Aplicacion aplicacionMasPesada = null; 
            foreach (Aplicacion item in listaApp)
            {
                if (aplicacionMasPesada is null || item.Tamanio > aplicacionMasPesada.Tamanio) 
                {
                    aplicacionMasPesada =   item;
                }
            }

            return aplicacionMasPesada;
               
        }


        /// <summary>
        /// La sobrecarga del operador == buscará si una aplicación existe en la lista recibida por
        /// parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si ya existe.</returns>
        public static bool operator ==(List<Aplicacion> listaCanciones, Aplicacion app) 
        {
            foreach (Aplicacion item in listaCanciones)
            {
                if (item.nombre ==app.nombre )
                {
                        return true;
                }
            }
            return false;
        }


        /// <summary>
        /// La sobrecarga del operador != buscará si una aplicación no existe en la lista recibida por
        /// parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si no existe.</returns>
        public static bool operator !=(List<Aplicacion> listaApp,Aplicacion app)
        {
            return !(listaApp==app) ;
        }


        /// <summary>
        /// La sobrecarga del operador + añadirá una aplicación a la lista de aplicaciones pasada por
        /// parámetro siempre y cuando sea no exista previamente.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si pudo añadir la aplicación.</returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);  
                return true;
            }
            return false;
        }


        /// <summary>
        /// Retorna el nombre de la aplicación.
        /// </summary>
        /// <returns></returns>
        public string ToString() 
        {
            return this.nombre;
        }
    }
}