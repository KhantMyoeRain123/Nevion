using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ArmorScript : MonoBehaviour, IPointerClickHandler
{

    public Control control;

    void Start(){
        control = GameObject.Find("SystemManager").GetComponent<Control>();

    }

    public void OnPointerClick(PointerEventData eventData){
    if (eventData.button == PointerEventData.InputButton.Left){
        control.armor++;
        control.armorText.text = ":"+control.armor.ToString();
    }else if (eventData.button == PointerEventData.InputButton.Right){
       control.armor--;
       control.armorText.text = ":"+control.armor.ToString();
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
