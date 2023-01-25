using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using webapinetseven.domain.ListaCompras.DTO;
using webapinetseven.domain.ListaCompras.Interfaces;

namespace webapinetseven.domain.ListaCompras.BusinessObjects;

public class ListaComprasBO : IListaComprasBO
{
    private readonly ILogger<ListaComprasBO> _logger;

    public ListaComprasBO(ILogger<ListaComprasBO> logger)
    {
        _logger = logger;
    }

    public void CriaListaCompra(ListaCompraInputDTO listaCompraInput)
    {
        throw new NotImplementedException();
    }
}