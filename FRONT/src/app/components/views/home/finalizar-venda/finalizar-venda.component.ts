import { Router } from '@angular/router';
import { ItemService } from './../../../../services/item.service';
import { Pagamento } from './../../../../models/pagamento';
import { Component, OnInit } from '@angular/core';
import { PagamentoService } from 'src/app/services/pagamento.service';
import { VendaService } from 'src/app/services/venda.service';

@Component({
  selector: 'app-finalizar-venda',
  templateUrl: './finalizar-venda.component.html',
  styleUrls: ['./finalizar-venda.component.css']
})
export class FinalizarVendaComponent implements OnInit {

    carrinhoId!: string;
    cliente!: string;
    formaDePagamento!: Pagamento[];
    pagamentoId!: number;

    constructor(private service: ItemService,
    private router: Router,
    private servicePagamento: PagamentoService,
    private serviceVenda: VendaService) { }


  ngOnInit(): void {
    let carrinhoId = localStorage.getItem('carrinhoId')! || "";
    this.carrinhoId = carrinhoId;
    this.servicePagamento.list().subscribe(p => {
        this.formaDePagamento = p;
    });
  }

  finalizar(): void{
    this.serviceVenda.finalizar(this.cliente, this.carrinhoId, this.pagamentoId).subscribe((p) => {
        console.log(p);
        this.router.navigate(["home/listar-venda"]);
    });
}

}
