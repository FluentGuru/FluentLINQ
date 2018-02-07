using FluentLINQ.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ
{
    public abstract class FluentTreeNodeBase : IFluentTreeNode
    {
        public Func<bool> IsApplicable { get; set; }

        public Type NodeType { get; protected set; }

        public abstract Expression Expression { get; }
    }

    public abstract class FluentTreeNodeBase<TNode> : FluentTreeNodeBase
    {
        public FluentTreeNodeBase()
        {
            NodeType = typeof(TNode);
        }
    }
}
