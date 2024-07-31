// Create a folder named "Editor" under your "Assets" folder and place this script inside it.
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class AutoOpenScene
{
    static AutoOpenScene()
    {
        EditorApplication.update += OpenDefaultScene;
    }

    private static void OpenDefaultScene()
    {
        EditorApplication.update -= OpenDefaultScene;

        if (Application.isPlaying || Application.isBatchMode)
            return;

        // Path to your default scene relative to the "Assets" folder
        string defaultScenePath = "Assets/MainScene.unity";

        // Check if the current scene is not the default scene
        if (EditorSceneManager.GetActiveScene().path != defaultScenePath)
        {
            EditorSceneManager.OpenScene(defaultScenePath);
        }
    }
}
