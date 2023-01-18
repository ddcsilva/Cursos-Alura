namespace bytebank;

public class ContaCorrente
{
    public int numero_agencia;
    public string conta;
    public string titular;
    public double saldo;

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= this.saldo)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }
}
