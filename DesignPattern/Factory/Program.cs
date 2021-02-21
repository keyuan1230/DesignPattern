using OperationLibrary;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object without exposing the creation logic to the client and refer to newly created object using a common interface.
            try
            {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";

                Operation oper;
                oper = OperationFactory.CreateOperate(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                strResult = oper.GetResult().ToString();

                Console.WriteLine("结果是：" + strResult);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }
}
