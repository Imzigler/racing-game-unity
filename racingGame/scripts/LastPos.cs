using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehiclePhysics;

public class LastPos : MonoBehaviour
{
    public GameObject winarea;
    public GameObject backcollider;
    private void OnTriggerEnter(Collider car)
    {
        {
            if (car.CompareTag("Player")||car.CompareTag("AIcar"))
            {
                //here we disable the collider 
                backcollider.SetActive(false);
                //car has across the last position
                //here we active the win area 
                winarea.SetActive(true);

            }
        }
    }
}
