﻿using DotNetCore.Domain.Entities;
using System;

namespace DotNetCore.Data
{
    public interface IEventTypeRepository : IGenericRepository<EventType>, IDisposable
    {
    }
}
