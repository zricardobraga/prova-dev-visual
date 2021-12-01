export interface Pagamento {
    id?: number;
    nome: string;
    criadoEdm: Date;
    formaDePagamento?: Pagamento;

}

enum FormaDePagamento { Cartao, Boleto }