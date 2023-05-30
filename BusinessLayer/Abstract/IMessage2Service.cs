using EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMessage2Service : IGenericService<Message2>
	{
		List<Message2> GetInboxListByWriter(int id);
		//List<Message2> GetInboxListByWriterName(string name);
		List<Message2> GetSendBoxListByWriter(int id);
	}
}
