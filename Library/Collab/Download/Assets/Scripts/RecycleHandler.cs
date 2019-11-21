using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleHandler : MonoBehaviour
{
    public ScoreTracker sTracker;
    public AudioSource source;

    void OnCollisionEnter(Collision collision)
    {
        source.Play();
        if (collision.gameObject.name.Equals("Cereal"))
        {
            sTracker.ScoreAdd();
        }

        else
        {
            sTracker.ScoreSubtract();
        }
    }
}
