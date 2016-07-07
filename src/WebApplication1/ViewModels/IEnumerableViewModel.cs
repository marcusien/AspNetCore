using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class IEnumerableViewModel : ViewModelBase, IEnumerable<Something>
    {

        public IEnumerator<Something> GetEnumerator()
        {
            return Enumerable.Empty<Something>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
