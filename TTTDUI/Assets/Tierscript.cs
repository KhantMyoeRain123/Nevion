using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Tierscript : MonoBehaviour, IPointerClickHandler
{

    public Control control;

    void Start(){
        control = GameObject.Find("SystemManager").GetComponent<Control>();

    }

    public void OnPointerClick(PointerEventData eventData){
    if (eventData.button == PointerEventData.InputButton.Left){
        control.tier++;
        control.tierText.text = "T"+control.tier.ToString();
    }else if (eventData.button == PointerEventData.InputButton.Right){
       control.tier--;
       control.tierText.text = "T"+control.tier.ToString();
    }    
}
}

