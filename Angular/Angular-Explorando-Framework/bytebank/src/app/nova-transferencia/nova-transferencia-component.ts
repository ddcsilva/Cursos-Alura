import { Transferencia } from './../models/transferencia-model';
import { TransferenciaService } from './../services/transferencia.service';
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

  constructor(private service: TransferenciaService) {}

  transferir() {
    console.log('Solicitada uma nova transferência');
    const valorParaEmitir: Transferencia = {
      valor: this.valor,
      destino: this.destino,
    };

    this.service.adicionar(valorParaEmitir).subscribe(
      (resultado) => {
        console.log(resultado);
        this.limparCampos();
      },
      (error) => console.error(error)
    );
  }

  limparCampos() {
    this.valor = 0;
    this.destino = 0;
  }
}
