using UnityEngine;

public class BrickLayerManager : MonoBehaviour
{
    public GameObject brick;
    public GameObject[] powerUpBricks; // array for power-up brick prefabs

    public int rows, columns;
    public float brickSpacing_h;
    public float brickSpacing_v;

    [Range(0, 100)]
    public float powerUpChance = 15f; // 15% chance for a power-up brick

    void Start()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                float xPos = -columns + (i * brickSpacing_h);
                float yPos = rows - (j * brickSpacing_v);
                Vector3 position = new Vector3(xPos, yPos, 0);

                // Randomly decide if this should be a power-up brick
                if (Random.Range(0f, 100f) < powerUpChance && powerUpBricks.Length > 0)
                {
                    // Randomly select one of our power-up prefabs
                    int randomPowerUpIndex = Random.Range(0, powerUpBricks.Length);
                    Instantiate(powerUpBricks[randomPowerUpIndex], position, transform.rotation);
                }
                else
                {
                    // Spawn regular brick
                    Instantiate(brick, position, transform.rotation);
                }
            }
        }
    }
}