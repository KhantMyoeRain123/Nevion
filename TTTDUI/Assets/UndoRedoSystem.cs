using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoRedoSystem : MonoBehaviour
{
    public Control control;
    public Stack<string> undoStack;
    public Queue<string> redoQueue;

    public string poppedKey;


    //KEYS
    public const string HITPOINT_PLUS="HPP";

    public const string HITPOINT_MINUS="HPM";

    // Start is called before the first frame update
    public void Undo()
    {
        poppedKey=undoStack.Pop();
        redoQueue.Enqueue(poppedKey);
        if(poppedKey=="HPP")
        {
            control.minusHitpoints();
        }
        else if(poppedKey=="HPM")
        {
            control.addHitpoints();
        }

    }
    public void Redo()
    {
        poppedKey=redoQueue.Dequeue();
        undoStack.Push(poppedKey);
        if(poppedKey=="HPP")
        {
            control.addHitpoints();
        }
        else if(poppedKey=="HPM")
        {
            control.minusHitpoints();
        }



    }
}
