using System;

namespace Domain.Model.Entities
{
    /// <summary>
    /// Clase Tienda
    /// </summary>
    public class Tienda
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Valor Nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Tipo
        /// </summary>
        public Tipo Tipo { get; set; }

        /// <summary>
        /// Dirección
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Ubicación
        /// </summary>
        public Ubicacion Ubicacion { get; set; }

        /// <summary>
        /// Valor Numero del Celular
        /// </summary>
        public string Celular { get; set; }

        /// <summary>
        /// Valor de el Correo
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Valor Fecha Creación
        /// </summary>
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipo"></param>
        /// <param name="direccion"></param>
        /// <param name="ubicacion"></param>
        /// <param name="celular"></param>
        /// <param name="correo"></param>
        public Tienda(string nombre, Tipo tipo, string direccion, Ubicacion ubicacion, string celular, string correo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Direccion = direccion;
            Ubicacion = ubicacion;
            Celular = celular;
            Correo = correo;
            FechaCreacion = DateTime.Now;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        /// <param name="ubicacion"></param>
        /// <param name="celular"></param>
        /// <param name="correo"></param>
        /// <param name="tipoId"></param>
        public Tienda(string nombre, int tipoId, string direccion, Ubicacion ubicacion,
            string celular, string correo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Ubicacion = ubicacion;
            Celular = celular;
            Correo = correo;
            Tipo = new Tipo(tipoId);
            FechaCreacion = DateTime.Now;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="tipo"></param>
        /// <param name="direccion"></param>
        /// <param name="ubicacion"></param>
        /// <param name="celular"></param>
        /// <param name="correo"></param>
        /// <param name="fechaCreacion"></param>
        public Tienda(string id, string nombre, Tipo tipo, string direccion, Ubicacion ubicacion, string celular, string correo, DateTime fechaCreacion)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Direccion = direccion;
            Ubicacion = ubicacion;
            Celular = celular;
            Correo = correo;
            FechaCreacion = fechaCreacion;
        }

        /// <summary>
        /// Establecer tipo de tienda.
        /// </summary>
        /// <param name="tipo"></param>
        public void EstablecerNombreTipo(Tipo tipo)
        {
            Tipo = tipo;
        }
    }
}