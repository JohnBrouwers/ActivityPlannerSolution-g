using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.Data
{
    class GenericRepository<T>
    {
        public void Add(T item) 
        {
            //code to add T in a db
        }
        public void Update(T item) 
        {
            //code to update T in a db        
        }
        public void Delete(T item) 
        {
            //code to delete T in a db 
        
        }
    }
}
