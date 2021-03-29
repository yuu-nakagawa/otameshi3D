using System;
using UnityEngine;

[Serializable]
public class Item
{
    //ñ^:íÞðñ·é
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       //íÞ
    public Sprite sprite;   //SlotÉ\¦·éæ

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
