using Desafio2;

var conta = new ContaBancaria();
conta.NumeroIndicador = 1;
conta.Titular = "Maria";
conta.Saldo = 1000;
conta.Senha = "1234";

conta.ExibirInformacoes();

var carro = new Carro();
carro.Fabricante = "Fiat";
carro.Modelo = "Uno";
carro.Cor = "Vermelho";
carro.Ano = 2024;
carro.Velocidade = 0;

carro.ExibirInformacoes();

carro.Acelerar();
carro.ExibirInformacoes();

carro.Frear();
carro.ExibirInformacoes();

carro.Buzinar();