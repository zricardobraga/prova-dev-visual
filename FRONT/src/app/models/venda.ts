import { ItemVenda } from "./item-venda";

export interface Venda {
    vendaId?: number;
    cliente?: String;
    idPagamento?: number;
    itens?: ItemVenda[];
    criadoEm?: Date;
}