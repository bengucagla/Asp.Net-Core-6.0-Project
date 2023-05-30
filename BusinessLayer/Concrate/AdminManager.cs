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
	public class AdminManager : IAdminService
		
	{
		IAdminDal _Admindal;

		public AdminManager(IAdminDal admindal)
		{
			_Admindal = admindal;
		}

		public List<Admin> GetList()
		{
			throw new NotImplementedException();
		}

		public void TAdd(Admin t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Admin t)
		{
			throw new NotImplementedException();
		}

		public Admin TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Admin t)
		{
			throw new NotImplementedException();
		}
	}
}
