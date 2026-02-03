using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject planet;
    public float degreesPerSecond = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
    }
}
