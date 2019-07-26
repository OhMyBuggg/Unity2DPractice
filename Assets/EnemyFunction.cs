using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFunction : MonoBehaviour
{
    public GameObject explode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -0.01f, 0);
    }

    void OnTriggerEnter2D (Collider2D col) {
      if(col.tag == "Bullet" || col.tag == "Player"){
        Destroy(col.gameObject);
        Destroy(gameObject);

        Instantiate(explode, transform.position, transform.rotation);
        if(col.tag == "Player") {
            Instantiate(explode, col.gameObject.transform.position, col.gameObject.transform.rotation);
            GameFunction.Instance.GameOver();
        }

        GameFunction.Instance.AddScore();
      }
    }
}
