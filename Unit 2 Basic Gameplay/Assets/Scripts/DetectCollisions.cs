using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Game Over!");
        }
        else if (other.gameObject.name == "Animal_Doe_01(Clone)")
        {
            PlayerController.addScore();
        }
        
         else if (other.gameObject.name == "Animal_Fox_01(Clone)")
        {
            PlayerController.addScore();
        }

        else if (other.gameObject.name == "Animal_Moose_02(Clone)")
        {
            PlayerController.addScore();
        }

        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
}
