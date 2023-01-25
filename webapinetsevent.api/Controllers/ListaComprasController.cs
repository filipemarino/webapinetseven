using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapinetseven.domain.ListaCompras.DTO;
using webapinetseven.domain.ListaCompras.Interfaces;

namespace webapinetsevent.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ListaComprasController : ControllerBase
{
    private readonly ILogger<ListaComprasController> _logger;
    private readonly IListaComprasBO _listaCompras;

    public ListaComprasController(ILogger<ListaComprasController> logger, IListaComprasBO listaCompras)
    {
        _logger = logger;
        _listaCompras = listaCompras;
    }
    
    [HttpPost(Name = "CriaListaCompra")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Post(ListaCompraInputDTO input)
    {
        _listaCompras.CriaListaCompra(input);

        return Ok("");
    }
}
