abstract class Fabrica
{
    public abstract IArepa FactoryMethod();

    //La fabrica genera el proceso base para resolver el pedido pero no genera el producto esto lo resuelve la clase concreta que luego es retornado por la fabrica
    public string ResuelveElPedido()
    {
        // LLama el metodo del producto(el q la subclase sobreescribe) para generarlo
        var product = FactoryMethod();
        // Resuelve el proceso y regresa el pedido solucionado
        var result = $"Fabrica: Genera el proceso para solucionar el pedido mas no lo realiza es con la instancia de la subclase que se soluciona  el pedido asi se retorna el producto:  {product.Generar()}";

        return result;
    }
}

