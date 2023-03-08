using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : MonoBehaviour
{
    public bool hasComputer = false;
    public GameObject computer;

    public void Update(){
        if (hasComputer==true){
            computer.SetActive(true);
        }
    }        
}
