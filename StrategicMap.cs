using System;
using SimpleJson;
using System.Security.Policy.Zone;
using System.Object;
using System.SystemException;

namespace AssemblyCSharp
{

    public class StrategicMap
    {
        public void Move(Province start, Province destination, Army army)  
        {
            start.MoveOut(army);
            destination.VisitBy(army);
        }
    }
    
    
}