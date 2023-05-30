using EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Comment comment);
		//void CategoryDelete(Category category);
		//void CategoryUpdate(Category category);
		List<Comment> GetList(int id);
		//Category GetByid(int id);
		List<Comment> GetCommentWithBlog();
	}
}
