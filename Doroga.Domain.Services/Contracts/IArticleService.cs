using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services.Contracts
{
   public interface IArticleService
    {
        IEnumerable<ArticleEntity> GetAllArticles();
        ArticleEntity GetArticleById(string articleId);
        void CreateArticle(ArticleEntity article, string currentArticleId);
        void UpdateArticle(ArticleEntity article, string currentArticleId);
    }
}
