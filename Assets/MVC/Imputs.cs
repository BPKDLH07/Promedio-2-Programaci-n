using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imputs : MonoBehaviour {
	public Modelo modelo;
	public Vista vista;

	// Use this for initialization
	void Start () {
		modelo.objetos[0]=false;
		modelo.objetos[1]=false;
	}
	
	// Update is called once per frame
	void Update () {
		Inputs();	
		
	}
	// void Inputs(){
		// if(Input.GetKeyDown(KeyCode.I))
			//Debug.Log("Inventory is open");

	 //}
	void Inputs(){
		if(Input.GetKeyDown(KeyCode.A)){
			modelo.objetos[0]=true;
			vista.herramientas[0].SetActive(true);
		}
		if(Input.GetKeyDown(KeyCode.S)){
			modelo.objetos[1]=true;
			vista.herramientas[1].SetActive(true);
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
		modelo.objetos[0]=false;
		modelo.objetos[1]=false;
		vista.herramientas[2].SetActive(false);
		}		
	}

	 public void OnClick(){
		 modelo.Crafting01();
		 vista.herramientas[2].SetActive(true);
	 }
}
