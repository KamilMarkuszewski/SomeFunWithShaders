using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynchronizePositionsScript : MonoBehaviour
{

    public Transform playerCamera;
    public Transform playerCharacter;

    public Transform Room1;
    public Transform Room2;

    public Transform Portal1;
    public Transform Portal2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Room2.position  - Room1.position + playerCamera.position + new Vector3(0, 4, 0);
        transform.rotation = Quaternion.Euler(playerCharacter.rotation.eulerAngles.x, playerCharacter.rotation.eulerAngles.y, 0);

    }
}
