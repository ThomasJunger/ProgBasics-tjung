using System.Collections;
using System.Collections.Generic;
//adding namespaces
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour {

	public Text myText;
	public TextMeshProUGUI myTMPText;

	private int countPresses = 0;

	private System.Random rnd = new System.Random();
	// Use this for initialization
	void Start () {
		myText.text = "Halloooo";
		myTMPText.text = "nochmal halloo";
		myText.fontSize = 40;
		Debug.Log(rnd.Next(0, 5));
	}

	public void addPress()
	{
		countPresses++;
		//the same as countPresses = countPresses +1;
		//and countPresses += 1;
		Debug.Log("counts: " + countPresses);
		myText.text = countPresses.ToString();
		myTMPText.text = countPresses.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
