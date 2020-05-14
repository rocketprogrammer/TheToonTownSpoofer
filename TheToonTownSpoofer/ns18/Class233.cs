using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ns18
{
	// Token: 0x0200029E RID: 670
	internal static class Class233<T>
	{
		// Token: 0x06001B99 RID: 7065 RVA: 0x00056BD8 File Offset: 0x00054DD8
		public static PropertyInfo smethod_0<TValue>(Expression<Func<T, TValue>> selector)
		{
			Expression expression = selector;
			if (expression is LambdaExpression)
			{
				expression = ((LambdaExpression)expression).Body;
			}
			ExpressionType nodeType = expression.NodeType;
			if (nodeType == ExpressionType.MemberAccess)
			{
				return (PropertyInfo)((MemberExpression)expression).Member;
			}
			throw new InvalidOperationException();
		}
	}
}
