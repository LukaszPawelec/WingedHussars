    using System.Collections.Generic;
    using QuickGraph;

public class StrategicMap
    {
    
        private IList<Fraction> fractions;
        private AdjacencyGraph<ProvinceOnMap, EdgeOnMap> provinces;
        
        public StrategicMap(IList<Fraction> fractions, AdjacencyGraph<ProvinceOnMap, EdgeOnMap> provinces)
        {
            this.fractions = fractions;
            this.provinces = provinces;
        }

        public void Move(Province start,Province destination, Army army)  
        {
            //TODO czy na pewno armia stała w starcie?
            //czy starti stop są skomunikowane?
            start.MoveOut(army);
            destination.VisitBy(army);
        }
    }
    
    
