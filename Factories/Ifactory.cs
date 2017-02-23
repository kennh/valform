using User.Models;
using System.Collections.Generic;
namespace valform.Factory
{
    public interface IFactory<T> where T : BaseEntity
    {
    }
}