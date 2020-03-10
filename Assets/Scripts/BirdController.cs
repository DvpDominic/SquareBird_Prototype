using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    //private Rigidbody rb;
    private Rigidbody2D rb;
    public GameObject bodyObject;
    public GameObject head;
    public float speed = 50f;
    public int count = 1;
    public List<GameObject> birdList;
    public static BirdController instant;

    // Start is called before the first frame update
    void Start()
    {
        instant = this;
        birdList.Add(head.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
        //rb.velocity = new Vector2(speed * Time.deltaTime, 0);
        count = birdList.Count;

        if (Input.GetMouseButtonDown(0)){
            
            for (int i = 0; i < birdList.Count; i++)
            {
                birdList[i].transform.position = new Vector3(birdList[i].transform.position.x, birdList[i].transform.position.y + 1, birdList[i].transform.position.z);
            }
            GameObject body = Instantiate(bodyObject, new Vector3(head.transform.position.x, head.transform.position.y - count, head.transform.position.z), head.transform.rotation);
            body.transform.parent = this.gameObject.transform;
            birdList.Add(body);
            
        }

    }


}
