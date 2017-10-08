using UnityEngine;
using System.Collections;

public class PickupArrow : MonoBehaviour
{
    public static GameObject mainCamera;
    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        pickup();
    }

    public static void pickup()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                arrowplaceholder p = hit.collider.GetComponent<arrowplaceholder>();
                if (p != null)
                {
                    Destroy(hit.transform.gameObject);
                    bowscript.arrows++;
                }
            }
        }
    }
}