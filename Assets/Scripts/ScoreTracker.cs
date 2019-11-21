using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int mScore = 0;
    public Text mText;
    // Start is called before the first frame update
    void Start()
    {
        mText.text = mScore.ToString();
    }

    public void ScoreAdd() {
        System.Random r = new System.Random();
        mScore += r.Next(1, 10);
        mText.text = mScore.ToString();
    }

    public void ScoreSubtract() {
        System.Random r = new System.Random();
        mScore -= r.Next(1, 5);
        mText.text = mScore.ToString();
    }
}
