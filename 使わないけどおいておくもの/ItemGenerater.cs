using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity;
    public static ItemGenerater instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        public Item Spawn(Item.Type type)
        {
            //itemList�̒�����type�ƈ�v�����瓯��item�𐶐����ēn��
            foreach (Item item in ItemListEntity.itemList)
            {
                if (item.type == type)
                {
                    return new Item(item.type, item.sprite);
                }
            }
            return null;
        }
    }
}