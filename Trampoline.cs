using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int jumpStrength = 2;

    //eto kogda igrok vhodit v collaydera
    void OnTriggerEnter (Collider other)

    {
        other.GetComponent<Jump>().jumpStrength = 10;
        
    }

    //eto kogda igrok vihodit iz collaydera
    void OnTriggerExit (Collider other)

    {
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}

