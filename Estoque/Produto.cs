﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class Produto
    {
        //Declaração de variavéis
        private string _nome;
        private double _preco;
        private int _quantidade;
        
        
        //Construtor
        public Produto()
        {
        }
        //Construtor personalizado
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + “, $ ”
            +_preco.ToString(“F2”, CultureInfo.InvariantCulture);
            + “, ”
            + “, quantidade ”
            + “ unidades, Total: $ ”
            +ValorTotalEmEstoque().ToString(“F2”, CultureInfo.InvarianteCulture);
        }
    }   
}
