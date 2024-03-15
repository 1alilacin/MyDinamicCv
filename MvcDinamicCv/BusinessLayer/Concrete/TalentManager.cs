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
    public class TalentManager : ITalentService
    {
        private readonly ITalentDal _talentDal;

        public TalentManager(ITalentDal talentDal)
        {
            _talentDal = talentDal;
        }

        public void TDelete(Talent t)
        {
            _talentDal.Delete(t);
        }

        public List<Talent> TGetAll()
        {
            return _talentDal.GetAll();
        }

        public Talent TGetById(int id)
        {
            return _talentDal.GetById(id);
        }

        public void TInsert(Talent t)
        {
            _talentDal.Insert(t);
        }

        public void TUpdate(Talent t)
        {
            _talentDal.Update(t);
        }
    }
}
