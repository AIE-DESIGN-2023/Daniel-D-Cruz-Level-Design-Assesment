using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public float scoreToAdd = 10;
    private ScoreCanvas scoreCanvas;
    // Start is called before the first frame update
    void Start()
    {
        scoreCanvas = FindObjectOfType<ScoreCanvas>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.GetComponent<CharacterController>())
        //if(other.transform.tag == "Player" || other.gameObject.layer == 9)
        {
            scoreCanvas.UpdateScore(scoreToAdd);
            Destroy(this.gameObject);
        }
    }
}
