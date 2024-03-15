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
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperience _experience;

        public ExperienceManager(IExperience experience)
        {
            _experience = experience;
        }

        public void TDelete(Experience t)
        {
            _experience.Delete(t);
        }

        public List<Experience> TGetAll()
        {
            return _experience.GetAll();
        }

        public Experience TGetById(int id)
        {
            return _experience.GetById(id);
        }

        public void TInsert(Experience t)
        {
            _experience.Insert(t);
        }

        public void TUpdate(Experience t)
        {
           _experience.Update(t);
        }
    }
}
