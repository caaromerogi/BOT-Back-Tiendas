using Domain.Model.Entities;
using Domain.Model.Entities.Gateway;
using Domain.Model.EntityRequests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.UseCase.Tiendas
{
    /// <summary>
    /// <see cref="ITiendaUseCase"/>
    /// </summary>
    public class TiendaUseCase : ITiendaUseCase
    {
        private readonly ITiendaRepository _tiendaRepository;
        private readonly ITipoRepository _tipoRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TiendaUseCase"/> class.
        /// </summary>
        /// <param name="tiendaRepository">The logger.</param>
        /// <param name="tipoRepository">The logger.</param>
        public TiendaUseCase(ITiendaRepository tiendaRepository,
            ITipoRepository tipoRepository)
        {
            _tiendaRepository = tiendaRepository;
            _tipoRepository = tipoRepository;
        }

        /// <summary>
        /// <see cref="ITiendaUseCase.CrearTienda(TiendaRequest)"/>
        /// </summary>
        /// <param name="tiendaRequest"></param>
        /// <returns></returns>
        public async Task<Tienda> CrearTienda(TiendaRequest tiendaRequest)
        {
            Tienda nuevaTienda = tiendaRequest.AsEntity();

            Tipo tipo = await _tipoRepository.ObtenerTipoPorIdAsync(tiendaRequest.TipoId);

            nuevaTienda.EstablecerNombreTipo(tipo);

            return await _tiendaRepository.InsertarAlmacenAsync(nuevaTienda);
        }

        /// <summary>
        /// <see cref="ITiendaUseCase.ObtenerTiendas"/>
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tienda>> ObtenerTiendas() =>
            await _tiendaRepository.ObtenerTiendasAsync();
    }
}