namespace CompositeDesignPattern;

public class Client
{
    public void ClientCode(Component leaf) =>
        Console.WriteLine($"Result: {leaf.Operation()}\n");

    public void ClientCode(
        Component component1, 
        Component component2)
    {
        if (component1.IsComposite())
            component1.Add(component2);

        Console.WriteLine($"Result: {component1.Operation()}");
    }
}
