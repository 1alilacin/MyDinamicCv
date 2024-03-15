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
    public class HobbyManager : IHobbyService
    {
        private readonly IHobbyDal _hobbyDal;

        public HobbyManager(IHobbyDal hobbyDal)
        {
            _hobbyDal = hobbyDal;
        }

        public void TDelete(Hobby t)
        {
            _hobbyDal.Delete(t);
        }

        public List<Hobby> TGetAll()
        {
            return _hobbyDal.GetAll();
        }

        public Hobby TGetById(int id)
        {
            return _hobbyDal.GetById(id);
        }

        public void TInsert(Hobby t)
        {
            _hobbyDal.Insert(t);
        }

        public void TUpdate(Hobby t)
        {
            _hobbyDal.Update(t);
        }
    }
}
