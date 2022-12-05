using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine;


[CreateAssetMenu(menuName = "KaiVoice/VoiceTable", fileName = "VoiceTable")]

public class voiceAttach : ScriptableObject
{
    [SerializeField] VoiceData[] Voices;

    [Serializable]
    public class VoiceData
    {
        public AudioClip voices;
        public string voiseName;

        public VoiceData(AudioClip audioClip, string name)
        {
            voices = audioClip;
            voiseName = name;
        }
    }

    public List<VoiceData> GetVoiceData()
    {
        var voiceData = new List<VoiceData>();

        foreach (var i in Voices)
        {
            voiceData.Add(new VoiceData(i.voices,i.voiseName));
        }

        return voiceData;
    }


}
