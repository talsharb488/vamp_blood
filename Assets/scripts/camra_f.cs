using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra_f : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		player=GameObject.Find("playerpoint").GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=player.transform.position;
	}
}
