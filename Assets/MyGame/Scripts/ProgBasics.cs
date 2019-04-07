using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("erste Tests mit Operatoren");

		Debug.Log("Multiplikative Operatoren: 3*4= " + (3*4));
		Debug.Log("Multiplikative Operatoren: 16/4= " + (16/4));
		Debug.Log("Multiplikative Operatoren: 10%3= " + (10%3));

		Debug.Log("Additive Operatoren: 1+5=  " + (1+5));
		Debug.Log("Additive Operatoren: 9-6=  " + (9-6));

		Debug.Log("Relationale Operatoren: 9>6=  " + (9>6));
		Debug.Log("Relationale Operatoren: 9<6=  " + (9<6));
		Debug.Log("Relationale Operatoren: 5>=5=  " + (5>=5));
		Debug.Log("Relationale Operatoren: 6<=6=  " + (6>=6));

		Debug.Log("Gleichheits Operatoren: 6==6=  " + (6==6));
		Debug.Log("Gleichheits Operatoren: 6!=6=  " + (6!=6));

		

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
