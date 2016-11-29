using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour, IPointerClickHandler {

    public string Scene;

    public void OnPointerClick(PointerEventData eventData) {
        if (Scene != null)
            SceneManager.LoadScene(Scene);
    }
}
