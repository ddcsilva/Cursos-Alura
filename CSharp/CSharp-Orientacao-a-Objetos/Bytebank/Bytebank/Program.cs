using bytebank;

ContaCorrente contaDoDanilo = new ContaCorrente();
contaDoDanilo.titular = "Danilo Silva";
contaDoDanilo.numero_agencia = 15;
contaDoDanilo.conta = "1010-X";
contaDoDanilo.saldo = 100;

Console.WriteLine("Saldo da conta do Danilo = " + contaDoDanilo.saldo);