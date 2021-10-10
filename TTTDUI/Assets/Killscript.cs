using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


   public class Killscript : MonoBehaviour, IPointerClickHandler
{

    public Control control;

    void Start(){
        control = GameObject.Find("SystemManager").GetComponent<Control>();

    }

    public void OnPointerClick(PointerEventData eventData){
    if (eventData.button == PointerEventData.InputButton.Left){
        control.kills++;
        control.killsText.text = ":"+control.kills.ToString();
    }else if (eventData.button == PointerEventData.InputButton.Right){
       control.kills--;
       control.killsText.text = ":"+control.kills.ToString();
    }    
}
}