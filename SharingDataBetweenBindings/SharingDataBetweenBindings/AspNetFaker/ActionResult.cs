using SharingDataBetweenBindings.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingDataBetweenBindings.AspNetFaker
{
    public class ActionResult
    {
        internal Book Model<T>()
        {
            return new Book();
        }
    }
}
