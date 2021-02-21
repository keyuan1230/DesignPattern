using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLibrary
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// 数字A
        /// </summary>
        public double NumberA { get; set; }

        /// <summary>
        /// 数字B
        /// </summary>
        public double NumberB { get; set; }

        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    /// 加法类
    /// </summary>
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = NumberA * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            double result = NumberA / NumberB;
            return result;
        }
    }


    /// <summary>
    /// 运算类工厂
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OperationDiv();
                        break;
                    }
            }

            return oper;
        }
    }
}