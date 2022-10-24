//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MyDragg : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = true;
    private void OnMouseDrag()
    {
        if (isBeingHeld)
        {
            //When Move Or Dragg Happen And You Held Key Or Touch
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }
    private void OnMouseDown()
    {
        //Start Touch Or Click On Object
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        startPosX = mousePos.x - this.transform.localPosition.x;
        startPosY = mousePos.y - this.transform.localPosition.y;
        isBeingHeld = true;
    }
    private void OnMouseUp()
    {
        //Drop Event Happen
        isBeingHeld = false;
    }


}
