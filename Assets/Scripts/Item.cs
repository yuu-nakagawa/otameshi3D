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
}
