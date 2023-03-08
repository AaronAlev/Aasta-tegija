using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject canvas;
    public GameObject questMarker;
    public GameObject noQuestDoneText;
    public int timesTalkenTo = 0;
    private int questsDone = 0;
    void OnMouseDown(){
        if (timesTalkenTo==0){
            canvas.SetActive(true);
            questMarker.SetActive(false);
            timesTalkenTo += 1;
        }
        else if (timesTalkenTo==1 && questsDone==0){
            canvas.SetActive(true);
            noQuestDoneText.SetActive(true);
        }
    }

    void Update(){

    }
}
