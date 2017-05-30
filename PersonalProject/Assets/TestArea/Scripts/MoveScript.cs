using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public int speed = 1;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
	}
}
