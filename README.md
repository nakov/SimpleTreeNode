# SimpleTreeNode
Very simple `TreeNode<T>` class for .NET, used for educational purposes.

## Usage Example

```cs
using SimpleTreeNode;
using System;

class Example
{
    static void Main()
    {
        TreeNode<int> tree = new TreeNode<int>(7,
            new TreeNode<int>(19,
                new TreeNode<int>(1),
                new TreeNode<int>(12),
                new TreeNode<int>(31)
            ),
            new TreeNode<int>(21),
            new TreeNode<int>(14,
                new TreeNode<int>(23),
                new TreeNode<int>(6)
            )
        );
        Console.WriteLine(tree);
    }
}
```

Output:
```
7
  19
    1
    12
    31
  21
  14
    23
    6
```

## Another Example

```cs
TreeNode<string> peopleTree = 
    new TreeNode<string>("The big boss",
        new TreeNode<string>("Steve",
            new TreeNode<string>("Maria"),
            new TreeNode<string>("Peter",
                new TreeNode<string>("Teodora")
            ),
            new TreeNode<string>("Nick")
        ),
        new TreeNode<string>("Diana",
            new TreeNode<string>("Frank"),
            new TreeNode<string>("Kim")
        ),
        new TreeNode<string>("Nia",
            new TreeNode<string>("Ivan"),
            new TreeNode<string>("Prakash")
        )
);
Console.WriteLine(peopleTree);
```

Output:
```
The big boss
  Steve
    Maria
    Peter
      Teodora
    Nick
  Diana
    Frank
    Kim
  Nia
    Ivan
    Prakash
```
