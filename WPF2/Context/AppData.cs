using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF2.Model;

namespace WPF2.Context
{
    public static class AppData
    {
        public static BookdbEntities db = new BookdbEntities();
    }
}
