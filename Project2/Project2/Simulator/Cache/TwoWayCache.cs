/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Two-Way Set Associative Cache Model
 * 
 * Set # = Block # % Number of Sets 
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class TwoWayCache : Cache
    {
        public TwoWayCache()
            : base(1,12)
        {

        }
    }
}
