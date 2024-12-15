using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class My : MonoBehaviour
{
    public UnityEvent onPointEnter, onPointExit;
    public Vector3 pos;

    public Transform player;
    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        player.localPosition = pos;
        //onPointEnter.Invoke();
        //SetMaterial(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        player.localPosition = new Vector3(0,1.6f,0);
        //onPointExit.Invoke();
        //SetMaterial(false);
    }
}
