using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentLINQ.Domain
{
    public interface IFluentTreeNode
    {
        Func<bool> IsApplicable { get; set; }

        Type NodeType { get; }

        Expression Expression { get; }
    }

    public interface IFluentTreeNode<TNode> : IFluentTreeNode { }
}
