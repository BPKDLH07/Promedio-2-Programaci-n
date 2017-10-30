using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vista : MonoBehaviour {

	[SerializeField]
	public GameObject[] herramientas = new GameObject[3];
	// Use this for initialization
	void Start () {
		herramientas[0].SetActive(false);
		herramientas[1].SetActive(false);
		herramientas[2].SetActive(false);		
	}
	
	// Update is called once per frame
	void Update () {

		//Lo últimos cambios hubieron problemas, el ultimo commit, debido a que la maquina se apagó de repente de Salvador
		
	}
}
