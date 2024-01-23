
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour
{
    Vector3 prevScale;
    bool state = false;
    public float amplitude = 1.0f;  // גובה התנועה
    public float frequency = 1.0f;  // תדר התנועה

    // Start is called before the first frame update
    void Start()
    {

        prevScale = GetComponent<Transform>().localScale;
        transform.position = new Vector3(-4, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = !state;

            if (state)
            {
                GetComponent<Transform>().localScale = new Vector3(0, 0, 0); //transform.localScale = new Vector3(0,0,0);
            }
            else
            {
                GetComponent<Transform>().localScale = prevScale;
            }
        }
        float newX = transform.position.x / 4 + Mathf.Sin(frequency * Time.time) * Time.deltaTime;
        float newY = 1 - Mathf.Sqrt(2 - newX * newX);
        // Console.WriteLine(newX, newY);
        // Debug.Log("newX=" + newX + " newY=" + newY + " freq=" + frequency + " sin=" + Mathf.Sin(frequency*Time.time));
        // Debug.Log(newY);
        transform.position = new Vector3(4 * newX, 4 * newY, transform.position.z);
    }
}