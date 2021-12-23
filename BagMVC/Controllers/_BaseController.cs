using BagLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BagMVC.Controllers
{
    public abstract class _BaseController : Controller
    {
        protected readonly BagContext _context;

        protected IConfiguration _configuration;

        protected int CurrentUserId { get; set; } = 1;


        public _BaseController(BagContext context)
        {
            _context = context;
        }

        public _BaseController(BagContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }


    }
}
