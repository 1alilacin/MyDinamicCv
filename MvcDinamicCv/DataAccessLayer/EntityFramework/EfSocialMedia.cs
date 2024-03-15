using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSocialMedia : GenericRepository<SocialMedia>, ISocialMedia
    {
        public EfSocialMedia(Context context) : base(context)
        {
        }
    }
}
