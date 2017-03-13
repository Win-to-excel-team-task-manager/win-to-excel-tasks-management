using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.Entities
{
    public class TaskProject : BaseEntity
    {
        public string Phases { set; get; }
        public string Project { set; get; }
        public string Code { set; get; }
        public double Order { set; get; }
        public double CompetenceLevel { set; get; }
        
        public string Description { set; get; }
        public string TechnicalNote { set; get; }
     //   public string NomberOfAffectation { set; get; }


        public override string ToString()
        {
            return Code; 
        }

    }
}
