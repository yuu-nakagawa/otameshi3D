using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObje : MonoBehaviour
{
    //クリックしたらログを出す

    public void OnClickObj()
    {
        gameObject.SetActive(false);
    }
}
