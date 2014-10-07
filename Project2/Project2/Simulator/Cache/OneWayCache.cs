/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: One-Way Associative (Direct Mapped) Cache Model
 * 
 * Frame # = Block # % Cache Size 
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class OneWayCache : Cache
    {
        public OneWayCache() : base(1,12)
        {

        }
    }
}
