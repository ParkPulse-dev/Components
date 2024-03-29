using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedRotation;
    Vector3 prevScale;
    void Start()
    {
        prevScale = GetComponent<Transform>().localScale;
        speedRotation = 50f;
    }

    bool state = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
           state = !state;
        
           if( state ) {
               GetComponent<Transform>().localScale = new Vector3(0,0,0);
           }
          else {
              GetComponent<Transform>().localScale = prevScale;
          }
        }
        transform.rotation = Quaternion.Euler(0, 0, (Time.time * speedRotation) % 360);
    }
}
