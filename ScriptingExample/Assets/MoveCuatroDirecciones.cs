using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class MoveCuatroDirecciones : MonoBehaviour, IUpdateSelectedHandler
{
    public Transform AgentTransform;
    public bool Up;

    
    public void OnUpdateSelected(BaseEventData eventData)
    {
        if (Up)
        {
            AgentTransform.Translate(Vector3.forward * Time.deltaTime * 2f);
        } else
        {
            AgentTransform.Translate(Vector3.back * Time.deltaTime * 2f);
        }
    }
}
