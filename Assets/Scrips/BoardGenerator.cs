using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject CampAlbPrefab;
    [SerializeField]
    private GameObject CampNegruPrefab;
    private int boardSize = 8;
    private float squareSize = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateChessBoard();
    }

    void GenerateChessBoard()
    {
        for (int x = 0; x < boardSize; x++)
        {
            for (int y = 0; y < boardSize; y++)
            {
                GameObject campPrefab;
                if ((x + y) % 2 == 0)
                {
                    campPrefab = CampAlbPrefab;
                }
                else
                {
                    campPrefab = CampNegruPrefab;
                }

                GameObject camp = Instantiate(campPrefab, new Vector3(x * squareSize, 0.1f, y * squareSize), Quaternion.identity);

                camp.transform.parent = this.transform;

                camp.name = $"Camp_{x}_{y}";
            }
        }
    }
}
