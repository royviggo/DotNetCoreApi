using System;

namespace DotNetCore.DataInterface
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