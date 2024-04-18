using ApisFlutter.Interfaces;
using ApisFlutter.Models.DTOS;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace ApisFlutter.Controllers
{
    [Route("api/dashboard")]
    [ApiController]
    public class DashboardController : Controller
    {
        private readonly IDashboardService _service;
        public DashboardController(IDashboardService service)
        {
            _service = service;
        }

        [Route("GetTipoProductos")]
        [HttpGet()]
        public async Task<IActionResult> GetTipoProductos()
        {
            var result = await _service.GetTipoProductosAsync();
            return Ok(result);
        }

        [Route("GetProveedor")]
        [HttpGet()]
        public async Task<IActionResult> GetProveedor()
        {
            var result = await _service.GetProveedorAsync();
            return Ok(result);
        }

        [Route("GetProducto")]
        [HttpGet()]
        public async Task<IActionResult> GetProducto()
        {
            var result = await _service.GetProductoAsync();
            return Ok(result);
        }

        [Route("CreateProducto")]
        [HttpPost]
        public async Task<ActionResult<ProductoDTO>> CreateProducto(ProductoDTO productoDTO)
        {
            var result = await _service.CreateProductoAsync(productoDTO);
            return Ok(result);
        }

        [Route("CreateTipoProducto")]
        [HttpPost]
        public async Task<ActionResult<TipoProductoDTO>> CreateTipoProducto(TipoProductoDTO tipoProductoDTO)
        {
            // Llama al servicio para crear el tipo de producto
            var result = await _service.CreateTipoProductoAsync(tipoProductoDTO);
            return Ok(result);
        }

        [Route("Createproveedor")]
        [HttpPost]
        public async Task<ActionResult<ProveedorDTO>> Createproveedor(ProveedorDTO proveedorDTO)
        {
            // Llama al servicio para crear el tipo de producto
            var result = await _service.CreateProveedorAsync(proveedorDTO);
            return Ok(result);
        }

    }
}
