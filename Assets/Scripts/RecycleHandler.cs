using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleHandler : MonoBehaviour
{
    public ScoreTracker sTracker;
    public AudioSource source;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Recyclable"))
        {
            sTracker.ScoreAdd();
            source.Play();
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag.Equals("Not Recyclable"))
        {
            sTracker.ScoreSubtract();
            Destroy(collision.gameObject);
        }
    }
}
