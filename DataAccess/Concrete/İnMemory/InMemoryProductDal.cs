using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.İnMemory
{
    public class InMemoryProductDal : IProductDal

    {
        List<Product> _produtcts;
        public InMemoryProductDal()
        {
            _produtcts = new List<Product>{ 


                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1 },

            };
        }
        public void Add(Product product)
        {
            _produtcts.Add(product);

        }

        public void Delete(Product product)
            
        { 
            Product productToDelete = _produtcts.SingleOrDefault(p=>p.ProductId==product.ProductId);
            // foreach yap demek herbbirine takma isim yani p ver. herbir p için p=>p   gönderilen productun idsi eşit olanı al        
            _produtcts.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _produtcts;

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _produtcts.Where(p => p.CategoryId == categoryId).ToList();
            // where içerindeki koşula uyanları yeni bir liste olarak dönderir 
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ID  sine sahip olan listedeki ürünü bul
            Product productToUpdate = _produtcts.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
