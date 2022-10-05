using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceDataItem : MonoBehaviour
{
    [SerializeField] Text name = default;
    [SerializeField] Text num = default;

    public void setup(string name,int num)
    {
        this.name.text = name;
        this.num.text = num + "‰ñ";
    }
}
