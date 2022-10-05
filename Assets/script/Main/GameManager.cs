using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] VoiceButton buttonPrefab = default;
    [SerializeField] GameObject contents = default;
    [SerializeField] voiceAttach voices = default;
    [SerializeField] headerManager header = default;
    [SerializeField] Achievemenlayer achievemenlayer = default;
    private void Awake()
    {
        foreach(var i in voices.GetVoiceData()) {
            var buttons = Instantiate(buttonPrefab);
            buttons.setup(() => { 
                voicePlay(i.Voices);
                VoiceCount(i.Voices.name);
            }, i.VoicesName);
            buttons.gameObject.transform.parent = contents.transform;
            buttons.gameObject.SetActive(true);
        }

        header.setup(PlayerPrefs.GetString(LocalSaveKey.name.ToString()), () =>
        {
            if (!achievemenlayer.gameObject.activeSelf)
            {
                achievemenlayer.setup(voices);
                achievemenlayer.gameObject.SetActive(true);
            }
            else
            {
                achievemenlayer.gameObject.SetActive(false);
            }
        });
    }
    public void voicePlay(AudioClip voice)
    {
        this.GetComponent<AudioSource>().PlayOneShot(voice);
    }

    void VoiceCount(string VoiceName)
    {

        PlayerPrefs.SetInt(LocalSaveKey.voiceCount + "_" + VoiceName,
            PlayerPrefs.GetInt(LocalSaveKey.voiceCount + "_" + VoiceName, 0) + 1);

    }
}
