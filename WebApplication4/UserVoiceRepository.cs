using System.Collections.Generic;

namespace WebApplication4
{
    public class UserVoiceRepository
    {
        private readonly List<UserVoiceItem> _items = new List<UserVoiceItem>();

        public UserVoiceRepository()
        {
            _items.Add(new UserVoiceItem()
            {
                Title = "Make WebDeploy transactional",
                Description = "When deploying a site, the previous version should continue to run. If the deployment fails, the site should continue to run on the previous version. If it succeeds, the switch should happen after publication is complete.",
                Downvotes = 5,
                Upvotes = 10,
                Id = 1,
            });

            _items.Add(new UserVoiceItem()
            {
                Title = "ASP.NET Identity membership DB Tool to mangage users, roles needed",
                Description = "A simple user interface tool is needed to create and manage Users and Roles with ASP.NET Identity. Please port the ASP.NET Web Site Administration Tool ( http://www.asp.net/web-forms/tutorials/deployment/deploying-web-site-projects/users-and-roles-on-the-production-website-cs ) to work with the new ASP.NET Identity membership DB",
                Downvotes = 3,
                Upvotes = 1,
                Id = 2,
            });
        }

        public IEnumerable<UserVoiceItem> GetUserVoiceItems()
        {
            return _items;
        }

        public void AddUserVoiceItem(UserVoiceItem item)
        {
            // todo: validation

            _items.Add(item);
        }
    }
}
