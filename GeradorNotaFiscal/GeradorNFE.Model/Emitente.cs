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
    
    public partial class Emitente
    {
        public int EmitenteId { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string NomeRazao { get; set; }
        public string NomeFantasia { get; set; }
        public string Fone { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public Nullable<int> NumeroRua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int CodigoCidade { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string IM { get; set; }
        public string CNAE { get; set; }
        public int CodigoPais { get; set; }
        public string Pais { get; set; }
    }
}
