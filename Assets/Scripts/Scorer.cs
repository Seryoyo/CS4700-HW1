using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Player"){
            hits++;
            Debug.Log("You've bumped into an obstacle this many times: " + hits);
        }
    }

}
