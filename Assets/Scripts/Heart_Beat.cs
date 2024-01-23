using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Heart_Beat : MonoBehaviour
{
    Vector3 prevScale;
    public float minScaleFactor = 0.1f;
    public float maxScaleFactor = 1.3f;
    public float pulseSpeed = 1f;

    private bool isGrowing = true;
    private Vector3 initialScale;

    void Start()
    {
        // Save the initial scale for reference
        initialScale = transform.localScale;
    }
    bool state = false;
    void Update()
    {
        float scaleChange = pulseSpeed * Time.deltaTime;
        float newGrowX = initialScale.x * scaleChange;
        float newGrowY = initialScale.y * scaleChange;
        float newGrowZ = initialScale.z * scaleChange;
        float minX = initialScale.x * maxScaleFactor;
        float minY = initialScale.y * maxScaleFactor;
        float minY = initialScale.z * maxScaleFactor;
        float maxX = initialScale.x * maxScaleFactor;
        float maxY = initialScale.y * maxScaleFactor;
        float maxZ = initialScale.z * maxScaleFactor;
        
        // Calculate the scaling factor based on time and speed
         if(Input.GetKeyDown(KeyCode.Alpha3))
        {
           state = !state;
        
           if( state ) {
               GetComponent<Transform>().localScale = new Vector3(0,0,0);
           }
          else {
              GetComponent<Transform>().localScale = prevScale;
          }
        }

        // Determine whether to grow or shrink
        if (isGrowing)
        {
            transform.localScale += new Vector3(newGrowX, newGrowY, newGrowZ);

            // Switch to shrinking if reaching the maximum scale
            if (transform.localScale.x >= maxX)
            {
                float newShrinkX = initialScale.x * maxScaleFactor;
                float newShrinkY = initialScale.y * maxScaleFactor;
                float newShrinkZ = initialScale.z * maxScaleFactor;
                transform.localScale = new Vector3(maxX, maxY, maxZ);
                isGrowing = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(newGrowX, newGrowY, newGrowZ);

            // Switch to growing if reaching the minimum scale
            if (transform.localScale.x <= minX)
            {
                transform.localScale = new Vector3(minX, minY, minZ);
                isGrowing = true;
            }
        }

        // Ensure the object stays in the same Y position
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }
}
