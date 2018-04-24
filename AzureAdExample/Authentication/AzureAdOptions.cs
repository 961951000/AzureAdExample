using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAdExample.Authentication
{
    public class AzureAdOptions
    {
        public string ClientId { get; set; }

        public string Instance { get; set; }

        public string TenantId { get; set; }

        public string CallbackPath { get; set; }

        public string ClientSecret { get; set; }
    }
}
