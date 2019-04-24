using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{
	public int test1;
	public bool test2;
	public string test3;
	public float test4;
	public double test5;
	public decimal test6;
	public sbyte test7;
	public short test8;
	public long test9;

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
		//Variablen Experiment
		FloatingpointTesting();
		DecimalTesting();
		IntegralTesting();
		BoolTesting();
		StringTesting();
		//Return Type Test
		Debug.Log(ReturnGrade(5));
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

	//experiments with variables and different type-assignments
	public void FloatingpointTesting()
	{
		test4 = 4.623f;
		Debug.Log("floatvalue is " + test4);

		test5 = 4.43213;
		Debug.Log("doublevalue is " + test5);
	}

	public void DecimalTesting()
	{
		test6 = 4.2332322m;
		Debug.Log("decimalvalue is " + test6);
	}

	public void IntegralTesting()
	{
		test1 = 2147483647;
		Debug.Log("the maximum range of int is " + test1);
		
		test7 = 127;
		Debug.Log("the maximum range of sbyte is " + test7);

		test8 = 32767;
		Debug.Log("the maximum range of short is " + test8);

		test9 = 9223372036854775807;
		Debug.Log("the maximum range of long is " + test9);
	}

	public void BoolTesting()
	{
		test2 = false;
		Debug.Log("boolvalue is " + test2);
	}

	public void StringTesting()
	{
		test3 = "world";
		Debug.Log("hello " + test3);
	}

	//experiments with return type and parameter
	public string ReturnGrade(int MyGrade)
	{
		return "My grade is" + " " + MyGrade;
	}

	//experiments we did in class:
	public string MyText(string myName)
	{
		return "Drama" + " " + myName;
	}

	public void XY()
	{
		Debug.Log("XY_void");
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

}
