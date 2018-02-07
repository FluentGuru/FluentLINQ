using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IFluentSourceField<TField> : IFluentTreeNode<TField>
    {
    }

    public interface IFluentSourceField<TSource, TField> : IFluentSourceField<TField>
    {
        IFluentSource<TSource> Source { get; }
    }
}
