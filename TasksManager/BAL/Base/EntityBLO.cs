using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TasksManager.DAL;
using TasksManager.Entities;

namespace TasksManager.BAL
{
    public class EntityBLO<T> where T:BaseEntity
    {
       protected IEtityDAO EntityDAO;

       public EntityBLO()
        {
           
        }
    }
}
