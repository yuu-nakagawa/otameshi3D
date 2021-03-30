using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    // やりたいこと
    //アイテムCubeを持っている状態で、クリックすると消える
    //・クリック判定
    //・アイテム持ってますよ判定

    public void OnClickObj()
    {
        Debug.Log("クリックしたよ");
        //アイテムCubeを持っているかどうか
        bool clear = ItemBox.instance.TryUseItem();
        if (clear == true)
        {
            Debug.Log("ギミック解除");
            gameObject.SetActive(false);
        }
    }
}

