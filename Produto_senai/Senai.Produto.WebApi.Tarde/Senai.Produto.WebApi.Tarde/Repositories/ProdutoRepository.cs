using Senai.Produto.WebApi.Tarde.Domains;
using Senai.Produto.WebApi.Tarde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Produto.WebApi.Tarde.Repositories
{
    public class ProdutoRepository : IProduto
    {
        public ProdutoDomains BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ProdutoDomains produto)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoDomains> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
