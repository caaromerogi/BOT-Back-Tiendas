using Domain.Model.Entities;
using Domain.Model.EntityRequests;
using Domain.UseCase.Common;
using Domain.UseCase.Tiendas;
using EntryPoints.ReactiveWeb.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntryPoints.ReactiveWeb.Controllers
{
    /// <summary>
    /// TiendasController
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class TiendasController : AppControllerBase<TiendasController>
    {
        private readonly ITiendaUseCase _tiendaUseCase;

        /// <summary>
        /// Initializes a new instance of the <see cref="TiendasController"/> class.
        /// </summary>
        /// <param name="tiendaUseCase">The test negocio.</param>
        /// <param name="eventsService">The logger.</param>
        public TiendasController(ITiendaUseCase tiendaUseCase,
            IManageEventsUseCase eventsService) : base(eventsService)
        {
            _tiendaUseCase = tiendaUseCase;
        }

        /// <summary>
        /// CrearAlmacenes
        /// </summary>
        /// <param name="tiendaRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CrearAlmacenes(TiendaRequest tiendaRequest) =>
                await HandleRequestAsync(
                    async () =>
                    {
                        return await _tiendaUseCase.CrearTienda(tiendaRequest);
                    }, "");

        /// <summary>
        /// Método para Obtener los Asesores
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerTiendas() =>
            await HandleRequestAsync(
                    async () =>
                    {
                        return await _tiendaUseCase.ObtenerTiendas();
                    }, "");
    }
}