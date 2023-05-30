using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class GClass<T, K>
    {
        public T u;
        public K v;
        public GClass(T u, K v)
        {
            this.u = u;
            this.v = v;

            Console.WriteLine(u + " " +v);
        }

        public void add(T u, K v)
        {
            //dynamic a = u;
            //dynamic b = v;

            int a = Convert.ToInt32(u);
            int b = Convert.ToInt32(v);


            //Console.WriteLine(this.u);
            //Console.WriteLine(this.v);
            Console.WriteLine("Sum is {0}",(a + b));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 10;
            //GClass<int, int> obj = new GClass<int, int>(a, b);
            //obj.add(a, b);

            FileStream fs = new FileStream("C:\\Users\\user\\Desktop\\Satya.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Satyaprakash Pandey works as Software Engineer in Neosoft Pvt Ltd.");
            //sw.Close();
            fs.Close();
            FileStream file = new FileStream("C:\\Users\\user\\Desktop\\Satya.txt", FileMode.OpenOrCreate);
            StreamReader stwriter = new StreamReader(file);
            string data = stwriter.ReadLine();
            Console.WriteLine("Data written in Satya.txt is: ");
            Console.WriteLine(data);

            FileInfo fi = new FileInfo("C:\\Users\\user\\Desktop\\Satya.txt");
            DateTime dt = fi.CreationTime;
            Console.WriteLine("File creation time is : " + fi.ToString());
            Console.WriteLine("Extension of file is : " + fi.Extension);
            Console.WriteLine("Size of file is : " + fi.Length.ToString());
            Console.WriteLine("File path of file is: " + fi.DirectoryName);
            Console.WriteLine("File exists : " + fi.Exists);
            Console.WriteLine("File access time : " + fi.LastAccessTime);
            Console.WriteLine(" Full Name of file is : \"" + fi.FullName + "\"");
            stwriter.Close();
            file.Close();

            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add("Aakash");
            //array.Add(3);
            //array.Add("Abhishek");
            //array.Add(5);
            //array.Add("Swapnil");
            //array.Add(7);
            //array.Add("Gulshan");

            //foreach(var i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList menu = new ArrayList();
            //string name;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Enter your name: ");
            //    name = Console.ReadLine();
            //    menu.Add(name);
            //    Console.WriteLine("Want to add Another name: ");
            //    string response = Console.ReadLine();
            //    response = response.ToLower();

            //    //if (response == "y")
            //    //{
            //    //    Console.WriteLine("Enter your name: ");
            //    //    name = Console.ReadLine();
            //    //    menu.Add(name);
            //    //}
            //    if (response == "n")
            //    {
            //        break;
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine("Please Select one option");
            //    Console.WriteLine("1. Remove");
            //    Console.WriteLine("2. Show all");
            //    Console.WriteLine("3. Sort");
            //    Console.WriteLine("4. Search");
            //    Console.WriteLine("5. Reverse");
            //    Console.WriteLine("6. Exit");
            //    int resp = Convert.ToInt32(Console.ReadLine());
            //    if (resp == 1)
            //    {
            //        Console.WriteLine("Enter your name: ");
            //        name = Console.ReadLine();
            //        menu.Remove(name);
            //        Console.WriteLine("Removed successfully");
            //    }
            //    else if (resp == 2)
            //    {
            //        foreach (string item in menu)
            //        {
            //            Console.WriteLine("Patients are:  ");
            //            Console.WriteLine(item);
            //        }
            //    }

            //    else if (resp == 3)
            //    {
            //        menu.Sort();
            //        foreach (string element in menu)
            //        {
            //            Console.WriteLine(element);
            //        }
            //    }

            //    else if (resp == 4)
            //    {
            //        Console.WriteLine("Enter your name: ");
            //        name = Console.ReadLine();
            //        Console.WriteLine(menu.Contains(name));
            //    }

            //    else if (resp == 5)
            //    {
            //        menu.Reverse();
            //        foreach (string element in menu)
            //        {
            //            Console.WriteLine(element);
            //        }
            //    }

            //    else if (resp == 6)
            //    {
            //        break;
            //    }
            //}
            Console.ReadKey();

        }
    }
}
