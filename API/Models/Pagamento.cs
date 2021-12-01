using System;

namespace API.Models
{
    public class Pagamento
    {

        public int Id{ get; set;}
        //public int UserId{ get; set;}
        //public Usuario User { get; set;}
        public string Nome { get; set;}
        public FormaDePagamento FormaPgto { get; set;}
        public DateTime CriadoEm { get; set;}
        public Pagamento() => CriadoEm = DateTime.Now;
    }

    public enum FormaDePagamento
    {
        Cartao,
        Boleto
    }
}