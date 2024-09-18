using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int xWorldSize, yWorldSize;
    private WorldCreator gridC;
    void Start()
    {
        gridC = gameObject.GetComponent<WorldCreator>();
        gridC.CreateGrid(xWorldSize, yWorldSize);
    }
}
