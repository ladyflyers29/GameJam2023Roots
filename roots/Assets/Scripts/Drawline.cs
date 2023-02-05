using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drawline : MonoBehaviour
{
    /*
   public GameObject[] prefabs; //Prefabs to spawn

    Camera c;
    int selectedPrefab = 0;
    int rayDistance = 300;

    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Camera>();
        if(prefabs.Length == 0)
        {
            Debug.LogError("You haven't assigned any Prefabs to spawn");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedPrefab++;
            if(selectedPrefab >= prefabs.Length)
            {
                selectedPrefab = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedPrefab--;
            if (selectedPrefab < 0)
            {
                selectedPrefab = prefabs.Length - 1;
            }
        }

        if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.LeftShift))
        {
            //Remove spawned prefab when holding left shift and left clicking
            Transform selectedTransform = GetObjectOnClick();
            if (selectedTransform)
            {
                Destroy(selectedTransform.gameObject);
            }
        }
        else if (Input.GetMouseButton(0))
        {
            //On left click spawn selected prefab and align its rotation to a surface normal
            Vector3[] spawnData = GetClickPositionAndNormal();
            if(spawnData[0] != Vector3.zero)
            {
                GameObject go = Instantiate(prefabs[selectedPrefab], spawnData[0], Quaternion.FromToRotation(prefabs[selectedPrefab].transform.up, spawnData[1]));
                go.name += " _instantiated";
            }
        }
    }

    Vector3[] GetClickPositionAndNormal()
    {
        Vector3[] returnData = new Vector3[] { Vector3.zero, Vector3.zero }; //0 = spawn poisiton, 1 = surface normal
        Ray ray = c.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            returnData[0] = hit.point;
            returnData[1] = hit.normal;
        }

        return returnData;
    }

    Transform GetObjectOnClick()
    {
        Ray ray = c.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Transform root = hit.transform.root;
            if (root.name.EndsWith("_instantiated"))
            {
                return root;
            }
        }

        return null;
    }

    void OnGUI()
    {
        if(prefabs.Length > 0 && selectedPrefab >= 0 && selectedPrefab < prefabs.Length)
        {
            string prefabName = prefabs[selectedPrefab].name;
            GUI.color = new Color(0, 0, 0, 0.84f);
            GUI.Label(new Rect(5 + 1, 5 + 1, 200, 25), prefabName);
            GUI.color = Color.green;
            GUI.Label(new Rect(5, 5, 200, 25), prefabName);
        }  
    }
    */

    /*

    public GameObject objectToSpawn; // Reference to the object to spawn
    public float increment = 1f; // The amount to increment by each time
    public float spawnDelay = 1f; // The delay between each spawn
    private float nextSpawnTime; // The time at which the next spawn can occur

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextSpawnTime) // Left mouse button click and enough time has passed
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // The position of the collision
                Vector3 spawnPosition = hit.point;
                // Increment the position by the given amount
               // spawnPosition += hit.normal * increment;
                // Spawn the object at the incremented position
                Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
                // Set the next spawn time
                nextSpawnTime = Time.time + spawnDelay;
            }
        }
    }
    */
    /*
    public GameObject objectToSpawn; // Reference to the object to spawn
    public float increment = 1f; // The amount to increment by each time
    public float spawnDelay = 1f; // The delay between each spawn
    private float nextSpawnTime; // The time at which the next spawn can occur

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextSpawnTime) // Left mouse button click and enough time has passed
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // The position of the collision
                Vector3 spawnPosition = hit.point;
                // Increment the position by the given amount
               // spawnPosition += hit.normal * increment;
                // Spawn the object at the incremented position
                Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
                // Set the next spawn time
                nextSpawnTime = Time.time + spawnDelay;
            }
        }

        else if (Input.GetMouseButton(1)) // Right mouse button click
        {



            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object has a Collider component
                Collider collider = hit.collider;
                if (collider != null)
                {
                    // Remove the object by destroying its GameObject
                    Destroy(collider.gameObject);
                }
            }
        }
    }
    
    */

    /*
    public GameObject objectToSpawn; // Reference to the object to spawn
    public float spawnDelay = 1f; // The delay between each spawn
    public float raycastMinLength = 0.1f; // The minimum length for the raycast
    private float nextSpawnTime; // The time at which the next spawn can occur

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextSpawnTime) // Left mouse button held down and enough time has passed
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, raycastMinLength))
            {

                if (hit.distance > 2.0f)
                {
                    // The position of the collision
                    Vector3 spawnPosition = hit.point;
                    // Spawn the object at the collision position
                    Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
                    // Set the next spawn time
                    nextSpawnTime = Time.time + spawnDelay;
                }

              
            }
        }
        else if (Input.GetMouseButton(1)) // Right mouse button held down
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, raycastMinLength))
            {
                // Check if the hit object was spawned by this script
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.CompareTag("SpawnedObject"))
                {
                    // Remove the object by destroying its GameObject
                    Destroy(hitObject);
                }
            }
        }
    }
    */


    public float ResourceLimitTotal = 50f;
    public float CurrentResourceLimit = 50f;

    public GameObject objectToSpawn; // Reference to the object to spawn
    public GameObject objectToSpawn2;
    public float spawnDelay = 1f; // The delay between each spawn
    public float sphereCastRadius = 1f; // The radius of the sphere cast
    public float sphereCastMaxDistance = 20f; // The maximum distance of the sphere cast
    private float nextSpawnTime; // The time at which the next spawn can occur
    public GameObject resourceSlider;

    void Update()
    {
        resourceSlider.GetComponent<Slider>().maxValue = ResourceLimitTotal;
        resourceSlider.GetComponent<Slider>().value = CurrentResourceLimit;

        if (Input.GetMouseButton(0) && Time.time >= nextSpawnTime) // Left mouse button held down and enough time has passed
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.SphereCast(ray, sphereCastRadius, out hit, sphereCastMaxDistance))
            {
                GameObject hitObject = hit.collider.gameObject;
                if (hit.distance > 1.5f)
                {

                    
                    
                    if (hitObject.CompareTag("Root") && CurrentResourceLimit >= 0f)
                    {

                      
                        if (CurrentResourceLimit > 0f)
                        {
                            CurrentResourceLimit -= Time.deltaTime + 1f;
                            // The position of the collision
                            Vector3 spawnPosition = hit.point;
                            // Spawn the object at the collision position
                            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
                            // Set the next spawn time
                            nextSpawnTime = Time.time + spawnDelay;
                           
                        }
                       
                    }

                    else if (hitObject.CompareTag("Root2"))
                    {
                        if (CurrentResourceLimit > 0f)
                        {
                            CurrentResourceLimit -= Time.deltaTime + 1f;
                            // The position of the collision
                            Vector3 spawnPosition = hit.point;
                            // Spawn the object at the collision position
                            GameObject spawnedObject = Instantiate(objectToSpawn2, spawnPosition, Quaternion.identity);
                            // Set the next spawn time
                            nextSpawnTime = Time.time + spawnDelay;
                        }
                            
                    }

                }
                   
            }
        }
        
        else if (Input.GetKey(KeyCode.Q)) // Right mouse button held down
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.SphereCast(ray, sphereCastRadius, out hit, sphereCastMaxDistance))
            {
                // Check if the hit object was spawned by this script
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.CompareTag("SpawnedObject"))
                {
                    // Remove the object by destroying its GameObject
                    Destroy(hitObject);
                }
            }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Buff"))
        {
            Destroy(other.gameObject);
            ResourceLimitTotal = ResourceLimitTotal + 10f;
            resourceSlider.GetComponent<Slider>().maxValue = ResourceLimitTotal; 
        }

        if (other.CompareTag("Refresh"))
        {
         
            CurrentResourceLimit = ResourceLimitTotal;
            resourceSlider.GetComponent<Slider>().value = CurrentResourceLimit;
        }
    }

}
