using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelo : MonoBehaviour {
		
		[SerializeField]
		public bool[] objetos = new bool[2];


		void Start(){
			
			
		}
		void Update(){
		
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
