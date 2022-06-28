using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuilding : MonoBehaviour
{
    [SerializeField] private int countLevel;
    [SerializeField] private GameObject prefabBuildingLevel;
    [SerializeField] private List<Sprite> sprite = new List<Sprite>();


    private void Start()
    {
        CreatBuilding();
    }

    private void CreatBuilding()
    {
        float levelSizeY = prefabBuildingLevel.transform.localScale.y / 5;
        float positionY = levelSizeY;

        for (int i = 0; i < countLevel; i++)
        {
            prefabBuildingLevel.GetComponent<SpriteRenderer>().sprite = sprite[Random.Range(0, sprite.Count)];

            Instantiate(prefabBuildingLevel,
            new Vector3(0, i == 0 ? positionY : positionY += levelSizeY, 0),
            Quaternion.identity);
        }
    }
}
