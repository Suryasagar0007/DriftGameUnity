using UnityEngine;

public class DriveContoller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0,0, Input.GetAxis("Vertical") * 0.1f);
        }
    }
}
