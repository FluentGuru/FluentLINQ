using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IJoinSource<TSource, TCompare> : IFluentSource<TSource>
    {
        IFluentSource<TCompare> ComparedSource { get; }
        Expression<Func<TSource, TCompare, bool>> ConditionExpression { get; }
        bool IncludeEmpty { get; set; }
    }
}
