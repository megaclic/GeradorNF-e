//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeradorNFE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        public int ProdutoId { get; set; }
        public int CFOP { get; set; }
        public string EAN { get; set; }
        public long NCM { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
