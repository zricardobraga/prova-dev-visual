import { ItemVenda } from './../../../../models/item-venda';
import { Venda } from './../../../../models/venda';
import { Component, OnInit } from '@angular/core';
import { VendaService } from 'src/app/services/venda.service';

@Component({
  selector: 'app-listar-venda',
  templateUrl: './listar-venda.component.html',
  styleUrls: ['./listar-venda.component.css']
})
export class ListarVendaComponent implements OnInit {

  vendas: Venda[] = [];


  constructor(private service: VendaService) { }

  ngOnInit(): void {
    this.service.list().subscribe((vendas) => {
        this.vendas = vendas;
        console.log(this.vendas);
    });
  }
}
