/*
 Permits to create a tree-like structure of objects
 One object contains multiple sub ojbects and so on
 the core part is the IItem class and its sub class
 You can add new concrete IItem as you want, and add it to the box
 Box class inherits from parent Interface IITem, IS-A , inheritance
 but Box class also HAS-A (keep reference) of IItem through private List<IItem> _items = new List<IItem>(); (IS COMPOSED)
 Composit is useful to represent the folder tree structure
 */


using Structural_Composite;

Box package = new Box();
Box b1 = new Box();
b1.Add(new Microphone());
Box b2 = new Box();
Box b3 = new Box();
b3.Add(new Mouse());
Box b4 = new Box();
b4.Add(new Keyboard());
//
b2.Add(b3);
b2.Add(b4);
//
package.Add(b1);
package.Add(b2);
//
Console.WriteLine("Total of the package is: " + package.GetPrice());

