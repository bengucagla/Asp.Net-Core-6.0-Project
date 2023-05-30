using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentdal;

		public CommentManager(ICommentDal commentdal)
		{
			_commentdal = commentdal;
		}


		public void CommentAdd(Comment comment)
		{
			_commentdal.Insert(comment);

		}

		public List<Comment> GetCommentWithBlog()
		{
			return _commentdal.GetListWithBlog();
		}

		public List<Comment> GetList(int id)
		{
			return _commentdal.GetListAll(x => x.BlogID == id);
		}

	}
}
