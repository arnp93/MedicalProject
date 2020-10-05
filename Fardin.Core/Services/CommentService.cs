using Fardin.Core.DTO;
using Fardin.Core.Security;
using Fardin.Core.Services.IServices;
using Fardin.DataLayer.Context;
using Fardin.DataLayer.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Fardin.Core.Services
{
    public class CommentService : ICommentService
    {
        private DatabaseContext db;
        string language = CultureInfo.CurrentCulture.Name;
        public CommentService(DatabaseContext db)
        {
            this.db = db;
        }

        #region Comment Section
        public bool AddComment(SubmitCommentViewModel comment)
        {
            if (comment.Email.Length > 9 && comment.FullName.Length > 3)
            {
                Comment newComment = new Comment()
                {
                    Text = comment.Text.SanitizeText(),
                    FullName = comment.FullName.SanitizeText(),
                    PhoneNumber = comment.PhoneNumber.SanitizeText(),
                    Email = comment.Email.SanitizeText(),
                    Date = DateTime.Now,
                    isPublic = false,
                    isDelete = false
                };
                db.comments.Add(newComment);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;

            }
        }



        public void cancelConfirm(int id)
        {
            Comment comment = db.comments.SingleOrDefault(c => c.CommentId == id);
            comment.isPublic = false;
            db.Update(comment);
            db.SaveChanges();
        }

        public CommentWithPagingViewModel commentsPaging(int curretPage = 0)
        {
            //TODO: Paging Comments
            int take = 10;
            CommentWithPagingViewModel CommentWithPaging = new CommentWithPagingViewModel();
            List<CommentsViewModel> CommentsModel = db.comments.Where(c=> c.LanguageTitle == language).Select(c => new CommentsViewModel
            {
                Text = c.Text,
                FullName = c.FullName,
                isPublic = c.isPublic,
                Date = c.Date
            }).Skip(curretPage * take).Take(take).OrderByDescending(c=>c.Date).ToList();
            CommentWithPaging.comments = CommentsModel;
            CommentWithPaging.pageCount = db.comments.Count() / take;
            CommentWithPaging.currentPage = curretPage;
            return CommentWithPaging;
        }

        public void confirmComment(int id,string lang)
        {
            Comment comment = db.comments.SingleOrDefault(c => c.CommentId == id);
            comment.isPublic = true;
            comment.LanguageTitle = lang;
            db.Update(comment);
            db.SaveChanges();
        }


        public void deleteComment(int id)
        {
            Comment comment = db.comments.SingleOrDefault(c => c.CommentId == id);
            comment.isDelete = true;
            comment.isPublic = false;
            db.Update(comment);
            db.SaveChanges();
        }

        public List<CommentsViewModel> GetComments()
        {

            return db.comments.Select(c => new CommentsViewModel
            {
                Text = c.Text,
                FullName = c.FullName,
                isPublic = c.isPublic
            }).ToList();

        }

        public ManageCommentsViewModel getCommentsForManage(int currentPage = 0)
        {
            ManageCommentsViewModel mcvm = new ManageCommentsViewModel();
            int take = 20;

            mcvm.comments = db.comments.Where(c => !c.isDelete).Skip(currentPage * take).Take(take).OrderByDescending(c=>c.CommentId).ToList();
            mcvm.pageCount = db.comments.Count() / take;
            mcvm.currentPage = currentPage;

            return mcvm;
        }

        #endregion

        #region Contact Us Section

        public void addContactUsContent(ContactUs contact)
        {
            if (contact != null)
            {
                contact.Date = DateTime.Now;
                db.contacts.Add(contact);
                db.SaveChanges();
            }
        }

        public List<ContactUs> contacts()
        {
            return db.contacts.OrderByDescending(c => c.Date).ToList();
        }

        public void DeleteContentUsMessage(int id)
        {
            ContactUs contact = db.contacts.Find(id);
            db.contacts.Remove(contact);
            db.SaveChanges();
        }
        #endregion
    }
}
