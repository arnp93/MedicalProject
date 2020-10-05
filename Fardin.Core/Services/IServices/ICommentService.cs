using Fardin.Core.DTO;
using Fardin.DataLayer.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.Services.IServices
{
    public interface ICommentService
    {
        List<CommentsViewModel> GetComments();
        bool AddComment(SubmitCommentViewModel comment);

        CommentWithPagingViewModel commentsPaging(int curretPage = 0);

        ManageCommentsViewModel getCommentsForManage(int currentPage = 0);

        void deleteComment(int id);
        void confirmComment(int id, string lang);
        void cancelConfirm(int id);

        void addContactUsContent(ContactUs contact);
        List<ContactUs> contacts();
        void DeleteContentUsMessage(int id);
    }
}
