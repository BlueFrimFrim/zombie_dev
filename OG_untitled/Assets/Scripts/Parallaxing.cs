using UnityEngine;
using System.Collections;

public class Parallaxing : MonoBehaviour {

    private float[] parallaxScales; 
    public Transform[] backgrounds; /* Array of all backgrounds */
    public float smoothing = 0.01f;

    private Transform cameraReference; /* Reference to main camera */
    private Vector3 previousCameraPosition;

    private void Awake() /* Called before Start() */
    {
        cameraReference = Camera.main.transform;
    }

    // Use this for initialization
    void Start ()
    {
        previousCameraPosition = cameraReference.position;
        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++) {
            parallaxScales[i] = backgrounds[i].position.z * (-1);
        }
	}
	
	// Update is called once per frame
	void Update ()            

    {
        for (int i = 0; i < backgrounds.Length; i++) {

            float parallax = (previousCameraPosition.x - cameraReference.position.x) * parallaxScales[i];
            float backgroundPos_x = backgrounds[i].position.x + parallax;
            /* note that this will need to be done for y once we move up higher */
            Vector3 backgroundPos = new Vector3(backgroundPos_x, backgrounds[i].position.y, backgrounds[i].position.z);
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundPos, smoothing * Time.deltaTime);
        }

        /* Set camera position */
        previousCameraPosition = cameraReference.position;
	}
}
