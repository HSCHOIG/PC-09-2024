using Classes;

var account = new BankAccount("Choi", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// Testeo y excepcion de crear una cuenta con saldo negativo
try
{
    var invalidAccount = new BankAccount("invalido", -10);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("No sea codo, metale dinero");
    Console.WriteLine(e.ToString());
}

// Testeo y excepcion de retirar dinero mas del disponible en la cuenta
try
{
    account.MakeWithdrawal(1000, DateTime.Now, "No se puede sacar mas de lo que ya tiene, pida prestado dinero");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("No se puede sacar mas de lo que ya tiene, pida prestado dinero");
    Console.WriteLine(e.ToString());
}

// Testeo y excepcion de hacer una transferencia de 0
try 
{ 
    account.MakeDeposit(0, DateTime.Now, "No se puede"); 
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("NO SE PUEDE HACER ESTO");
    Console.WriteLine(e.ToString());
}

//Testeo y excepcion de hacer un deposito de 0
try 
{ 
    account.MakeWithdrawal(0, DateTime.Now, "No se puede"); 
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("NO SE PUEDE HACER ESTO TAMPOCO");
    Console.WriteLine(e.ToString());
}