﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{
	public int test1;
	public float test2;
	public string test3;

	// Use this for initialization
	void Start () 
	{
		test1 = 1;
		Debug.Log("test 1 in Start " + test1);
		//Operators();
		//XY();
		//VoidMethod();
		//AddNumbers(3,4);
		//MultNumbers(1,4,5,6);
		Combine();
		Debug.Log(MyText("tjung"));
		string drama = MyText("tjung");
		Debug.Log("neu " + drama); 

	}

	public string MyText(string myName)
	{
		return "Drama" + " " + myName;
	}

	public void Operators()
	{
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

		Debug.Log("Logische Operatoren: &=  " + (true&true));
		Debug.Log("Logische Operatoren: &=  " + (false&&true));
		Debug.Log("Logische Operatoren: |=  " + (false|true));
		Debug.Log("Logische Operatoren: ||=  " + (true||false));
	}

	public void XY()
	{
		Debug.Log("XY_void");
	}
	
	public void VoidMethod()
	{
		//do something
	}

	public void AddNumbers(int a, int b)
	{
		int c = a + b;
		Debug.Log("add numbers " + c);
		test1 = 3;
		Debug.Log("test 1 in AddNumbers " + test1);
	}

	public void MultNumbers(int a, int b, int c, int d)
	{
		int e = a * b * c * d;
		Debug.Log("add multiple numbers " + e);
	}

	public void Combine()
	{
		MultNumbers(5, 4, 2, 6);
		AddNumbers(1, 2);
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
