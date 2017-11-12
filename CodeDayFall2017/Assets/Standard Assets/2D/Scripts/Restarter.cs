using System;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("xd");
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }
    }
}
*/

/*
namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public int deathCounter;
        private void OnTriggerEnter2D(Collider2D other)

        {
           

            //if (other.tag == "Player")
            // {
            //transform.position = new Vector3(23.83f, -8.3f);
            // transform.Translate(23.83f, -8.3f, 0f);
            //  deathCounter++;
            //    Collider2D other.transform.GetChild();
            // }
            if (other.tag == "Player")
            {
                Debug.Log("xd");
                transform.position = other.transform.GetChild(0).position;
                    
            }

        }
    }
}
*/
namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public GameObject spawn;
        public GameObject spawnTarget;
        public int deathCounter;
        private void OnTriggerEnter2D(Collider2D other)
        {
            
            Debug.Log("xd");
            spawnTarget.transform.position = spawn.transform.position;
            
        }
    }
}