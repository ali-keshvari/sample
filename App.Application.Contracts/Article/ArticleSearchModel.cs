using App.Application.Contracts.ArticleCategory;
using System.Collections.Generic;

namespace App.Application.Contracts.Article
{
    public class ArticleSearchModel
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }
    }
}
