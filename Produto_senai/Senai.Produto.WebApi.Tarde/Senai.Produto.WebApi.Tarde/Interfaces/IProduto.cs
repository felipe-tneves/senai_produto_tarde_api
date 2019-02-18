using Senai.Produto.WebApi.Tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Produto.WebApi.Tarde.Interfaces
{
    interface IProduto
    {
        List<ProdutoDomains> Listar();
        ProdutoDomains BuscarPorId(int id);
        void Cadastrar(ProdutoDomains produto);
    }
}
