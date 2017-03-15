using System;
using Project.Domain.Core.Commands;

namespace Project.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}