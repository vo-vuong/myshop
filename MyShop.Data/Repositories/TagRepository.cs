using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}