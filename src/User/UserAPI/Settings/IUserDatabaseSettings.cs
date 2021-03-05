﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI.Settings
{
    public interface IUserDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }
    }
}
