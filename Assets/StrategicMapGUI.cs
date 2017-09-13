using System.Collections;
using System.Collections.Generic;
using QuickGraph;
using UnityEngine;

public class StrategicMapGUI : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		ConfigurationFactory configurationFactory = new ConfigurationFactory();
		IList<Fraction> fractions = configurationFactory.CreateFractions();
		AdjacencyGraph<ProvinceOnMap, EdgeOnMap> provinces = configurationFactory.CreateProvinces();
		
		StrategicMap map = new StrategicMap(fractions, provinces);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
