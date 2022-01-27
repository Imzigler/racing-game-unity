using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject car0;
    public GameObject car1;
    void Start()
    {
        car0.SetActive(true);
        car1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
