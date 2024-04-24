using UnityEngine;

public class CheckersManager : MonoBehaviour
{
    [SerializeField]
    private GameObject whitePiecePrefab;
    [SerializeField]
    private GameObject blackPiecePrefab;
    [SerializeField]
    private Transform boardOrigin;
    public float tileSize;

    private GameObject[,] pieces = new GameObject[8, 8];

    void Start()
    {
        PlacePieces();
    }

    void PlacePieces()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((row + col) % 2 != 0)
                {
                    Vector3 piecePosition = new Vector3(col * tileSize, 1f, row * tileSize);

                    GameObject piece = null;
                    if (row < 3)
                    {
                        piece = Instantiate(whitePiecePrefab);
                    }
                    else if (row > 4)
                    {
                        piece = Instantiate(blackPiecePrefab);
                    }

                    if (piece != null)
                    {
                        piece.transform.position = piecePosition;
                        pieces[row, col] = piece;
                    }
                }
            }
        }
    }
}