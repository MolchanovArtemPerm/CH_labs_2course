using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_Lab10
{
    public class SortName : IComparer<Trial>
    {
        int IComparer<Trial>.Compare(Trial t1, Trial t2)
        {
            return string.Compare(t1.subject_surname, t2.subject_surname);
        }
    }
}
