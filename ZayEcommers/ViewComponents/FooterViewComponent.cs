using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using ZayEcommers.DAL;

namespace ZayEcommers.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var footer = await _dbContext.footer.SingleOrDefaultAsync();
            return View(footer);
        }
    }
}
