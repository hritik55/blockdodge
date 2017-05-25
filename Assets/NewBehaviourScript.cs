using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //create player spawn point
        //this is where our player will tart when the game is played
        //player = gameobject & gameobject = transform 

        transform.position = new Vector3(-2, 3, 0);	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
