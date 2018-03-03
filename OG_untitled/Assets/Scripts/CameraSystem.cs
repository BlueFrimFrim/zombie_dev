using UnityEngine;
using System.Collections;

public class CameraSystem : MonoBehaviour {
    private GameObject player;
    public float x_min;
    public float x_max;
    public float y_min;
    public float y_max;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () {
        float x = Mathf.Clamp(player.transform.position.x, x_min, x_max);
        float y = Mathf.Clamp(player.transform.position.y, y_min, y_max);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
