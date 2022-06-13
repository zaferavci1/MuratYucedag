using BusinessLayer.Abstract;
using DataAccesslayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //generic yapıdan metotlar geldi**
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetById(int Id)
        {
            return _productDal.GetById(Id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
            //if (t.Name.Length >= 5 && t.Price >= 5 && t.Name != null) { 
            //    _productDal.Insert(t);
            //}
            //else
            //{
            //    //fluent validation**
            //    //hata mesajlari
            //}
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
