using System;
using System.Collections.Generic;
using Doroga.Domain.Services.Contracts;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services
{
    public class ArticleService:IArticleService
    {
        private readonly IDependencyResolver _dependencyResolver;

        public ArticleService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public IEnumerable<ArticleEntity> GetAllArticles()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.ArticleRepository.GetAllArticles();
            }
        }

        public ArticleEntity GetArticleById(string articleId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.ArticleRepository.GetArticleById(articleId);
            }
        }

        public void CreateArticle(ArticleEntity article, string currentArticleId)
        {
            if (article == null)
            {
                throw new ArgumentException("ArticleEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentArticleId))
            {
                throw new ArgumentException("CurrentArticleId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.ArticleRepository.CreateArticle(article);
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateArticle(ArticleEntity article, string currentArticleId)
        {

            if (article == null)
            {
                throw new ArgumentException("ArticleEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentArticleId))
            {
                throw new ArgumentException("CurrentArticleId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.ArticleRepository.UpdateArticle(article);
                unitOfWork.SaveChanges();
            }
        }
    }
}
