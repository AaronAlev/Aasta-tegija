using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public string itemName;
    public itemManager ui;
    
    void OnMouseDown(){
        ui.hasComputer = true;
        Destroy(gameObject);
    }
}
