import { Venda } from './../models/venda';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class VendaService {
  private baseUrl = "http://localhost:5000/api/venda";


  constructor(private http: HttpClient) { }

  finalizar(cliente: string, carrinhoId: string, pagamentoId: number): Observable<Venda> {
    let url = `${this.baseUrl}/create/${cliente}/${carrinhoId}/${pagamentoId}`;
    return this.http.get<Venda>(url);
  }

  list(): Observable<Venda[]> {
      return this.http.get<Venda[]>(`${this.baseUrl}/list`);
  }
}
