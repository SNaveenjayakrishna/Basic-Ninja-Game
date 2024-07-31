
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public Transform target; // The target the camera should follow

    // Define the minimum and maximum x positions for the camera
    public float minX = 7f;
    public float maxX = 60f;

    void LateUpdate()
    {
        // Ensure the camera follows the target
     //   transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        // Clamp the camera's x position within the specified range
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
      // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
