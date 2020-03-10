using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleController : MonoBehaviour
{
    public GameObject bird;
    public Text lost;

    // Start is called before the first frame update
    void Start()
    {
        lost.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "body")
        {
            if (other.gameObject.transform.position.y > this.transform.position.y)
            {
                if ((other.gameObject.transform.position.y - this.transform.position.y) <= 0.95f)
                {
                    other.gameObject.transform.SetParent(null);
                    BirdController.instant.birdList.Remove(other.gameObject);
                    //BirdController.instant.count -= 1;
                    Destroy(other.gameObject,3);
                    
                }
                else return;
            }

            else if((this.transform.position.y>other.gameObject.transform.position.y))
            {
                if ((this.transform.position.y - other.gameObject.transform.position.y) <= 0.95f)
                {
                    other.gameObject.transform.SetParent(null);
                    BirdController.instant.birdList.Remove(other.gameObject);
                    //BirdController.instant.count -= 1;
                    Destroy(other.gameObject,3);
                    
                }
                else return;
            }

            else if(this.transform.position.y == other.gameObject.transform.position.y)
            {
                other.gameObject.transform.SetParent(null);
                BirdController.instant.birdList.Remove(other.gameObject);
                //BirdController.instant.count -= 1;
                Destroy(other.gameObject,3);
            }
        }

        if (other.gameObject.tag == "head")
        {
            if (other.gameObject.transform.position.y > this.transform.position.y)
            {
                if ((other.gameObject.transform.position.y - this.transform.position.y) <= 0.95f)
                {
                    other.gameObject.transform.SetParent(null);
                    BirdController.instant.birdList.Remove(other.gameObject);
                    //BirdController.instant.count -= 1;
                    Destroy(other.gameObject, 3);
                    Destroy(bird.GetComponent<BirdController>());
                    lost.gameObject.SetActive(true);
                }
                else return;
            }

            else if ((this.transform.position.y > other.gameObject.transform.position.y))
            {
                if ((this.transform.position.y - other.gameObject.transform.position.y) <= 0.95f)
                {
                    other.gameObject.transform.SetParent(null);
                    BirdController.instant.birdList.Remove(other.gameObject);
                    //BirdController.instant.count -= 1;
                    Destroy(other.gameObject, 3);
                    Destroy(bird.GetComponent<BirdController>());
                    lost.gameObject.SetActive(true);
                }
                else return;
            }

            else if (this.transform.position.y == other.gameObject.transform.position.y)
            {
                other.gameObject.transform.SetParent(null);
                BirdController.instant.birdList.Remove(other.gameObject);
                //BirdController.instant.count -= 1;
                Destroy(other.gameObject, 3);
                Destroy(bird.GetComponent<BirdController>());
                lost.gameObject.SetActive(true);
            }
        }
    }
}
