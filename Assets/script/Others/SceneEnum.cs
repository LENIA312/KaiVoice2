using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEnum
{
    public enum SceneType
    {
        Title,
        Game,
    }

    public static Dictionary<SceneType, string> TypeToName = new Dictionary<SceneType, string>()
    {
        [SceneType.Title] = "",
        [SceneType.Game] = "",
    };
}
