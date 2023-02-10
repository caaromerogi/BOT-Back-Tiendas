using Domain.Model.Entities.Request;
using System;
using System.Threading.Tasks;

namespace Domain.UseCase.TiendaCommand
{
    /// <summary>
    /// <see cref="ITiendaCommandUseCase"/>
    /// </summary>
    public class TiendaCommandUseCase : ITiendaCommandUseCase
    {
        /// <summary>
        ///  <see cref="ITiendaCommandUseCase.NotificarTiendaCreada(TiendaRequest)"/>
        /// </summary>
        /// <param name="tienda"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task NotificarTiendaCreada(TiendaRequest tienda)
        {
            //TODO: Enviar correo con la creación de la tienda.
            throw new NotImplementedException();
        }
    }
}