using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    public float limits;
    public float movments;
    Vector3 targetpos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -1 * limits)
        {
            transform.position = new Vector3(transform.position.x + movments, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x - movments
                , transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movments);
        }else if (Input.GetKeyDown(KeyCode.S))
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movments);
        }


    }
}
