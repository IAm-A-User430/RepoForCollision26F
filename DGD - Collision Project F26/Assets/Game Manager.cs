using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{
    //Variables
    public GameObject collectible;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Respawn();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Make a function that spawns a collectible
    public void Respawn()
    {
        //Spawn a collectible at a random location
        Instantiate(collectible, new Vector2(Random.Range(-6f, 6f), Random.Range(-3f, 3f)), collectible.transform.rotation);

    }    

}
