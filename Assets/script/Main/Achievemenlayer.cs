using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievemenlayer : MonoBehaviour
{
    [SerializeField] VoiceDataItem voiceDataItem = default;
    [SerializeField] GameObject contents = default;

    public void setup(voiceAttach voices)
    {
        // �I�u�W�F�N�g��S�폜
        foreach (Transform n in contents.transform)
        {
            GameObject.Destroy(n.gameObject);
        }

        // �I�u�W�F�N�g�𐶐�
        foreach (var i in voices.GetVoiceData())
        {
            var ItemData = Instantiate(voiceDataItem);
            ItemData.setup(i.voiseName, PlayerPrefs.GetInt(LocalSaveKey.voiceCount + "_" + i.voiseName, 0));
            ItemData.gameObject.transform.parent = contents.transform;
            ItemData.gameObject.SetActive(true);
        }

    }
}
