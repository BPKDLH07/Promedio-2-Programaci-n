using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	 void Inputs(){
		 if(Input.GetKeyDown(KeyCode.I))
			Debug.Log("Inventory is open");

	 }
}
