// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class mover : MonoBehaviour
// {
//    // [SerializeField]
//     Vector3 velocity = new Vector3(1, 0.5f, 0); 
//     Vector3 vect = new Vector3(1, 0, 0); 
//     // Start is called before the first frame update
//     void Start()
//     {
//         Debug.Log("Start");
//        // vect = GetComponent<Transform>().position;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         Debug.Log("Update");
//     //    GetComponent<Transform>().position += vect * Time.deltaTime;
        
//     }
// }
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Mover : MonoBehaviour
// {
//     [SerializeField]


//     private Vector3 initialPosition;

//     // Start is called before the first frame update
//     void Start()
//     {
//         initialPosition = transform.position;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float newY = 
//         float newX = 

//         transform.position = new Vector3(newX, newY, 0);
//     }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour
{
    Vector3 prevScale;
    bool state = false;
    public float amplitude = 1.0f;  // גובה התנועה
    public float frequency = 1.0f;  // תדר התנועה

    // private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        // initialPosition = transform.position;
        prevScale = GetComponent<Transform>().localScale;
        transform.position = new Vector3(-4, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Alpha1))
        {
           state = !state;
        
           if( state ) {
               GetComponent<Transform>().localScale = new Vector3(0,0,0); //transform.localScale = new Vector3(0,0,0);
           }
          else {
              GetComponent<Transform>().localScale = prevScale;
          }
        }
        float newX = transform.position.x/4 + Mathf.Sin(frequency*Time.time) * Time.deltaTime ;
        float newY = 1-Mathf.Sqrt(2-newX*newX);
        // Console.WriteLine(newX, newY);
        // Debug.Log("newX=" + newX + " newY=" + newY + " freq=" + frequency + " sin=" + Mathf.Sin(frequency*Time.time));
        // Debug.Log(newY);
        transform.position = new Vector3(4*newX, 4*newY, transform.position.z);
    }
}
    // using System.Collections;
    // using System.Collections.Generic;
    // using UnityEngine;
    // public class HeartBeat : MonoBehaviour
    // {
    //     public float minScaleFactor = 0.1f;  // Adjust this value to control the minimum scale
    //     public float maxScaleFactor = 1.3f;
    //     public float pulseSpeed = 1f;

    //     private bool isGrowing = true;
    //     private Vector3 initialScale;

    //     void Start()
    //     {
    //         // Save the initial scale for reference
    //         initialScale = transform.localScale;
    //     }

    //     void Update()
    //     {
    //         // Calculate the scaling factor based on time and speed
    //         float scaleChange = pulseSpeed * Time.deltaTime;

    //         // Determine whether to grow or shrink
    //         if (isGrowing)
    //         {
    //             transform.localScale += new Vector3(initialScale.x * scaleChange, initialScale.y * scaleChange,  initialScale.z * scaleChange);

    //             // Switch to shrinking if reaching the maximum scale
    //             if (transform.localScale.x >= initialScale.x * maxScaleFactor)
    //             {
    //                 transform.localScale = new Vector3(initialScale.x * maxScaleFactor, initialScale.y * maxScaleFactor, initialScale.z * maxScaleFactor);
    //                 isGrowing = false;
    //             }
    //         }
    //         else
    //         {
    //             transform.localScale -= new Vector3(initialScale.x * scaleChange, initialScale.y * scaleChange, initialScale.z * scaleChange);

    //             // Switch to growing if reaching the minimum scale
    //             if (transform.localScale.x <= initialScale.x * minScaleFactor)
    //             {
    //                 transform.localScale = new Vector3(initialScale.x * minScaleFactor, initialScale.y * minScaleFactor, initialScale.z * minScaleFactor);
    //                 isGrowing = true;
    //             }
    //         }

    //         // Ensure the object stays in the same Y position
    //         transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    //     }
    // }

//     using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class HeartBeat : MonoBehaviour
// {
//     public float minScaleFactor = 0.1f;  // Adjust this value to control the minimum scale
//     public float maxScaleFactor = 1.3f;
//     public float pulseSpeed = 1f;

//     private bool isGrowing = true;
//     private Vector3 initialScale;

//     void Start()
//     {
//         // Save the initial scale for reference
//         initialScale = transform.localScale;
//     }

//     void Update()
//     {
//         // Calculate the scaling factor based on time and speed
//         float scaleChange = pulseSpeed * Time.deltaTime;

//         // Determine whether to grow or shrink
//         if (isGrowing)
//         {
//             transform.localScale += new Vector3(initialScale.x * scaleChange, initialScale.y * scaleChange, initialScale.z * scaleChange);

//             // Switch to shrinking if reaching the maximum scale
//             if (transform.localScale.x >= initialScale.x * maxScaleFactor)
//             {
//                 transform.localScale = initialScale * maxScaleFactor;
//                 isGrowing = false;
//             }
//         }
//         else
//         {
//             transform.localScale -= new Vector3(initialScale.x * scaleChange, initialScale.y * scaleChange, initialScale.z * scaleChange);

//             // Switch to growing if reaching the minimum scale
//             if (transform.localScale.x <= initialScale.x * minScaleFactor)
//             {
//                 transform.localScale = initialScale * minScaleFactor;
//                 isGrowing = true;
//             }
//         }

//         // Ensure the object stays in the same Y position
//         transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
//     }
// }


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// public class HeartBeat : MonoBehaviour
// {
//     public float minScaleFactor = 0.1f;
//     public float maxScaleFactor = 1.3f;
//     public float pulseSpeed = 1f;

//     private bool isGrowing = true;
//     private Vector3 initialScale;

//     void Start()
//     {
//         // Save the initial scale for reference
//         initialScale = transform.localScale;
//     }

//     void Update()
//     {
//         // Calculate the scaling factor based on time and speed
//         float scaleChange = pulseSpeed * Time.deltaTime;

//         // Determine whether to grow or shrink
//         if (isGrowing)
//         {
//             transform.localScale += new Vector3(initialScale.x * scaleChange, initialScale.y * scaleChange, initialScale.z * scaleChange);

//             // Switch to shrinking if reaching the maximum scale
//             if (transform.localScale.x >= initialScale.x * maxScaleFactor)
//             {
//                 transform.localScale = new Vector3(initialScale.x * maxScaleFactor, initialScale.y * maxScaleFactor, initialScale.z * maxScaleFactor);
//                 isGrowing = false;
//             }
//         }
//         else
//         {
//             transform.localScale -= new Vector3(initialScale.x * scaleChange, initialScale.y * scaleChange, initialScale.z * scaleChange);

//             // Switch to growing if reaching the minimum scale
//             if (transform.localScale.x <= initialScale.x * minScaleFactor)
//             {
//                 transform.localScale = new Vector3(initialScale.x * minScaleFactor, initialScale.y * minScaleFactor, initialScale.z * minScaleFactor);
//                 isGrowing = true;
//             }
//         }

//         // Ensure the object stays in the same Y position
//         transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
//     }
// }