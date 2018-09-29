﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Cms.Models;

namespace SecretTarot.Module.Cms.Controllers
{
    public class PageController : Controller
    {
        private readonly IRepository<Page> _pageRepository;

        public PageController(IRepository<Page> pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public IActionResult PageDetail(long id)
        {
            var page = _pageRepository.Query().FirstOrDefault(x => x.Id == id);

            return View(page);
        }
    }
}
