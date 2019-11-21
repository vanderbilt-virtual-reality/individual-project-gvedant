using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashHandler : MonoBehaviour
{
    public ScoreTracker sTracker;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Brick"))
        {
            sTracker.ScoreAdd();
        }

        else {
            sTracker.ScoreSubtract();
        }
    }
    // Start is called before the first frame update
    /**
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    **/
}
