using SimpleTreeNode;
using System;

class Examples
{
    static void Main()
    {
        TreeNode<int> numberTree = new TreeNode<int>(7,
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
        Console.WriteLine("Tree of numbers:");
        Console.WriteLine(numberTree);

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
        Console.WriteLine();
        Console.WriteLine("Hierarchy of people:");
        Console.WriteLine(peopleTree);
    }
}
