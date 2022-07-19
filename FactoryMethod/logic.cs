class Client
{
    //los Clientes realizan su pedido 
    public void Main()
    {
        Console.WriteLine("Cliente pide una arepa con huevo");
        RecepcionPeticionCliente(new AreaGeneraArepaHuevo());

        Console.WriteLine("");

        Console.WriteLine("Cliente pide una arepa con queso");
        RecepcionPeticionCliente(new AreaGeneraArepaQueso());
    }

    //Se recive el pedido y se le pide a la fabrica que lo resuelva sin importar el proceso interno que realice sabe  que regresar x cada perido
    public void RecepcionPeticionCliente(Fabrica Fabrica)
    { 
        Console.WriteLine("Cajero: envia el pedido a la fabrica sin saber como lo realiza la misma.\n" + Fabrica.ResuelveElPedido()); 
    }
}


