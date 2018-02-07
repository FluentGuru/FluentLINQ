using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IQueryableSource<TSource> : IFluentSource<TSource>, IQueryable<TSource>
    {
    }
}
