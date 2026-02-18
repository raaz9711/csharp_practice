using System.Collections.Generic;
using System;
using System.Numerics;
using System.Runtime.ExceptionServices;
namespace  MyApp
{

    public static class GenericMath {
       public static T Add<T>(T left, T right) where T : INumber<T>
        {
            return left + right;
        }

        //int result = Add(5, 10); // Works with integers
        //double resultDouble = Add(5.5, 10.2); // Works with doubles
    }
    public class Product : IComparable<Product>
    {
        public string Name {get;set;}
        public decimal Price {get;set;}

        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Name : {Name} , Price {Price}";
        }
        
    }

    public class ProductComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    public static class Util
    {
        public static T GetFirstItem<T>(List<T> items)
        {
            return items[0];
        }
    }
    public class Box<T>
    {
        public required T Item {get;set;} 
        public void AddItem(T item)
        {
            Item = item;
        }


    }
}