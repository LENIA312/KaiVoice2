using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class headerManager : MonoBehaviour
{
    [SerializeField] Text name = default;
    [SerializeField] Button achievementButton = default;

    public void setup(string name,Action onAchievement)
    {
        this.name.text = name;
        achievementButton.onClick.AddListener(() => onAchievement?.Invoke());
    }
}
