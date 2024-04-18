using ApisFlutter.Models;
using ApisFlutter.Models.DTOS;
using Azure;

namespace ApisFlutter.Interfaces
{
    public interface IDashboardService
    {
        Task<List<TipoProducto>> GetTipoProductosAsync();
        Task<TipoProductoDTO> CreateTipoProductoAsync(TipoProductoDTO tipoProductoDTO);
        Task<List<Proveedor>> GetProveedorAsync();
        Task<ProveedorDTO> CreateProveedorAsync(ProveedorDTO proveedorDTO);
        Task<List<Producto>> GetProductoAsync();
        Task<ProductoDTO> CreateProductoAsync(ProductoDTO productoDTO);

    }
}
