using System;
using System.Collections.Generic;

namespace Algo.Stack
{
    public class PostfixCalc
    {

        public PostfixCalc()
        {

        }

        //567*+1-
        public int DoCaliculate(string[] args)
        {
            Stack<int> values=new Stack<int>();
            foreach(string token in args)
            {
                int value;
                if(int.TryParse(token,out value))
                {
                    values.Push(value);
                }
                else
                {
                    int rhs=values.Pop();
                    int lhs=values.Pop();

                    switch(token)
                    {
                        case "+": values.Push(lhs+rhs); break;
                        case "-": values.Push(lhs-rhs); break;
                        case "*": values.Push(lhs*rhs); break;
                        case "/": values.Push(lhs/rhs); break;
                        case "%": values.Push(lhs%rhs); break;
                        default :
                                  throw new ArgumentException(string.Format("Unrecognized token :{0}", token)); 
                    }
                }
            }      

            return values.Pop();      
        }
    }
}