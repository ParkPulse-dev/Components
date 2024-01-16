using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 prevScale;
    void Start()
    {
        prevScale = GetComponent<Transform>().localScale;
    }

    // public void ButtonPressed() {
    //     gameObject.SetActive(false);
    // }

    bool state = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
           state = !state;
        
           if( state ) {
               GetComponent<Transform>().localScale = new Vector3(0,0,0); //transform.localScale = new Vector3(0,0,0);
           }
          else {
              GetComponent<Transform>().localScale = prevScale;
          }
        }

        // if(Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //    // state = !state;
        //     gameObject.SetActive(true);
        // }
        transform.rotation = Quaternion.Euler(0, 0, (Time.time*50) % 360);
        
    }
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Mover2 : MonoBehaviour
// {
//     bool state = true;

//     // Update is called once per frame
//     void Update()
//     {
//         transform.rotation = Quaternion.Euler(0, 0, (Time.time * 50) % 360);

//         // בדיקה אם נלחץ הכפתור השמאלי של העכבר
//         if (Input.GetMouseButtonDown(0))
//         {
//             // שינוי סטטוס
//             state = !state;

//             // החבאה או הצגה מחדש של האובייקט בהתאם לסטטוס
//             gameObject.SetActive(state);
//         }
//     }
//}

