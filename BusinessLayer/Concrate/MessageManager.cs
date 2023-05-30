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
	public class MessageManager:IMessageService
		
	{
		IMessageDal _messageDal;

		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}

		public List<Message> GetInboxListByWriter(string p)
		{
			return _messageDal.GetListAll(x => x.Receiver == p);
		}

		public List<Message> GetList()
		{
			return _messageDal.GetListAll();
		}

		
		public void TAdd(Message t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Message t)
		{
			throw new NotImplementedException();
		}

		public Message TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Message t)
		{
			throw new NotImplementedException();
		}

		
	}
}
