using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

        public float coolDown;
    public const float coolDownTime = 0.5F;

    // Update is called once per frame
    void Update()
    {
        if(coolDown > 0){
            coolDown -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(coolDown <= 0){
                coolDown = coolDownTime;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
