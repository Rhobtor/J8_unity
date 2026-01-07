using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public class AutoLoadScene
{
    static AutoLoadScene()
    {
        EditorApplication.delayCall += () =>
        {
            // Solo cargar si no hay escena abierta o si es la escena "Untitled"
            var currentScene = EditorSceneManager.GetActiveScene();
            
            if (!currentScene.IsValid() || string.IsNullOrEmpty(currentScene.path) || currentScene.path == "")
            {
                string scenePath = "Assets/Scenes/LAENTIEC_Day.unity";
                
                if (System.IO.File.Exists(scenePath))
                {
                    Debug.Log($"Auto-loading scene: {scenePath}");
                    EditorSceneManager.OpenScene(scenePath);
                }
            }
        };
    }
}
