using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashHandler : MonoBehaviour
{
    public ScoreTracker sTracker;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Not Recyclable"))
        {
            sTracker.ScoreAdd();
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag.Equals("Recyclable")) {
            sTracker.ScoreSubtract();
            Destroy(collision.gameObject);
        }
    }
}
