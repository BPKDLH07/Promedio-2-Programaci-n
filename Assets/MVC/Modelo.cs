using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelo : MonoBehaviour {
		
		[SerializeField]
		public bool[] objetos = new bool[2];

		void Start(){
			objetos[0]=false;
			objetos[1]=false;
			
		}
		void Update(){
			Inputs();
	}

	void Inputs(){
		if(Input.GetKeyDown(KeyCode.A)){
			objetos[0]=true;
		}
		if(Input.GetKeyDown(KeyCode.S)){
			objetos[1]=true;
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			objetos[0]=false;
			objetos[1]=false;
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			Crafting01();
		}
				
	}


	public void Crafting01(){
		if(objetos[0]==true&&objetos[1]==true){
			Debug.Log("CrafteadoEsto");
		} else
		{
			Debug.Log("Esto no Craftea");
		}
	}
}
