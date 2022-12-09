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
    public class ServicesManager : IServicesService
    {
        IServicesDal _servicesDal;
        public ServicesManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }
        public Services GetId(int id)
        {
            return _servicesDal.GetId(id);
        }

        public List<Services> GetList()
        {
            return _servicesDal.GetAll();
        }

        public void TAdd(Services t)
        {
            _servicesDal.Insert(t);
        }

        public void TDelete(Services t)
        {
            _servicesDal.Delete(t);
        }

        public void TUpdate(Services t)
        {
            _servicesDal.Update(t);
        }
    }
}
