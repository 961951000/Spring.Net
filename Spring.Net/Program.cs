using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

//Spring.Aop.dll 面向切面编程
//Spring.Core.dll spring框架基础
//Common.Logging.dll 这个必须也要引用

namespace Spring.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制权没有反转
            //IUserInfoDal infoDal = new EFUserInfoDal();

            //Spring.Net 创建实例的方式转为容器帮我们创建
            //第一步，引用Spring.Net程序集 Spring.Core.dll 和 Common.Logging.dll
            //第二步，添加Spring.Net配置节点
            //第三步，配置object节点
            //第四步，创建spring容器上下文
            IApplicationContext ctx = ContextRegistry.GetContext();
            //第五步，通过容器创建对象
            IUserInfoDal efDal = ctx.GetObject("UserInfoDal") as IUserInfoDal;
            efDal?.Show();

            IUserInfoDal adoDal = ctx.GetObject("UserInfoDal2") as IUserInfoDal;
            adoDal?.Show();

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
