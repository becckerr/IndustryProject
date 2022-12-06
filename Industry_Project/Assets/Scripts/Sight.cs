using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sight : MonoBehaviour
{
    public float seen = 0f;

    public int dangerlevel;

    public bool isBeingSeen = false;
    public bool isHidden = false;

    public bool dangerincrease;

    public AudioSource seentrack;


    // Start is called before the first frame update
    void Start()
    {
        seen = 0f;
        isBeingSeen = false;
        isHidden = false;
        dangerincrease = false;
    }

    // Update is called once per frame
    void Update()
    {
        ControlSeen();

<<<<<<< Updated upstream
        if (seen < 0f)
        {
            seen = 0f;
        }
=======
        seen = Mathf.Clamp(seen, 0, 300);

        if(seen > 17)
        {
            SceneManager.LoadScene("Scene02");
        }
    }

    void dangerlevelincrease()
    {
        dangerlevel += 1;
>>>>>>> Stashed changes
    }

    void ControlSeen()
    {
        if (isBeingSeen && !isHidden)
        {
            seen += 0.5f;

            seentrack.Play();
        }
        else
        {
            seentrack.Stop();
        }

        if (seen > 0f)
        {
            if (!isBeingSeen && isHidden)
            {
                seen -= 0.3f;
            }
            else if (isBeingSeen && isHidden)
            {
                seen -= 0.3f;
            }
            else if (!isBeingSeen && !isHidden)
            {
                seen -= 0.3f;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AlienSight"))
        {
            isBeingSeen = true;
        }

        if ((other.gameObject.CompareTag("Shadow")) || (other.gameObject.CompareTag("ShutterShadow")))
        {
            isHidden = true;
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("AlienSight"))
        {
            isBeingSeen = true;
        }

        if ((other.gameObject.CompareTag("Shadow")) || (other.gameObject.CompareTag("ShutterShadow")))
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

        if ((other.gameObject.CompareTag("Shadow")) || (other.gameObject.CompareTag("ShutterShadow")))
        {
            isHidden = false;
        }
    }

}
