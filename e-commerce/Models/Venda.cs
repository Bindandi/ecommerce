using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models
{
    public class Venda
    {
        int _id;
        List<VendaItem> _itens = new List<VendaItem>();
        DateTime _dtVenda;
        decimal _total;
        Cliente _cliente;

    }
}
