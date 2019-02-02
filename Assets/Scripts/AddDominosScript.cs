using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDominosScript : MonoBehaviour {
	
    public GameObject template;

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < 30; i++)
		{
			//Debug.Log("Hello");
			Instantiate(template, new Vector3(0, 1.5F, i * 3F + 3), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
