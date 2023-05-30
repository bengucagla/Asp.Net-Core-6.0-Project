using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class UserManager : IUserService
	{
		IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public List<AppUser> GetList()
		{
			throw new NotImplementedException();
		}

		public void TAdd(AppUser t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(AppUser t)
		{
			throw new NotImplementedException();
		}

		public AppUser TGetById(int id)
		{
			return _userDal.GetByID(id);	
		}

		public void TUpdate(AppUser t)
		{
			_userDal.Update(t);
		}
	}
}
