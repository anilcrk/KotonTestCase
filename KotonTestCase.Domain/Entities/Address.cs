using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotonTestCase.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        /// <summary>
        /// full address
        /// </summary>
        public string Description { get; set; }

        //Relations
        public Customer Customer { get; set; }
    }
}
