using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HassanFoods
{
    class IOManager
    {
        private static string name;
        private static int price;
        private static List<Product> products = new List<Product>();
        //Add New file
        public static void MakeFile(string Path)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine("hello world");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry" + ex);
            }
           
        }
        //Add username
        public static bool MakeFile(string Path, string Name, string Pass)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine(Name);
                    sw.WriteLine(Pass);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry" + ex);
            }
            return false;
        }
        //Add items in all-files
        public static bool MakeFile(string Path, string Name, int Price)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(Path))
                {
                    //sw.WriteLine();
                    sw.WriteLine(Name);
                    sw.WriteLine(Price);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry" + ex);
            }
            return false;
        }
        //Update Items in all file
        public static bool Update(string Path, string Name, int Price)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {

                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        products.Add(new Product(name, price));
                    }
                }

                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }

                if (!File.Exists(Path))
                {
                    File.CreateText(Path);
                    using (StreamWriter sw = new StreamWriter(Path))
                    {
                        foreach (Product items in products)
                        {
                            if(items.Name == Name)
                            {
                                items.Price = Price;
                            }
                            sw.WriteLine(items.Name);
                            sw.WriteLine(items.Price);
                        }
                    }
                    return true;
                }


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
            return false;
        }
        
        //Read Burgers file
        public static void ReadData(string Path, List<Burgers> burgers)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        burgers.Add(new Burgers(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }

        }
        //Read Desi Burgers file
        public static void ReadData(string Path, List<DesiBurgers> desiBurgers)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        desiBurgers.Add(new DesiBurgers(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }

        }
        //Read Drink file
        public static void ReadData(string Path, List<Drinks> drinks)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        drinks.Add(new Drinks(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Readd Fries file
        public static void ReadData(string Path, List<Fries> fries)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        fries.Add(new Fries(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }

        }
        //Read Rolls file
        public static void ReadData(string Path, List<Rolls> rolls)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        rolls.Add(new Rolls(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Read Broast file
        public static void ReadData(string Path, List<Broast> broasts)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        broasts.Add(new Broast(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Read Chatpata file
        public static void ReadData(string Path, List<Chatpata> chatpatas)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        chatpatas.Add(new Chatpata(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Read Icecream file
        public static void ReadData(string Path, List<IceCream> iceCreams)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        iceCreams.Add(new IceCream(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Read Sandwiches file
        public static void ReadData(string Path, List<Sandwiches> sandwiches)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        sandwiches.Add(new Sandwiches(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Read Others file
        public static void ReadData(string Path, List<Others> others)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while ((name = sr.ReadLine()) != null && (price = int.Parse(sr.ReadLine())) != 0)
                    {
                        others.Add(new Others(name, price));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }
        }
        //Read Username and password file
        public static void ReadData(List<Users> users)
        {
            try
            {
                string na, pass;
                using (StreamReader sr = new StreamReader("03120012425.txt"))
                {
                    while ((na = sr.ReadLine()) != null && (pass = (sr.ReadLine())) !=null)
                    {
                        users.Add(new Users(na, pass));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry!" + ex);
            }

        }
    }
}

