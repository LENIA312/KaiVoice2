using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "KaiVoice/CreatVoiceTable", fileName = "VoiceTable")]

public class voiceAttach : ScriptableObject
{
    
    [SerializeField] public List<AudioClip> Voices;
    [SerializeField] public List<string> VoicesName;

    public class VoiceData
    {
        public AudioClip Voices;
        public string VoicesName;

        public VoiceData(AudioClip audioClip, string name)
        {
            Voices = audioClip;
            VoicesName = name;
        }
    }

    public List<VoiceData> GetVoiceData()
    {
        var voiceData = new List<VoiceData>();

        foreach (var i in Voices.Select((value,Index)=> new
        {
            value,Index
        }))
        {
            voiceData.Add(new VoiceData(Voices[int.Parse(i.Index.ToString())], VoicesName[int.Parse(i.Index.ToString())]));
        }

        return voiceData;
    }


}
