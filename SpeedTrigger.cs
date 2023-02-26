using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    //eto kogda igrok vhodit v collaydera
    void OnTriggerEnter (Collider other)

    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        
    }

    //eto kogda igrok vihodit iz collaydera
    void OnTriggerExit (Collider other)

    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;

    }
}

