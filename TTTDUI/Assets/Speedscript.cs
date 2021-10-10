using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Speedscript : MonoBehaviour, IPointerClickHandler
{

    public Control control;

    void Start(){
        control = GameObject.Find("SystemManager").GetComponent<Control>();

    }

    public void OnPointerClick(PointerEventData eventData){
    if (eventData.button == PointerEventData.InputButton.Left){
        control.speed++;
        control.speedText.text = ":"+control.speed.ToString();
    }else if (eventData.button == PointerEventData.InputButton.Right){
       control.speed--;
       control.speedText.text = ":"+control.speed.ToString();
    }    
}

public void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("The gameObject has been right clicked");
        }
    }
}
