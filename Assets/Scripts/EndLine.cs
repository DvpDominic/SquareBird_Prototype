using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLine : MonoBehaviour
{
    public GameObject bird;
    public Button nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        nextLevel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "head")
        {
            Destroy(bird.GetComponent<BirdController>());
            nextLevel.gameObject.SetActive(true);
        }
    }

    public void onNextLevel()
    {
        SceneManager.LoadScene(1);
    }

}
