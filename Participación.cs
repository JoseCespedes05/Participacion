using System;	
public class Banco
{
	string NumeroCuenta;string opcion;string depositos;string retiros;
	int deposito1;int deposito2;int deposito3;
	int retiro1;int retiro2;int retiro3;
	int totalretiro;int totaldeposito;
	int cliente1=20000;int cliente2=10000;int cliente3=15000;
	
	public void Aclaraciones()
	{
		Console.WriteLine("Cuentas: 4512, 4513 y 4514. Deben de ser puestas en orden");
		Console.WriteLine("Saldrá el mismo cliente dos veces en la ejecución, en la primera deposita y en la segunda retira, lo hice de esta forma por falta de tiempo y porque no he practicado suficiente con este tema nuevo de las clases");

	}
	public void CuentaCliente1()
	{
		Console.WriteLine();
		Console.WriteLine("CLIENTE 1");
		Console.Write("Numero de cuenta del cliente: ");
        NumeroCuenta = Console.ReadLine();
	}
	public void CuentaCliente2()
	{
		Console.WriteLine();
		Console.WriteLine("CLIENTE 2");
		Console.Write("Numero de cuenta del cliente: ");
        NumeroCuenta = Console.ReadLine();
	}
	public void CuentaCliente3()
	{
		Console.WriteLine();
		Console.WriteLine("CLIENTE 3");
		Console.Write("Numero de cuenta del cliente: ");
        NumeroCuenta = Console.ReadLine();
	}
	public void ConfirmarCliente()
	{
		if(NumeroCuenta=="4512")
		{
			Console.Write("Qué desea realizar? depositar o retirar:");
			opcion=Console.ReadLine();
		}
		else if(NumeroCuenta=="4513")
		{
			Console.Write("Qué desea realizar? depositar o retirar: ");
			opcion=Console.ReadLine();
		}
		else if(NumeroCuenta=="4514")
		{
			Console.Write("Qué desea realizar? depositar o retirar:");
			opcion=Console.ReadLine();
		}
		else{Console.Write("No encontramos su cuenta");}
	}
	
	public void DepositoCliente1()
	{
		if(NumeroCuenta=="4512" && opcion=="depositar")
		{
			Console.Write("Monto a depositar: ");
			depositos=Console.ReadLine();
			deposito1=Convert.ToInt32(depositos);
			cliente1=cliente1+deposito1;
			totaldeposito=totaldeposito+deposito1;
		}
	}
	public void DepositoCliente2()
	{
		if(NumeroCuenta=="4513" && opcion=="depositar")
		{
			Console.Write("Monto a depositar: ");
			depositos=Console.ReadLine();
			deposito2=Convert.ToInt32(depositos);
			cliente2=cliente1+deposito1;
			totaldeposito=totaldeposito+deposito2;
		}
	}
	public void DepositoCliente3()
	{
		if(NumeroCuenta=="4514" && opcion=="depositar")
		{
			Console.Write("Monto a depositar: ");
			depositos=Console.ReadLine();
			deposito1=Convert.ToInt32(depositos);
			cliente3=cliente3+deposito3;
			totaldeposito=totaldeposito+deposito3;
		}
	}
	
	
	public void retiroCliente1()
	{
		if(NumeroCuenta=="4512" && opcion=="retirar")
		{
			Console.Write("Monto a retirar: ");
			retiros=Console.ReadLine();
			retiro1=Convert.ToInt32(retiros);
			cliente1=cliente1-retiro1;
			totalretiro=totalretiro+retiro1;
		}
	}
	public void retiroCliente2()
	{
		if(NumeroCuenta=="4513" && opcion=="retirar")
		{
			Console.Write("Monto a retirar: ");
			retiros=Console.ReadLine();
			retiro2=Convert.ToInt32(retiros);
			cliente2=cliente2-retiro2;
			totalretiro=totalretiro+retiro2;
		}
	}
	public void retiroCliente3()
	{
		if(NumeroCuenta=="4514" && opcion=="retirar")
		{
			Console.Write("Monto a retirar: ");
			retiros=Console.ReadLine();
			retiro1=Convert.ToInt32(retiros);
			cliente3=cliente3-retiro3;
			totalretiro=totalretiro+retiro3;
		}
	}
	
	
	public void TotalDepositos(){
		Console.WriteLine("Total de dinero depositado:"+totaldeposito);
	}
	public void TotalRetiros(){
		Console.WriteLine("Total de dinero retirado:"+totalretiro);
	}
	static public void Main(string[] args){
		Banco banco1= new Banco();
		banco1.CuentaCliente1();
		banco1.ConfirmarCliente();
		banco1.DepositoCliente1();
		
		banco1.CuentaCliente1();
		banco1.ConfirmarCliente();
		banco1.retiroCliente1();
		
		banco1.CuentaCliente2();
		banco1.ConfirmarCliente();
		banco1.DepositoCliente2();
		
		banco1.CuentaCliente2();
		banco1.ConfirmarCliente();
		banco1.retiroCliente2();
		
		banco1.CuentaCliente3();
		banco1.ConfirmarCliente();
		banco1.DepositoCliente3();
		
		banco1.CuentaCliente3();
		banco1.ConfirmarCliente();
		banco1.retiroCliente3();
		banco1.TotalDepositos();
		banco1.TotalRetiros();
		}
}