using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoltarTeleporter : MonoBehaviour
{

    public Transform player;
    public Transform reciever;

    private bool playerIsOverlaping = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (playerIsOverlaping)
	    {
	        Debug.Log("playerIsOverlaping");
            Vector3 portalToPlayer = player.position - transform.position;

	        float dotProd = Vector3.Dot(transform.up, portalToPlayer);

	        if (dotProd < 0f)
	        {
                Debug.Log("Teleport");
	            float rotDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
	            rotDiff += 180;
                player.Rotate(Vector3.up, rotDiff);
	            Vector3 positionOffset = Quaternion.Euler(0f, rotDiff, 0f) * portalToPlayer;
	            player.position = reciever.position + positionOffset;

	            playerIsOverlaping = false;
	        }
	    }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlaping = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlaping = false;
        }
    }

}
