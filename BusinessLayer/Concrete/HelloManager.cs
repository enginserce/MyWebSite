using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HelloManager : IHelloService
    {
        IHelloDal _helloDal;
        public HelloManager(IHelloDal helloDal)
        {
            _helloDal = helloDal;
        }

        public Hello GetId(int id)
        {
            return _helloDal.GetId(id);
        }

        public List<Hello> GetList()
        {
            return _helloDal.GetAll();
        }

        public void TAdd(Hello t)
        {
            _helloDal.Insert(t);
        }

        public void TDelete(Hello t)
        {
            _helloDal.Delete(t);
        }

        public void TUpdate(Hello t)
        {
            _helloDal.Update(t);
        }
    }
}
