using CSharpBasic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    public class ExpressionDemo : BaseDemo
    {
        public override void DoTest()
        {
            Expression<Func<int,bool>> exp1 = s => s == 1;
            var result=exp1.Compile()(1);
            Console.WriteLine("exp1.Compile()(1)=" + result);//True
            var result2 = exp1.Compile()(2);
            Console.WriteLine("exp1.Compile()(2)=" + result2);//False

            ExpressionAnaly(s => new { s.Id, s.Name });
        }

        public void ExpressionAnaly<V>(Expression<Func<Employee, V>> exp) {
            Console.WriteLine("exp.Name=" + exp.Name);// 空
            Console.WriteLine("exp.Body=" + exp.Body);//new <> f__AnonymousType0`2(Id = s.Id, Name = s.Name)
            Console.WriteLine("exp.NodeType=" + exp.NodeType);//Lambda
            Console.WriteLine("exp.Parameters=" + exp.Parameters);//System.Runtime.CompilerServices.TrueReadOnlyCollection`1[System.Linq.Expressions.ParameterExpression]
            Console.WriteLine("exp.Type=" + exp.Type);//System.Func`2[CSharpBasic.Model.Employee,<> f__AnonymousType0`2[System.Int32, System.String]]
            Console.WriteLine("exp.ReturnType=" + exp.ReturnType);//f__AnonymousType0`2[System.Int32, System.String]
            MemberInitExpression body = (MemberInitExpression)exp.Body;
            
        }
    }
}
