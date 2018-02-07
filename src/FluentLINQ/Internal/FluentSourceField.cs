using FluentLINQ.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace FluentLINQ.Internal
{
    internal class FluentSourceField<TSource, TField> : FluentTreeNodeBase<TField>, IFluentSourceField<TSource, TField>
    {
        private readonly IFluentSource<TSource> _source;
        private readonly Expression<Func<TSource, TField>> _expression;

        public FluentSourceField(Expression<Func<TSource, TField>> expression) : base()
        {
            _expression = expression;
        }


        public IFluentSource<TSource> Source => _source;

        public override Expression Expression => _expression;
    }
}
