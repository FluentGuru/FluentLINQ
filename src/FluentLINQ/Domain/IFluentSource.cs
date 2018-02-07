using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IFluentSource<TSource> : IFluentTreeNode<TSource>
    {
        IFluentSourceField<TSource, TField> Field<TField>(Expression<Func<TSource, TField>> expression);
    }
}
