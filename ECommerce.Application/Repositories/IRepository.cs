using ECommerce.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerce.Application.Repositories;

public interface IRepository<T> where T : Entity
{
    DbSet<T> Table { get; }
}
