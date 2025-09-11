using UnityEngine;

public class ScrollZoom : MonoBehaviour
{
    public Camera CameraZoom;
    float predictedZoom;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0)
        {
            predictedZoom = CameraZoom.orthographicSize - 3 * scrollInput;

            // change 
            if (10 > predictedZoom && predictedZoom > 5) {
                CameraZoom.orthographicSize -= 3*scrollInput;
            }
        }
    }
}
