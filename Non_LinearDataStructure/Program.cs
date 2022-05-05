using System;
using Non_LinearDataStructure;
public class Program
{
    public static void Main(String[] args)
    {
        BinarySearchTree<int> binarySearch=new BinarySearchTree<int>(70);
        binarySearch.Insert(56);
        binarySearch.Insert(30);
       // binarySearch.Insert(56);
        bool result = binarySearch.IfExists(70,binarySearch);
        binarySearch.Display();
    }
}