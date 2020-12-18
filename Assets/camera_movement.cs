using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    public float rotationSpeed = 500000;
    public float translationSpeed = .00000000005f;


    public float orbitSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //for rotation
        //Vector3 rotation = transform.eulerAngles;

        //rotation.y += Input.GetAxis("Fire1") * rotationSpeed * Time.deltaTime; // Standart Left-/Right Arrows and A & D Keys

        //transform.eulerAngles = rotation;

        ////for translation
        //var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //transform.position += move * translationSpeed;


        transform.RotateAround(new Vector3(50,40,0), Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
