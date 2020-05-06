using Fardin.DataLayer.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.Services.IServices
{
    public interface IPostService
    {
        bool addPost(string username,int SectionId, string PostText, IFormFile PostImg);
        List<Post> GetPosts();
        List<PostDetail> getPostDetails();

        void AddPostDetails(int PostId, string postDetailsText, IFormFile image);
        void addDescriptionOfPostDetail(int postDetailId, string DescriptionText, IFormFile image);
    }
}
