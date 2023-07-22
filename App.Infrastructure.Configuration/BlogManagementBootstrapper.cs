using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.ArticleCategory;
using _01_LampshadeQuery.Query;
using App.Application;
using App.Application.Contracts.Article;
using App.Application.Contracts.ArticleCategory;
using App.Domain.ArticleAgg;
using App.Domain.ArticleCategoryAgg;
using App.Application;
using App.Application.Contracts.Article;
using App.Application.Contracts.ArticleCategory;
using App.Domain.ArticleAgg;
using App.Domain.ArticleCategoryAgg;
using App.Infrastructure.EFCore;
using App.Infrastructure.EFCore.Repository;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infrastructure.Configuration
{
    public class BlogManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();

            services.AddTransient<IArticleQuery, ArticleQuery>();
            services.AddTransient<IArticleCategoryQuery, ArticleCategoryQuery>();

            services.AddDbContext<BlogContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
