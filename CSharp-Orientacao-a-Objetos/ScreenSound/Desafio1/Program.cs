using Desafio1;

var conta = new ContaBancaria();
conta.numeroIndicador = 1;
conta.titular = "Maria";
conta.saldo = 1000;
conta.senha = "1234";

conta.ExibirInformacoes();

var carro = new Carro();
carro.marca = "Fiat";
carro.modelo = "Uno";
carro.cor = "Vermelho";
carro.ano = 2020;
carro.velocidade = 0;

carro.ExibirInformacoes();

carro.Acelerar();
carro.ExibirInformacoes();

carro.Frear();
carro.ExibirInformacoes();

carro.Buzinar();