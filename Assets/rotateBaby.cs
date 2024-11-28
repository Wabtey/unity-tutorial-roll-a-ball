using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBaby : MonoBehaviour
{
    public int speed = 360;

    // Start is called before the first frame update
    void Start()
    {
        // hola
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().eulerAngles += new Vector3(0, speed * Time.deltaTime, 0);
    }
}
