import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CarrinhoComponent } from "./components/views/home/carrinho/carrinho.component";
import { FinalizarVendaComponent } from "./components/views/home/finalizar-venda/finalizar-venda.component";
import { IndexComponent } from "./components/views/home/index/index.component";
import { ListarVendaComponent } from "./components/views/home/listar-venda/listar-venda.component";
import { CadastrarProdutoComponent } from "./components/views/produto/cadastrar-produto/cadastrar-produto.component";
import { ListarProdutoComponent } from "./components/views/produto/listar-produto/listar-produto.component";

const routes: Routes = [
    {
        path: "",
        component: IndexComponent,
    },
    {
        path: "home/carrinho",
        component: CarrinhoComponent,
    },
    {
        path: "produto/listar",
        component: ListarProdutoComponent,
    },
    {
        path: "produto/cadastrar",
        component: CadastrarProdutoComponent,
    },

    {
        path: "home/finalizar-venda",
        component: FinalizarVendaComponent,
    },

    {
        path: "home/listar-venda",
        component: ListarVendaComponent,
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
