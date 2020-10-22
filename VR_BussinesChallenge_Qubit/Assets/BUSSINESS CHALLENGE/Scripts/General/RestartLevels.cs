using UnityEngine;

public class RestartLevels : MonoBehaviour
{
    [SerializeField] internal Transform player;

    [Header("LEVEL PLATFORM")]
    [SerializeField] internal bool isLevelPlatform;
    [SerializeField] internal ManagerPlatform managerPlatform;
    [SerializeField] internal float[] position;


    public void RestartPositionPlayer()
    {
        player.position = new Vector3(position[0], position[1], position[2]);
        Destroy(player.GetComponent<Rigidbody>());
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(isLevelPlatform)
            {
                RestartPositionPlayer();

                foreach (var item in managerPlatform.listPlatform)
                {
                    item.SetActive(true);
                }
            }
        }
    }
}
