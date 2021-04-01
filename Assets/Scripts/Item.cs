using System;
using UnityEngine;

[Serializable]
public class Item
{
    //—ñ‹“Œ^:Ží—Þ‚ð—ñ‹“‚·‚é
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       //Ží—Þ
    public Sprite sprite;   //Slot‚É•\Ž¦‚·‚é‰æ‘œ
    public GameObject zoomObj;

    public Item(Type type, Sprite sprite,GameObject zoomObj)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomObj = zoomObj;
    }
}
