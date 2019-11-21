﻿using System;

namespace DotNetCore.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository Events { get; }
        IEventTypeRepository EventTypes { get; }
        IPersonRepository Persons { get; }
        IPlaceRepository Places { get; }

        void Save();
    }
}