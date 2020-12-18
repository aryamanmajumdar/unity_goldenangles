using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject sphere;

    float theta = 0;
    float b = (float)(Mathf.PI * (3.0 - Mathf.Sqrt(5.0f)));
    float n = 1;
    double xpos;
    double ypos;
    int initialradius = 10;
    float counter = 10; //counter starts as initial radius

    float R = 50; //Maximum we're allowed the bloom to grow

    float increment = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //if counter is less than a certain radius,

        if (counter < R)
        {
            //Make a ring every update
            CreateGoldenRing(counter);
            //increment counter
            counter += increment;
        }
        else 
        {
            //Destroy all instantiated objects
            DeleteAll();
            counter = initialradius;
            n++;
        }

    }

    void Increase(float angleIncrease)
    {
        this.theta = this.theta + angleIncrease;
    }

    void CreateGoldenRing(float c)
    {
        //draw one sphere at c from center and angle theta (maybe conv coords to cart)
        Instantiate(sphere, new Vector3(R - c * Mathf.Sin(theta), R - c * Mathf.Cos(theta), 0), Quaternion.identity);
        //increase theta
        Increase(n * b);
    }

    public void DeleteAll()
    {
        foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
        {
            if (o.GetComponent("SphereCollider") != null) 
            {
                Destroy(o);
            }

        }
    }
}
