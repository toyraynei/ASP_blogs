using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Blogs.Data;
using Blogs.Model;

namespace Blogs
{
    public class IndexModel : PageModel
    {
        private readonly Blogs.Data.ArticleContext _context;

        public IndexModel(Blogs.Data.ArticleContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
