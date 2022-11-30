using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public GameObject playermodel;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Crouch");

            transform.localScale = new Vector3(1f, .5f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
