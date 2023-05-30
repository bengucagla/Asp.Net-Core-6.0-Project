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
	public class ContactManager : IContactService
	{
		IContactDal _contactdal;

		public ContactManager(IContactDal contactdal)
		{
			_contactdal = contactdal;
		}

		public void ContactAdd(Contact contact)
		{
			_contactdal.Insert(contact);
		}
	}
}
