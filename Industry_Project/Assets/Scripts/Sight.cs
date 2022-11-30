using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    public int seen;

    public bool hidden;

    // Start is called before the first frame update
    void Start()
    {
        seen = 0;

        hidden = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Shadow"))
        {
            hidden = true;
        }

        if (other.gameObject.CompareTag("AlienSight")&&!hidden)
        {
            seen += 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Shadow"))
        {
            hidden = false;
        }
    }
}
