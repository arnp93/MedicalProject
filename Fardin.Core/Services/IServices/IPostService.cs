using Fardin.DataLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.Services.IServices
{
    public interface IPostService
    {
        bool addPost(string postTitle, string username,int SectionId, string PostText, IFormFile PostImg);
        bool updatePost(int id, string postTitle,string username, int SectionId, string PostText, IFormFile PostImg);
        List<Post> GetPosts();
        List<PostDetail> getPostDetails();

        void AddPostDetails(int PostId, string postDetailsText, IFormFile image);
        void addDescriptionOfPostDetail(int postDetailId, string DescriptionText, IFormFile image);

        List<SelectListItem> GetPostsWithSectionIdForManageView(int sectionId);
        Post getPostWithId(int id);
        Post[] GetPostsWithSectionIdArray(int sectionId);
    }
}
