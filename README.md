# SimpleTreeNode
Very simple `TreeNode<T>` class for .NET.

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
