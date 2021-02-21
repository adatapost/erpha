using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Erpha.KvDi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Erpha.Pages
{
    public class IndexModel : PageModel
    {
        public IKvApp AppValue { get; set; }
        private ILogger<IndexModel> _logger;

        public IndexModel(IKvApp appValue, ILogger<IndexModel> logger)
        {
            AppValue = appValue;
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation($"{AppValue.GetType().Name} institated with {AppValue.Name} and {AppValue.Author} properties");
        }
    }
}
