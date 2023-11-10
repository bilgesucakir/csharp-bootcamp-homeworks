using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Data;

public interface IEntityBaseRepository<TEntity, TId>
{
    void Add(TEntity category);

    void Update(TEntity category);

    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);
}
