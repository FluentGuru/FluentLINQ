using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IFluentQueryable<TResult> : IQueryableSource<TResult>
    {
        IFluentSource<TSource> From<TSource>(string identifier);
    }
}
