using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Roundscript : MonoBehaviour, IPointerClickHandler
{

    public Control control;

    void Start(){
        control = GameObject.Find("SystemManager").GetComponent<Control>();

    }

    public void OnPointerClick(PointerEventData eventData){
    if (eventData.button == PointerEventData.InputButton.Left){
        control.round++;
        control.roundText.text = "R"+control.round.ToString();
    }else if (eventData.button == PointerEventData.InputButton.Right){
       control.round--;
       control.roundText.text = "R"+control.round.ToString();
    }    
}
}


