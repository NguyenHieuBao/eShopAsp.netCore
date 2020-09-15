using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.DTOS
{
    public class PagedViewModel<T>
    {
        List<T> Items { get; set; }
        public int totalRecord { get; set; }
    }
}
