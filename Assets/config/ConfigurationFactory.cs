using System.Collections.Generic;
using QuickGraph;

public class ConfigurationFactory
    {
        
        List<Fraction> fractions = new List<Fraction>();
        
        public IList<Fraction> CreateFractions()
        {
            
            Resources zuluResources = new Resources();
            List<IAbility> zuliAbilities = new List<IAbility>();
            fractions.Add(new Fraction("zulusi", zuluResources, zuliAbilities, true));
            
            
            
            return fractions;
        }

        public AdjacencyGraph<ProvinceOnMap, EdgeOnMap> CreateProvinces()
        {
            ProvinceOnMap p1 = new ProvinceOnMap(new Province("Bruksela", brukselaResources, brukselaAbilities, findOwner("zulusi")));
            ProvinceOnMap p2 = new ProvinceOnMap(new Province("Haga", hagaResources, hagaAbilities, findOwner("zulusi")));
            ProvinceOnMap p3 = new ProvinceOnMap(new Province("Frankfurt", frankfurtResources, frankfurtAbilities, findOwner("zulusi")));

            
            AdjacencyGraph<ProvinceOnMap, EdgeOnMap> graph = new AdjacencyGraph<ProvinceOnMap, EdgeOnMap>();
            
            EdgeOnMap edge1 = new EdgeOnMap(p1, p2);
            EdgeOnMap edge2 = new EdgeOnMap(p1, p3);

            
            graph.AddEdge(edge1);
            graph.AddEdge(edge2);
            
            return graph;
        }

        private Fraction findOwner(string name)
        {
            foreach (var fraction in fractions)
            {
                if (fraction.Name.Equals(name))
                    return fraction;
            }
            return null;
        }
        
    }
