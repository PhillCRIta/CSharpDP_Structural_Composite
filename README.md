### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Composite pattern
 Composite pattern permits to create a **tree-like structure** of objects. \
 One object contains multiple sub ojbects and so on. \
 In our case the core part is the IItem class and its sub class. \
 You can add new concrete IItem as you want, and add it to the box. \
 Box class inherits from parent Interface IITem, **IS-A** (EXTEND), inheritance; but Box class also **HAS-A** (keep reference) of IItem through private List<IItem> _items = new List<IItem>(); (IS COMPOSED) \
 Composit is useful to represent the folder tree structure.