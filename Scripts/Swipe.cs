using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector2(x: transform.localPosition.x+eventData.delta.x,transform.localPosition.y);
    }
}
