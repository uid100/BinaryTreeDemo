using System;
using BinaryTree;

namespace BinaryTreeTest
{
    class Program
    {
        static void binarySortInt()
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);
            tree1.Insert(8);
            tree1.Insert(8);

            Console.WriteLine(tree1.WalkTree());
        }

        static void binarySortStrings()
        {
            Tree<string> tree2 = new Tree<string>("Hello");
            tree2.Insert("World");
            tree2.Insert("How");
            tree2.Insert("Are");
            tree2.Insert("You");
            tree2.Insert("Today");
            tree2.Insert("I");
            tree2.Insert("Hope");
            tree2.Insert("You");
            tree2.Insert("Are");
            tree2.Insert("Feeling");
            tree2.Insert("Well");
            tree2.Insert("!");

            Console.WriteLine(tree2.WalkTree());
        }

        static void binarySortStudents()
        {
            Tree<string> tree3 = new Tree<string>("Garrett");
            tree3.Insert("Darwin");
            tree3.Insert("Tyler");
            tree3.Insert("Bryan");
            tree3.Insert("Mako");
            tree3.Insert("David");
            tree3.Insert("Cody");
            tree3.Insert("Dennis");
            tree3.Insert("Alex");
            tree3.Insert("Aaron");

            Console.WriteLine(tree3.WalkTree());
        }

        static void Main(string[] args)
        {
            binarySortStudents();
            Console.WriteLine();
            binarySortStrings();
        }
    }
}
