using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour {

    public Transform player;
    public Transform[] positions;
    public float touchCooldown = 1;

    int index = 0;
    public float lastTouch = 0;

	void Start () {
		
	}
	
	void Update () {
        if (Time.time - lastTouch < touchCooldown)
        {
            return;
        }

		if (Input.touchCount > 0)
        {
            player.position = positions[index].position;
            player.rotation = positions[index].rotation;

            lastTouch = Time.time;
            index++;
            if (index >= positions.Length)
            {
                index = 0;
            }
        }
	}
}
