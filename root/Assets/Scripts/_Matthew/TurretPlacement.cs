﻿using UnityEngine;
using System.Collections;

public class TurretPlacement : Singleton<TurretPlacement> 
{
    public GameObject turret1, turret2, turret3, turret4;
    public GameObject dot;
    private GameObject turret;

    public bool isSelected = false; //checks to see if a turret is selected



	// Use this for initialization
	void Start () 
    {
       dot.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
    void Update()
    {
        //TurretSelect();
        //TurretPlace();
        //calls in the functions for selecting a turret and placing the turrets
    }

     public void TurretPlacePoint()
    {
        Vector3 pos = transform.position + Camera.main.transform.forward * 3;
        pos.y = 1;
        //Sets the spawn position that the turret will be placed at

        //dot.gameObject.SetActive(true);
        

        if (isSelected == true)
        {
            dot.gameObject.SetActive(true);
            Instantiate(turret, pos, transform.rotation);
            isSelected = false;
        }
    }

    public void TurretSelect(KeyCode a)
    {
        if (a == KeyCode.Alpha1) 
            // Player will press #1 - 4 keys to select which type of turret they would like to choose.  
        {

            // The turret placement will be placed in front of the player by 1 unit.
            turret = turret1;
            isSelected = true;
        }

        if (a == KeyCode.Alpha2)
        {
            
            turret = turret2;
            isSelected = true;
        }

        if (a == KeyCode.Alpha3)
        {
            
            turret = turret3;
            isSelected = true;
        }

        if (a == KeyCode.Alpha4)
        {
           
            turret = turret4;
            isSelected = true;
        }
    }
}