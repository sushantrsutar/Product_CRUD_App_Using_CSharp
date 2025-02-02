using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRUD OPRATION USING C# COLLECTIONS");
            Product product = new Product();
            ProductCRUD productCRUD = new ProductCRUD();
            List<Product> plist;
            int choice;
            try
            {
                do
                {
                    Console.WriteLine("\n----------------------------------\n");
                    Console.WriteLine("     Product Management : ");
                    Console.WriteLine("     1.Add Product ");
                    Console.WriteLine("     2.Update Product ");
                    Console.WriteLine("     3.Delete Product");
                    Console.WriteLine("     4.Show Products");
                    Console.WriteLine("     5.Search Product By Id");
                    Console.WriteLine("     6.Exit");
                    Console.WriteLine("\n----------------------------------");

                    
                    Console.Write("\n       Enter Choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {   //1.Add Product
                                product = new Product();
                                Console.WriteLine("Add Product Details Here");
                                Console.Write("Enter Product Id : ");
                                product.Id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Product Name : ");
                                product.Name = Console.ReadLine();
                                Console.Write("Enter Product Price : ");
                                product.Price = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Product Company : ");
                                product.Company = Console.ReadLine();
                                productCRUD.AddProduct(product);
                                Console.WriteLine("\nProduct Added...");
                                break;
                            }
                        case 2:
                            {
                                //2.Update Product
                                plist = productCRUD.ShowProductList();
                                if (plist.Count == 0)
                                {
                                    Console.WriteLine("Product List is Empty....Please Add Product.");
                                }
                                else
                                {
                                    //Console.WriteLine("Update Product ");
                                    Console.Write("Enter Product Id To update Product : ");
                                    int updId = Convert.ToInt32(Console.ReadLine());
                                    Product existingProduct = productCRUD.SearchById(updId);
                                    if (existingProduct != null)
                                    {
                                        Product updatedProduct = new Product { Id = updId };
                                        Console.Write("Enter Product Name : ");
                                        updatedProduct.Name = Console.ReadLine();
                                        Console.Write("Enter Product Price : ");
                                        updatedProduct.Price = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Company Name : ");
                                        updatedProduct.Company = Console.ReadLine();

                                        if (productCRUD.UpdateProduct(updatedProduct))
                                        {
                                            Console.WriteLine("\nProduct updated...");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nProduct Not updated..");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nProduct Not Found");
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                //3.Delete Product
                                plist = productCRUD.ShowProductList();
                                if (plist.Count == 0)
                                {
                                    Console.WriteLine("Product List is Empty....Please Add Product.");
                                }
                                else
                                {
                                    //Console.WriteLine("Delete Product ");
                                    Console.Write("Enter Id For Delete Product : ");
                                    int DeleteId = Convert.ToInt32(Console.ReadLine());
                                    if (productCRUD.DeleteProduct(DeleteId))
                                    {
                                        Console.WriteLine("\nProduct Deleted...");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nProduct Not Deleted....");
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                //4.Show Products
                                plist = productCRUD.ShowProductList();
                                if (plist.Count == 0)
                                {
                                    Console.WriteLine("\nProducts Not Present In List");

                                }
                                else
                                {
                                    Console.WriteLine("Product List :");
                                    Console.WriteLine("----------------------------------");
                                    foreach (Product p in plist)
                                    {
                                        Console.WriteLine(p);
                                    }
                                }

                                break;
                            }
                        case 5:
                            {
                                //5.Search Product By Id
                                plist = productCRUD.ShowProductList();
                                if (plist.Count == 0)
                                {
                                    Console.WriteLine("Product List is Empty....Please Add Product.");
                                }
                                else
                                {
                                    Console.Write("Enter Id To Search Product : ");
                                    int SearchId = Convert.ToInt32(Console.ReadLine());
                                    Product FoundProduct = productCRUD.SearchById(SearchId);
                                    if (FoundProduct != null)
                                    {
                                        Console.WriteLine(FoundProduct);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nProduct not Found");
                                    }
                                }
                                break;
                            }
                        case 6:
                            {
                                //6.Exit
                                Console.WriteLine("Good By..");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nEnter Valide Option ");
                                break;
                            }
                    }


                } while (choice != 6);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
