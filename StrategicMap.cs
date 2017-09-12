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