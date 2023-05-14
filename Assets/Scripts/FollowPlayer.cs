using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Public GameObject used to reference the player in the Inspector window
    public GameObject player;
    private Vector3 offsetThirdPerson = new Vector3(0, 7, -8);
    private float rotateThirdPerson = 24.0f;
    private Vector3 offsetFirstPerson = new Vector3(0, 2.05f, 0.05f);

    // Update is called once per frame
    void LateUpdate()
    {

        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offsetThirdPerson;
        transform.rotation = Quaternion.Euler(rotateThirdPerson, 0.0f, 0.0f);

    }
}
