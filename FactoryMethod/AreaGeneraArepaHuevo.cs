 
class AreaGeneraArepaHuevo : Fabrica
{
    //Sobreescribe el producto generico q tiene la fabrica con el producto especifico que se peticiono 
    public override IArepa FactoryMethod() => new ArepaHuevo();
}