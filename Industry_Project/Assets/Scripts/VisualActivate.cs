using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualActivate : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextureScroll>().enabled = false;

        GetComponent<Outline>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<TextureScroll>().enabled = true;

            GetComponent<Outline>().enabled = true;
        }
        else
        {
            GetComponent<TextureScroll>().enabled = false;

            GetComponent<Outline>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<TextureScroll>().enabled = false;

            GetComponent<Outline>().enabled = false;
        }
        else
        {
            GetComponent<TextureScroll>().enabled = true;

            GetComponent<Outline>().enabled = false;
        }
    }
}
