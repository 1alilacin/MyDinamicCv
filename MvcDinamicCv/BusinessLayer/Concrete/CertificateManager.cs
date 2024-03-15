using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CertificateManager : ICertificateService
    {
        private readonly ICertificateDal _certificateDal;

        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public void TDelete(Certificate t)
        {
            _certificateDal.Delete(t);
        }

        public List<Certificate> TGetAll()
        {
            return _certificateDal.GetAll();
        }

        public Certificate TGetById(int id)
        {
            return _certificateDal.GetById(id);
        }

        public void TInsert(Certificate t)
        {
            _certificateDal.Insert(t);
        }

        public void TUpdate(Certificate t)
        {
            _certificateDal.Update(t);
        }
    }
}
