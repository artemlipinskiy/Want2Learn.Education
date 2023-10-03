using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP.LINQ_Datas
{
    class User<T> where T: struct
    {
        public T Id { get; set; }
        public string Login { get; set; }
    }
}
