using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


   public class AttackCountscript : MonoBehaviour, IPointerClickHandler
{

    public Control control;

    void Start(){
        control = GameObject.Find("SystemManager").GetComponent<Control>();

    }

    public void OnPointerClick(PointerEventData eventData){
    if (eventData.button == PointerEventData.InputButton.Left){
        control.attackCount++;
        control.attackCountText.text = ":"+control.attackCount.ToString();
    }else if (eventData.button == PointerEventData.InputButton.Right){
       control.attackCount--;
       control.attackCountText.text = ":"+control.attackCount.ToString();
    }    
}
}