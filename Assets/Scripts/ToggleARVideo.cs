using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ToggleARVideo : MonoBehaviour
{
    public GameObject arVideoPlayerGameObject;

    private bool isVideoVisible = true;

    private void Start()
    {
        // Assuming you have a button with an onClick event pointing to this script's ToggleVideoVisibility method
    }

    public void ToggleVideoVisibility()
    {
        if (arVideoPlayerGameObject != null)
        {
            arVideoPlayerGameObject.SetActive(!isVideoVisible);
            isVideoVisible = !isVideoVisible;
        }
    }
}
