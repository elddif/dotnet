﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamwork.Client.HTTPClient;

namespace TeamworkProjects.HTTPClient
{
    using System.Net.Http;

    public partial class AuthorizedHttpClient : HttpClient
    {

        public ClientCache Cache { get; set; } = new ClientCache();





    }
}
