﻿/*
 * Copyright (c) 2016 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using Microsoft.AspNetCore.Mvc;

namespace Piranha.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class PostController : ManagerAreaControllerBase
    {
        /// <summary>
        /// Default constroller.
        /// </summary>
        /// <param name="api">The current api</param>
        public PostController(IApi api) : base(api)
        {
        }

        /// <summary>
        /// Gets the list view for the posts.
        /// </summary>
        [Route("manager/posts")]
        public IActionResult List()
        {
            return View();
        }
    }
}
