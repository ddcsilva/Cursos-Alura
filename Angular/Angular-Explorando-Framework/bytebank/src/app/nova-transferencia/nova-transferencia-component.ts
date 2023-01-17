import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-nova-transferencia',
  templateUrl: './nova-transferencia-component.html',
  styleUrls: ['./nova-transferencia-component.scss'],
})
export class NovaTransferenciaComponent {
  @Output() aoTranferir = new EventEmitter<any>();
  valor: number = 0;
  destino: number = 0;

  trasferir() {
    console.log('Solicitada uma nova transferência');
    const valorParaEmitir = { valor: this.valor, destino: this.destino };
    this.aoTranferir.emit(valorParaEmitir);
  }
}
