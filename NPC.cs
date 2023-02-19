using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Vector3 newPosition;
    //zdorovye NPC
    public int health = 5;

    //uroven NPC
    public int level = 1;

    //scorost NPC
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //eto zdorovye + uroven
        health += level;

        // eto vivod zdorovya v consol
        print("health:"+health);


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position; 
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
