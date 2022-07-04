﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IHttpRequest
    {
        Task<T> Get<T>(string path);
    }
}
