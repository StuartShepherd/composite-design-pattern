using CompositeDesignPattern;

Console.WriteLine("Composite Design Pattern");
Console.WriteLine("Composite is a structural design pattern that allows composing objects into a tree-like structure and work with the it as if it was a singular object.");
Console.WriteLine();

var client = new Client();

Console.WriteLine("Client: ");
client.ClientCode(new Leaf());

var tree = new Composite();
var branch1 = new Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());

var branch2 = new Composite();
branch2.Add(new Leaf());

tree.Add(branch1);
tree.Add(branch2);

Console.WriteLine("Client:");
client.ClientCode(tree);

Console.WriteLine("Client:");
client.ClientCode(tree, new Leaf());
