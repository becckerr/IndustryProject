using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    public float seen = 0f;

    public bool isBeingSeen = false;
    public bool isHidden = false;


    // Start is called before the first frame update
    void Start()
    {
        seen = 0f;
        isBeingSeen = false;
        isHidden = false;
    }

    // Update is called once per frame
    void Update()
    {
        ControlSeen();

        seen = Mathf.Clamp(seen, 0, 300);
    }

    void ControlSeen()
    {
        if(isBeingSeen && !isHidden)
        {
            seen += 0.5f;
        }
        if(seen > 0f)
        {
            if(!isBeingSeen && isHidden)
            {
                seen -= 0.3f;
            }
            else if(isBeingSeen && isHidden)
            {
                seen -= 0.3f;
            }
            else if(!isBeingSeen && !isHidden)
            {
                seen -= 0.3f;
            }
        }
    }



    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("AlienSight"))
        {
            isBeingSeen = true;
        }
        else if(!other.gameObject.CompareTag("AlienSight"))
        {
            isBeingSeen = false;
        }
        else
        {
            isBeingSeen = false;
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Shadow"))
        {
            isHidden = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("AlienSight"))
        {
            isBeingSeen = false;
        }

        if(other.gameObject.CompareTag("Shadow"))
        {
            isHidden = false;
        }
    }

}