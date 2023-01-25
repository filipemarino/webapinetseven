using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapinetseven.domain.ListaCompras.DTO;

namespace webapinetseven.domain.ListaCompras.Interfaces;

/// <summary>
/// Método que implementa uma criação de lista de compras
/// </summary>
public interface IListaComprasBO
{
    void CriaListaCompra(ListaCompraInputDTO listaCompraInput);
}