import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TransferenciaService {
  private listaTransferencia: any[];

  constructor() {
    this.listaTransferencia = [];
  }

  get transferencias() {
    return this.listaTransferencia;
  }

  adicionar(transferencia: any) {
    this.adicionarRecursos(transferencia);
    this.listaTransferencia.push(transferencia);
  }

  private adicionarRecursos(transferencia: any) {
    transferencia.data = new Date();
  }
}
