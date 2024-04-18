using ApisFlutter.Context;
using ApisFlutter.Interfaces;
using ApisFlutter.Models;
using ApisFlutter.Models.DTOS;
using Azure;
using Microsoft.EntityFrameworkCore;

namespace ApisFlutter.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly ApplicationDbContext _dbContext;

        public DashboardService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductoDTO> CreateProductoAsync(ProductoDTO productoDTO)
        {
            Producto producto = new()
            {
                Nombre = productoDTO.Nombre,
                Descripcion = productoDTO.Descripcion,
                Precio = productoDTO.Precio,
                TipoProductoId = productoDTO.TipoProductoId,
                ProveedorId = productoDTO.ProveedorId
            };

            _dbContext.producto.Add(producto);
            await _dbContext.SaveChangesAsync();

            ProductoDTO result = new()
            {
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,
                TipoProductoId = producto.TipoProductoId,
                ProveedorId = producto.ProveedorId
            };

            return result;
        }

        public async Task<ProveedorDTO> CreateProveedorAsync(ProveedorDTO proveedorDTO)
        {
            Proveedor provedor = new()
            {
                Nombre = proveedorDTO.Nombre,
                Contacto = proveedorDTO.Contacto,
            };

            _dbContext.proveedor.Add(provedor);
            await _dbContext.SaveChangesAsync();

            ProveedorDTO result = new()
            { 
                Nombre = provedor.Nombre,
                Contacto = provedor.Contacto,
            };

            return result;
        }

        public async Task<TipoProductoDTO> CreateTipoProductoAsync(TipoProductoDTO tipoProductoDTO)
        {
            
            TipoProducto tipoProducto = new ()
            {
                Nombre = tipoProductoDTO.Nombre,
            };

            _dbContext.tipoProducto.Add(tipoProducto);
            
            await _dbContext.SaveChangesAsync();

            TipoProductoDTO resultadoDTO = new ()
            {
                Nombre = tipoProducto.Nombre,
            };
            return resultadoDTO;
        }

        public async Task<List<Producto>> GetProductoAsync()
        {
            List<Producto> productos = await _dbContext.producto.ToListAsync();

            return productos;
        }

        public async Task<List<Proveedor>> GetProveedorAsync()
        {
            List<Proveedor> Proveedores = await _dbContext.proveedor.ToListAsync();

            return Proveedores;
        }

        public async Task<List<TipoProducto>> GetTipoProductosAsync( )
        {
            List<TipoProducto> tiposDeProductos = await _dbContext.tipoProducto.ToListAsync();

            return tiposDeProductos;
        }
    }
}
