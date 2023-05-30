using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{

    public class Circle
    {
        //public float radius;
        //public Circle(float rad) 
        //{ 
        //    this.radius = rad;
        //}
        //public float getArea()
        //{
        //    return (float)(3.14* this.radius * this.radius);
        //}
        //public float getArea(int r)
        //{
        //    r = 12;
        //    return (float)(3.14 * this.radius * r);
        //}
    }

    //class Cylinder : Circle
    //{
    //    float radius;
    //    int height;
    //    //public Cylinder(int hgt) : base(hgt)
    //    //{
    //    //    this.height = hgt;
    //    //}

    //    //public override float getArea()
    //    //{
    //    //    return (float)((2 * 3.14 * base.radius * this.height) + (2 * 3.14 * this.radius * this.radius));
    //    //}
    //}



    //abstract class Shape
    //{
    //    public abstract double area();
    //}
    //class Circle : Shape
    //{
    //    private double radius;
    //    public Circle(double r)
    //    {
    //        radius = r;
    //    }
    //    public override double area()
    //    {
    //        return (3.14 * radius * radius);
    //    }
    //}


    abstract class Clothing
    {
        abstract public int Sales();
        abstract public string[] Materials();
        abstract public string[] CommonWear();

    }

    class TrendSetting : Clothing
    {
        public override int Sales()
        {
            int sales = 260000;
            return sales;
        }
        public override string[] Materials()
        {
            string[] materials = { "Cotton", "Silk"};
            return materials;
        }

        public override string[] CommonWear()
        {
            string[] wearables = {"Tshirts", "Shirts", "Caps"};
            return wearables;
        }
    }

    class ClimateControl : Clothing
    {
        public override int Sales()
        {
            int sales = 1000000;
            return sales;
        }
        public override string[] Materials()
        {
            string[] materials = { "Cotton", "Silk", "Nylon", "Lyocell" };
            return materials;
        }

        public override string[] CommonWear()
        {
            string[] wearables = { "Tshirts", "Shirts", "Caps", "Hoodies", "Cotton Jackets" };
            return wearables;
        }
    }

    class Sports : Clothing
    {
        public override int Sales()
        {
            int sales = 160000;
            return sales;
        }
        public override string[] Materials()
        {
            string[] materials = { "Cotton", "Silk", "Hemp", "Ramie" };
            return materials;
        }

        public override string[] CommonWear()
        {
            string[] wearables = { "Tshirts", "Shirts", "Caps", "Jeans", "Cargo"};
            return wearables;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Cylinder c = new Cylinder(12);
            //Cylinder c = new Cylinder();
            ////Circle circle = new Circle();
            ////float value = c.getArea();
            //c.run();


            //Circle c = new Circle(5.0);
            //Console.WriteLine("Area of Circle = {0}", c.area());
            //Console.WriteLine("Value of Area of cylinder is {0}",value);

            TrendSetting ts = new TrendSetting();
             string[] mat = ts.Materials();
             string[] commWear  = ts.CommonWear();
             int sale = ts.Sales();
            Console.WriteLine("Material is: ");
            for (int i = 0; i < mat.Length; i++)
            {
                Console.WriteLine(mat[i]);
            }
            Console.WriteLine();
            Console.WriteLine("CommonWear is: ");
            for (int i = 0; i < commWear.Length; i++)
            {
                Console.WriteLine(commWear[i]);
            }
            Console.WriteLine();
            Console.WriteLine(sale);
            Console.WriteLine("---------------------");


            ClimateControl cc = new ClimateControl();
            string[] mat2 = cc.Materials();
            string[] commWear2 = cc.CommonWear();
            int sale2 = ts.Sales();
            Console.WriteLine("Material is: ");
            for (int i = 0; i < mat2.Length; i++)
            {
                Console.WriteLine(mat2[i]);
            }
            Console.WriteLine();
            Console.WriteLine("CommonWear is: ");
            for (int i = 0; i < commWear2.Length; i++)
            {
                Console.WriteLine(commWear2[i]);
            }
            Console.WriteLine();
            Console.WriteLine(sale2);
            Console.WriteLine("---------------------");


            Sports sport = new Sports();
            string[] mat3 = sport.Materials();
            string[] commWear3 = sport.CommonWear();
            int sale3 = sport.Sales();
            Console.WriteLine("Material is: ");
            for (int i = 0; i < mat3.Length; i++)
            {
                Console.WriteLine(mat3[i]);
            }
            Console.WriteLine();
            Console.WriteLine("CommonWear is: ");
            for (int i = 0; i < commWear3.Length; i++)
            {
                Console.WriteLine(commWear3[i]);
            }
            Console.WriteLine();
            Console.WriteLine(sale3);

            Console.ReadKey();
        }
    }
}
