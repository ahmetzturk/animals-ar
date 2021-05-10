using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalType
{
    None,
    Penguen,
    Zürafa,
    Tavþan
}

public class Animal : MonoBehaviour
{
    [SerializeField] AnimalType animalType;
    [SerializeField] Execute activeAnimal;

    private AnimalType previousActiveAnimal;

    public AnimalType AnimalType { get => animalType; }

    public void SetActiveAnimal()
    {
        if(previousActiveAnimal != animalType)
            activeAnimal.StopIt();

        activeAnimal.activeAnimal = animalType;
    }

    public void ResetActiveAnimal()
    {
        previousActiveAnimal = activeAnimal.activeAnimal;
        activeAnimal.activeAnimal = AnimalType.None;
    }
}


