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
    
    public partial class Transportador
    {
        public int TransportadorId { get; set; }
        public bool FretePorConta { get; set; }
        public long CNPJCPF { get; set; }
        public string InscricaoEstadual { get; set; }
        public string NomeRazao { get; set; }
        public string Endereco { get; set; }
        public int CodigoCidade { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public Nullable<decimal> ValorServico { get; set; }
        public Nullable<decimal> ValorBase { get; set; }
        public Nullable<decimal> Aliquota { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public string CFOP { get; set; }
        public Nullable<int> CodigoCidadePlaca { get; set; }
        public string Placa { get; set; }
        public string UFPlaca { get; set; }
        public string RNTC { get; set; }
    }
}