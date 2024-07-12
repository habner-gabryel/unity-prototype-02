using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // caso o objeto passe da visão, destrua-o
        if(transform.position.z > topBound){
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound){
            //caso o objeto passe o player, destrua-o e game over
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
