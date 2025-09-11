using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.EntityExtensions
{
    [Serializable]
    public abstract class Identity<T> : BaseEntity, IIdentity<T>
    {
        public virtual T Id { get; set; }
    }

    [Serializable]
    public abstract class BaseEntity
    {
    }

    public interface IIdentity<T>
    {
        T Id { get; set; }
    }
}
