﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVET.Helper
{
        public interface ICombosHelper
        {
            IEnumerable<SelectListItem> GetComboPetTypes();
        }
}
