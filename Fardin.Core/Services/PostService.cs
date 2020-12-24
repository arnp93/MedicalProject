using Fardin.Core.DTO;
using Fardin.Core.Services.IServices;
using Fardin.DataLayer.Context;
using Fardin.DataLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Fardin.Core.Services
{
    public class PostService : IPostService
    {
        private DatabaseContext _db;
        string lang = CultureInfo.CurrentCulture.Name;
        public PostService(DatabaseContext context)
        {
            _db = context;
        }
        public bool addPost(string postTitle, string username, int SectionId, string PostText, string lang, string hashtags, IFormFile PostImg)
        {
            AdminPanel admin = _db.admins.Where(a => a.Username == username).First();
            Post post = new Post()
            {
                AdminPanelId = admin.AdminPanelId,
                SectionId = SectionId,
                PostText = PostText,
                Title = postTitle,
                LanguageTitle = lang,
                Hashtags = hashtags
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

        public void AddSubPost(int PostId, string lang, SubPostEditViewModel SubPost, List<IFormFile> images)
        {
            SubPost subPost = new SubPost()
            {
                PostId = PostId,
                Title = SubPost.Title,
                TextResumen = SubPost.Text,
                LanguageTitle = lang
            };

            if (SubPost.Image != null)
            {
                subPost.ImageName = Guid.NewGuid() + Path.GetExtension(SubPost.Image.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", subPost.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    SubPost.Image.CopyTo(stream);
                }
            }


            if (images != null)
            {

                foreach (var image in images)
                {
                    string imageName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/postImageGallery", imageName);

                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        image.CopyTo(stream);
                    }

                    if (subPost.Images == null)
                    {
                        subPost.Images = imageName;
                    }
                    else
                    {
                        subPost.Images = subPost.Images + "," + imageName;
                    }

                }
            
            }

            _db.Add(subPost);
            _db.SaveChanges();

        }

        public List<Post> GetPosts()
        {
            return _db.posts.Where(p => p.LanguageTitle == lang).ToList();
        }

        public List<SubPost> getSubPosts()
        {
            return _db.subPosts.Include(pd => pd.post).ToList();
        }

        public void addDescriptionOfSubPost(int SubPostId, string DescriptionText, string lang, IFormFile image,List<IFormFile> images)
        {
            //TODO: Check if works fine!!! !!NOT CHECKED!!
            SubPostDescription detailsDescription = new SubPostDescription();

            if (image != null)
            {
                detailsDescription.imageName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", detailsDescription.imageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }

            if (images != null)
            {

                foreach (var Image in images)
                {
                    string imageName = Guid.NewGuid() + Path.GetExtension(Image.FileName);
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/postImageGallery", imageName);

                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        Image.CopyTo(stream);
                    }

                    if (detailsDescription.Images == null)
                    {
                        detailsDescription.Images = imageName;
                    }
                    else
                    {
                        detailsDescription.Images = detailsDescription.Images + "," + imageName;
                    }

                }

            }

            detailsDescription.SubPostId = SubPostId;
            detailsDescription.Text = DescriptionText;
            detailsDescription.LanguageTitle = lang;
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

        public bool updatePost(int id, string postTitle, string username, int SectionId, string lang, string PostText, IFormFile PostImg)
        {
            AdminPanel admin = _db.admins.Where(a => a.Username == username).First();
            Post post = _db.posts.Find(id);

            post.AdminPanelId = admin.AdminPanelId;
            post.SectionId = SectionId;
            post.LanguageTitle = lang;
            if (PostText != null)
                post.PostText = PostText;
            if (postTitle != null)
                post.Title = postTitle;

            if (PostImg != null)
            {

                if (post.PostImg != null)
                {
                    string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/image", post.PostImg);
                    if (imgPath != null)
                    {
                        if (File.Exists(imgPath))
                        {
                            File.Delete(imgPath);
                        }
                    }

                }
                post.PostImg = Guid.NewGuid() + Path.GetExtension(PostImg.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/image", post.PostImg);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    PostImg.CopyTo(stream);
                }

            }


            _db.Update(post);
            _db.SaveChanges();
            return true;
        }

        public List<SelectListItem> getSubPostsByPostId(int id)
        {

            return _db.subPosts.Where(pd => pd.PostId == id)
                .Select(pd => new SelectListItem()
                {

                    Text = pd.Title,
                    Value = pd.SubPostId.ToString()
                }).ToList();
        }

        public SubPost getSubPostById(int id)
        {
            return _db.subPosts.SingleOrDefault(pd => pd.SubPostId == id);
        }

        public bool isAnySubPost(int id)
        {
            return _db.subPosts.Any(pd => pd.SubPostId == id);
        }

        public void updateSubPost(SubPostEditViewModel SubPost, string lang)
        {
            SubPost detail = getSubPostById(SubPost.SubPostId);
            if (SubPost.Image != null)
            {
                if (detail.ImageName != null)
                {
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", detail.ImageName);
                    if (imagePath != null)
                    {
                        if (File.Exists(imagePath))
                        {
                            File.Delete(imagePath);
                        }
                    }
                }
                else
                {
                    detail.ImageName = Guid.NewGuid() + Path.GetExtension(SubPost.Image.FileName);
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", detail.ImageName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        SubPost.Image.CopyTo(stream);
                    }
                }

            }
            detail.Title = SubPost.Title;
            detail.TextResumen = SubPost.Text;
            detail.LanguageTitle = lang;
            _db.subPosts.Update(detail);
            _db.SaveChanges();
        }

        public SubPostDescription getSubPostDescription(int SubPostid)
        {
            return _db.subPostDescriptions.SingleOrDefault(dd => dd.SubPostId == SubPostid);
        }

        public void updateSubPostDescription(int DescriptionId, int SubPostId, string descriptionText, string lang, IFormFile image)
        {
            SubPostDescription description = _db.subPostDescriptions.Find(DescriptionId);

            description.SubPostId = SubPostId;
            description.Text = descriptionText;
            description.LanguageTitle = lang;
            if (image != null)
            {
                if (description.imageName != null)
                {
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", description.imageName);
                    if (imagePath != null)
                    {
                        if (File.Exists(imagePath))
                        {
                            File.Delete(imagePath);
                        }
                    }
                }
                else
                {
                    description.imageName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", description.imageName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        image.CopyTo(stream);
                    }
                }

            }
            _db.subPostDescriptions.Update(description);
            _db.SaveChanges();

        }

        public void updateSubPostDescription(int SubPostDescriptionId, string DescriptionText, string lang, IFormFile image)
        {

            SubPostDescription subPostDescription = _db.subPostDescriptions.SingleOrDefault(spd => spd.SubPostDescriptionId == SubPostDescriptionId);
            if (subPostDescription != null)
            {
                if (image != null)
                {
                    if (subPostDescription.imageName != null)
                    {
                        string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", subPostDescription.imageName);
                        if (imgPath != null)
                        {
                            if (File.Exists(imgPath))
                            {
                                File.Delete(imgPath);
                            }
                        }
                    }
                    subPostDescription.imageName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/posts/SubPostsImage", subPostDescription.imageName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        image.CopyTo(stream);
                    }
                }
                subPostDescription.Text = DescriptionText;
                subPostDescription.LanguageTitle = lang;
                _db.Update(subPostDescription);
                _db.SaveChanges();
            }
        }
        public List<DeletePostPageViewModel> getDeletePostViewModels()
        {
            List<Post> posts = _db.posts.Include(p => p.SubPosts).ToList();

            List<DeletePostPageViewModel> deletePostPageViewModel = new List<DeletePostPageViewModel>();

            foreach (var post in posts)
            {
                deletePostPageViewModel.Add(new DeletePostPageViewModel
                {
                    postTitle = post.Title,
                    postImage = post.PostImg,
                    PostId = post.PostId,
                    SubPostTitles = post.SubPosts.Select(pd => pd.Title).Take(3).ToList()
                });
            }

            return deletePostPageViewModel;


        }

        public void deletePost(int id)
        {
            Post post = _db.posts.Find(id);
            _db.Remove(post);
            _db.SaveChanges();
        }

        public List<DeleteSubPostViewModel> getDeleteSubPosts()
        {
            List<SubPost> SubPosts = _db.subPosts.Include(pd => pd.subPostDescription).ToList();
            List<DeleteSubPostViewModel> deleteSubPostViewModel = new List<DeleteSubPostViewModel>();
            foreach (var SubPost in SubPosts)
            {
                deleteSubPostViewModel.Add(new DeleteSubPostViewModel
                {
                    Title = SubPost.Title,
                    id = SubPost.SubPostId,
                    Image = SubPost.ImageName,
                    detailDescriptions = SubPost.subPostDescription == null ? "متنی موجود نیست" : SubPost.subPostDescription.Text
                });
            }
            return deleteSubPostViewModel;
        }

        public void deleteSubPostById(int id)
        {
            _db.Remove(_db.subPosts.Find(id));
            _db.SaveChanges();
        }

        public List<SubPostDescription> getsubPostDescription()
        {
            return _db.subPostDescriptions.ToList();
        }

        public void deleteSubPostDescriptionById(int id)
        {
            _db.Remove(_db.subPostDescriptions.Find(id));
            _db.SaveChanges();
        }

        public List<SubPost> getSubPostsWithPostId(int postId)
        {
            return _db.subPosts.Where(pd => pd.PostId == postId).ToList();
        }

        public SubPostDescription getSubPostDescriptionById(int SubPostId)
        {
            return _db.subPostDescriptions.Where(d => d.SubPostId == SubPostId).Include(dd => dd.SubPost).LastOrDefault();
        }

        public List<SubPostViewModel> getSubPostsWithData()
        {
            return _db.posts.Select(pd => new SubPostViewModel
            {
                PostId = pd.PostId,
                PostText = pd.PostText,
                Title = pd.Title
            }).ToList();
        }

        public List<SubPost> getSubPostsListByPostId(int id)
        {
            return _db.subPosts.Where(sp => sp.PostId == id).ToList();
        }

        public List<SubPost> getSubPostsWithDescription()
        {
            return _db.subPosts.Include(sp => sp.subPostDescription).ToList();
        }

        public SubPostDescription getSubPostDescriptionBySubPostId(int id)
        {
            return _db.subPostDescriptions.SingleOrDefault(spd => spd.SubPostId == id);
        }

        public List<Post> GetPostsForAdmin()
        {
            return _db.posts.ToList();
        }

        public SiteStatic getSiteStaticInformation()
        {
            return _db.siteStatics.LastOrDefault();
        }

        public void saveSiteStatic(SiteStatic SiteStatic, IFormFile Coverpic, IFormFile Footerpic, string lang)
        {
            if (Coverpic != null)
            {
                SiteStatic.CoverImageName = Guid.NewGuid() + Path.GetExtension(Coverpic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myImages", SiteStatic.CoverImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    Coverpic.CopyTo(stream);
                }
            }

            if (Footerpic != null)
            {
                SiteStatic.FooterImageName = Guid.NewGuid() + Path.GetExtension(Footerpic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myImages", SiteStatic.FooterImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    Footerpic.CopyTo(stream);
                }
            }
            SiteStatic.LanguageTitle = lang;
            _db.siteStatics.Add(SiteStatic);
            _db.SaveChanges();
        }

        public void updateSiteStatic(SiteStatic SiteStatic, IFormFile Coverpic, IFormFile Footerpic, string lang)
        {
            if (Coverpic != null)
            {

                if (SiteStatic.CoverImageName != null)
                {
                    string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myImages", SiteStatic.CoverImageName);
                    if (imgPath != null)
                    {
                        if (File.Exists(imgPath))
                        {
                            File.Delete(imgPath);
                        }
                    }

                }
                SiteStatic.CoverImageName = Guid.NewGuid() + Path.GetExtension(Coverpic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myImages", SiteStatic.CoverImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    Coverpic.CopyTo(stream);
                }

            }

            if (Footerpic != null)
            {

                if (SiteStatic.FooterImageName != null)
                {
                    string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myImages", SiteStatic.FooterImageName);
                    if (imgPath != null)
                    {
                        if (File.Exists(imgPath))
                        {
                            File.Delete(imgPath);
                        }
                    }

                }
                SiteStatic.FooterImageName = Guid.NewGuid() + Path.GetExtension(Footerpic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myImages", SiteStatic.FooterImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    Footerpic.CopyTo(stream);
                }

            }

            SiteStatic.LanguageTitle = lang;
            _db.siteStatics.Update(SiteStatic);
            _db.SaveChanges();
        }
    }
}
