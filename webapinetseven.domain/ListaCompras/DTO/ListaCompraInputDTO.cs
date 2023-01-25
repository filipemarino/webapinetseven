using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapinetseven.domain.ListaCompras.DTO;

public class ListaCompraInputDTO
{
    public string? NomeProduto { get; set; }
    public string? Marca { get; set; }
    public int Quantidade { get; set; }
    public double Valor { get; set; }
}