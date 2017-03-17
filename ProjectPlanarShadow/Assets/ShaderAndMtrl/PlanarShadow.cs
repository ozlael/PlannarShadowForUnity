using UnityEngine;
using System.Collections;

public class PlanarShadow : MonoBehaviour {

	public float planeHeight = 0;

	// Use this for initialization
	void Start () {
		if (GetComponent<Renderer>())
		{
			GetComponent<Renderer>().material.SetFloat("planeHeight", planeHeight);
		}
	}

}
