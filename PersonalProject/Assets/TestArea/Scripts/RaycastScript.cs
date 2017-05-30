using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour {
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Input.touchCount >= 1)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);

                    RaycastHit hit;

                    if (Physics.Raycast(new Vector3(worldPos.x, worldPos.y, -1), transform.forward, out hit, 2))
                    {
                        Debug.Log("RaycastHit!");
                        if (hit.collider.gameObject.tag == "Enemy")
                        {
                            Destroy(hit.collider.gameObject);
                        }
                    }
                }
            }
        }
    }
}
