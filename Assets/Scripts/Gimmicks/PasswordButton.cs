using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordButton : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;
    public int number;
    //ŽÀs‚³‚ê‚½‚ç”’l‚ð•Ï‚¦‚é
    private void Start()
    {
        number = 0;
        numberText.text = number.ToString();
    }

    public void OnClickThis()
    {
        number++;
        if (number > 9)
        {
            number = 0;
        }
        numberText.text = number.ToString();
    }
}
