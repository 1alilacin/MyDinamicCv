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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMedia _socialMedia;

        public SocialMediaManager(ISocialMedia socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void TDelete(SocialMedia t)
        {
            _socialMedia.Delete(t);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMedia.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMedia.GetById(id);
        }

        public void TInsert(SocialMedia t)
        {
            _socialMedia.Insert(t);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMedia.Update(t);
        }
    }
}
