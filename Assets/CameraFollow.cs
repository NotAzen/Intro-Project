using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // initialize variables
    public GameObject player;
    Vector3 cameraPos, transformNeeded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // vector from camera to player (?)
        transformNeeded.x = cameraPos.x - player.transform.position.x;
        transformNeeded.y = cameraPos.y - player.transform.position.y;
        cameraPos = cameraPos - transformNeeded / 20;

        // actually assign camera position the cameraPos variable
        transform.position = cameraPos;

        //print(transform.position + ", " + cameraPos + ", " + player.transform.position);
    }
}
