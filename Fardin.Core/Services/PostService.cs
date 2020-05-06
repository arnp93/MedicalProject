using Fardin.Core.Services.IServices;
using Fardin.DataLayer.Context;
using Fardin.DataLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fardin.Core.Services
{
    public class PostService : IPostService
    {
        private DatabaseContext _db;
        public PostService(DatabaseContext context)
        {
            _db = context;
        }
        public bool addPost(string postTitle, string username, int SectionId, string PostText, IFormFile PostImg)
        {
            AdminPanel admin = _db.admins.Where(a => a.Username == username).First();
            Post post = new Post()
            {
                AdminPanelId = admin.AdminPanelId,
                SectionId = SectionId,
                PostText = PostText,
                Title = postTitle
            };
            if (PostImg != null)
            {
                post.PostImg = Guid.NewGuid() + Path.GetExtension(PostImg.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/image", post.PostImg);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    PostImg.CopyTo(stream);
                }
            }


            _db.Add(post);
            _db.SaveChanges();
            return true;
        }

        public void AddPostDetails(int PostId, string postDetailsText, IFormFile image)
        {
            PostDetail detail = new PostDetail()
            {
                PostId = PostId,
                TextResumen = postDetailsText
            };

            if (image != null)
            {
                detail.ImageName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/PostDetailsImage", detail.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }

            _db.Add(detail);
            _db.SaveChanges();

        }

        public List<Post> GetPosts()
        {
            return _db.posts.ToList();
        }

        public List<PostDetail> getPostDetails()
        {
            return _db.postDetails.Include(pd => pd.post).ToList();
        }

        public void addDescriptionOfPostDetail(int postDetailId, string DescriptionText, IFormFile image)
        {
            DetailsDescription detailsDescription = new DetailsDescription();

            if (image != null)
            {
                detailsDescription.imageName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/PostDetailsImage", detailsDescription.imageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }

            detailsDescription.PostDetailsId = postDetailId;
            detailsDescription.Text = DescriptionText;

            _db.Add(detailsDescription);
            _db.SaveChanges();

        }

        public List<SelectListItem> GetPostsWithSectionIdForManageView(int sectionId)
        {
            return _db.posts.Where(p => p.SectionId == sectionId)
                .Select(p => new SelectListItem()
                {
                    Text = p.Title,
                    Value = p.PostId.ToString()
                }).ToList();
        }

        public Post getPostWithId(int id)
        {
            return _db.posts.Find(id);
        }

        public Post[] GetPostsWithSectionIdArray(int sectionId)
        {
            return _db.posts.Where(p => p.SectionId == sectionId).ToArray();
        }

        public bool updatePost(int id, string postTitle, string username, int SectionId, string PostText, IFormFile PostImg)
        {
            AdminPanel admin = _db.admins.Where(a => a.Username == username).First();
            Post post = _db.posts.Find(id);

            post.AdminPanelId = admin.AdminPanelId;
            post.SectionId = SectionId;
            if (PostText != null)
                post.PostText = PostText;
            if (postTitle != null)
                post.Title = postTitle;

            if (PostImg != null)
            {

                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/image", post.PostImg);
                if (imagePath != null)
                {
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    PostImg.CopyTo(stream);
                }
            }


            _db.Update(post);
            _db.SaveChanges();
            return true;
        }
    }
}
