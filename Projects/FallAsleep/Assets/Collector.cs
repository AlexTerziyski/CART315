using UnityEngine;

public class Collector : MonoBehaviour
{
    public float xLoc, yLoc;
    public float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xLoc = 0;
        yLoc = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Left");
            xLoc -= speed;

        }
        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("Right");
            xLoc += speed;
        }
        this.transform.position = new Vector3(xLoc, yLoc, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag == "Circle"){
            Destroy(other.gameObject);
        }
    }
}
