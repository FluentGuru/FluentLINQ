using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IFluentQueryField<TResult, TField> : IFluentSourceField<TResult, TField>
    {
        IFluentQueryField<TResult, TField> From(IFluentSourceField<TField> source);
    }
}
