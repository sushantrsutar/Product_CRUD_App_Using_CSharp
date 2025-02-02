using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCrud
{
    public class ProductCRUD
    {
        private List<Product> productslist;

        public ProductCRUD() { 
            productslist = new List<Product>();
        }

        public void AddProduct(Product product) {
            productslist.Add(product);
        }
        public List<Product> ShowProductList() {
            return productslist;
        }
        public Product SearchById(int id) {
            foreach (Product product in productslist) {
                if (product.Id == id) {
                    return product;
                }
            }
            return null;
        }
        public bool DeleteProduct(int id) {
            for (int i = 0; i < productslist.Count; i++) {
                if (productslist[i].Id == id) { 
                    productslist.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool UpdateProduct(Product product)
        {
            for (int i = 0; i < productslist.Count; i++)
            {
                if (productslist[i].Id == product.Id) {
                    productslist[i].Name= product.Name;
                    productslist[i].Price= product.Price;
                    productslist[i].Company= product.Company;
                    return true;
                }    
            }
            return false;
        }

    }
}
