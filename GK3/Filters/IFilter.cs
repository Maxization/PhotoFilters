using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public interface IFilter
    {
        Color Handle(FilterType type, Color color);
        void setNext(IFilter filter);
    }

    public abstract class BaseFilter : IFilter
    {
        protected IFilter next;
        public virtual Color Handle(FilterType type, Color color)
        {
            return color;
        }
        public void setNext(IFilter filter)
        {
            next = filter;
        }
    }
}
