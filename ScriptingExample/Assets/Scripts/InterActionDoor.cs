using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class InterActionDoor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
    public Renderer doorPane;
    public Animator pivotAnimator;

    public void OnPointerClick(PointerEventData eventData)
    {
        pivotAnimator.enabled = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        doorPane.material.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        doorPane.material.color = Color.white;
    }

}
