using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievemenlayer : MonoBehaviour
{
    [SerializeField] VoiceDataItem voiceDataItem = default;
    [SerializeField] GameObject contents = default;

    public void setup(voiceAttach voices)
    {

        foreach (var i in voices.GetVoiceData())
        {
            var buttons = Instantiate(voiceDataItem);
            buttons.setup(i.VoicesName, PlayerPrefs.GetInt(LocalSaveKey.voiceCount + "_" + i.Voices.name, 0));
            buttons.gameObject.transform.parent = contents.transform;
            buttons.gameObject.SetActive(true);
        }

    }
}
