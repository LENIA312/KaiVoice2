using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceButton : MonoBehaviour
{
    [SerializeField] Button playButton = default;
    [SerializeField] Text titleText = default;

    public void setup(Action voicePlay, string text)
    {
        playButton.onClick.AddListener(()=>voicePlay?.Invoke());
        titleText.text = text;
    }
}
