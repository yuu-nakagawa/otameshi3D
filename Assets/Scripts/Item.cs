using System;
using UnityEngine;

[Serializable]
public class Item
{
    //�񋓌^:��ނ�񋓂���
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       //���
    public Sprite sprite;   //Slot�ɕ\������摜
    public GameObject zoomObj;

    public Item(Type type, Sprite sprite,GameObject zoomObj)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomObj = zoomObj;
    }
}
