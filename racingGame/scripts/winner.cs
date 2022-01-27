using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehiclePhysics;

public class winner : MonoBehaviour
{

    public GameObject winscreen;
    public GameObject losescreen;
    private void OnTriggerEnter(Collider car)
    {
        if (car.CompareTag("Player"))
        {
            //winner winner chicken dinner 
            winscreen.SetActive(true);
            //also we need to stop player from playing 
            car.GetComponentInParent<VPStandardInput>().enabled = false;
        }
        if (car.CompareTag("AIcar"))
        {
            losescreen.SetActive(true);
            //we need the car to continue driving 

	    // we need to disable this because player lost 
	    gameObject.SetActive(false);
        }
    }
}
