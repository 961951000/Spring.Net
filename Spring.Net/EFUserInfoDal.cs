﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Net.Models;

namespace Spring.Net
{
    public class EFUserInfoDal : IUserInfoDal
    {
        public EFUserInfoDal()
        {

        }
        public UserInfo UserInfo { get; set; }
        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine("我是EF Dal,属性注入：Name=" + Name);
            Console.WriteLine("UserInfo ,Name=" + UserInfo.Name + " Age=" + UserInfo.Age);
        }
    }
}
