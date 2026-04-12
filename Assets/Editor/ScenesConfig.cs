using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "ScenesConfig", menuName = "My Configs/Scenes Config")]
public class ScenesConfig : ScriptableObject
{
    public SceneAsset startScene;
    public SceneAsset[] scenes;
}
