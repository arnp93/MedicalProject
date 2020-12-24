using Fardin.Core.DTO;
using Fardin.DataLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Fardin.Core.Services.IServices
{
    public interface IPostService
    {
        bool addPost(string postTitle, string username, int SectionId, string PostText, string lang, string hashtags, IFormFile PostImg);
        bool updatePost(int id, string postTitle, string username, int SectionId, string lang, string PostText, IFormFile PostImg);
        void updateSubPost(SubPostEditViewModel SubPost, string lang);
        void updateSubPostDescription(int SubPostDescriptionId, string DescriptionText, string lang, IFormFile image);
        void updateSubPostDescription(int DescriptionId, int SubPostId, string descriptionText, string lang, IFormFile image);
        List<Post> GetPostsForAdmin();
        List<Post> GetPosts();
        List<SubPost> getSubPosts();
        List<SubPost> getSubPostsWithDescription();
        SubPostDescription getSubPostDescriptionBySubPostId(int id);
        void AddSubPost(int PostId, string lang, SubPostEditViewModel SubPost, List<IFormFile> images);
        void addDescriptionOfSubPost(int SubPostId, string DescriptionText, string lang, IFormFile image, List<IFormFile> images);
        List<SelectListItem> GetPostsWithSectionIdForManageView(int sectionId);
        Post getPostWithId(int id);
        Post[] GetPostsWithSectionIdArray(int sectionId);
        List<SelectListItem> getSubPostsByPostId(int id);
        List<SubPost> getSubPostsWithPostId(int postId);
        SubPost getSubPostById(int id);
        bool isAnySubPost(int id);
        List<DeletePostPageViewModel> getDeletePostViewModels();
        void deletePost(int id);
        void deleteSubPostById(int id);
        void deleteSubPostDescriptionById(int id);
        List<DeleteSubPostViewModel> getDeleteSubPosts();
        List<SubPostDescription> getsubPostDescription();
        SubPostDescription getSubPostDescriptionById(int SubPostId);
        List<SubPostViewModel> getSubPostsWithData();
        List<SubPost> getSubPostsListByPostId(int id);
        SiteStatic getSiteStaticInformation();

        void saveSiteStatic(SiteStatic SiteStatic, IFormFile Coverpic, IFormFile Footerpic,string lang);
        void updateSiteStatic(SiteStatic SiteStatic, IFormFile Coverpic, IFormFile Footerpic,string lang);
    }
}
