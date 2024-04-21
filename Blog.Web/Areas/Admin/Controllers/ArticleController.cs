﻿using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            var articles= await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult>Add()

        {
            return View();

        }

    } 
}
