using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelo : MonoBehaviour {
		
		[SerializeField]
		public bool[] objetos = new bool[2];
<<<<<<< HEAD
=======

>>>>>>> cae6e10e5016c4679e7d9ac4ddcbbf31887a1201

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
