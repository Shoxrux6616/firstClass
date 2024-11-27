using Class_1.Models;

namespace Class_1.Service;

public class ZooService
{
    private List<Zoo> zoos;

    public ZooService()
    {
        zoos = new List<Zoo>();

    }
    public Zoo AddZoo(Zoo newZoo)
    {
        newZoo.Id = Guid.NewGuid();
        zoos.Add(newZoo);

        return newZoo;
    }
    public Zoo AddWorker(Zoo newWorker)
    {
        newWorker.Id = Guid.NewGuid();
        zoos.Add(newWorker);

        return newWorker;
    }
    public Zoo AddAnimal(Zoo newAnimal)
    {
        newAnimal.Id = Guid.NewGuid();
        zoos.Add(newAnimal);

        return newAnimal;
    }

    public Zoo AddAnimalFood(Zoo newAnimalFood)
    {
        newAnimalFood.Id = Guid.NewGuid();
        zoos.Add(newAnimalFood);

        return newAnimalFood;
    }

    public Zoo GetByZooId(Guid id)
    {
        foreach (Zoo zooDb in zoos)
        {
            if(zooDb.Id == id)
            {
                return zooDb;
            }
        }
        return null;
    }

    public bool DeleteZoo(Guid id)
    {
        var zooFormat = GetByZooId(id);

        if (zooFormat is null)
        {
            return false;
        }

        zoos.Remove(zooFormat);
        return true;
    }

    public bool DeleteWorker(Guid id)
    {
        var workerFormat = GetByZooId(id);

        if (workerFormat is null)
        {
            return false;
        }

        zoos.Remove(workerFormat);
        return true;
    }


    public bool DeleteAnimal(Guid id)
    {
        var animalFormat = GetByZooId(id);

        if (animalFormat is null)
        {
            return false;
        }

        zoos.Remove(animalFormat);
        return true;
    }

    public bool DeleteAnimalFood(Guid id)
    {
        var animalFoodFormat = GetByZooId(id);

        if (animalFoodFormat is null)
        {
            return false;
        }

        zoos.Remove(animalFoodFormat);
        return true;
    }

    public bool UpdateZoo(Zoo newZoo)
    {
        var zooFormat = GetByZooId(newZoo.Id);

        if (zooFormat is null)
        {
            return false;
        }

        var index = zoos.IndexOf(zooFormat);
        zoos[index] = newZoo;
        return true;
    }

    public bool UpdateWorker(Zoo newZoo)
    {
        var workerFormat = GetByZooId(newZoo.Id);

        if (workerFormat is null)
        {
            return false;
        }

        var index = zoos.IndexOf(workerFormat);
        zoos[index] = newZoo;
        return true;
    }

    public bool UpdateAnomal(Zoo newZoo)
    {
        var animalFormat = GetByZooId(newZoo.Id);

        if (animalFormat is null)
        {
            return false;
        }

        var index = zoos.IndexOf(animalFormat);
        zoos[index] = newZoo;
        return true;
    }

    public bool UpdateAnomalFood(Zoo newZoo)
    {
        var animalFoodFormat = GetByZooId(newZoo.Id);

        if (animalFoodFormat is null)
        {
            return false;
        }

        var index = zoos.IndexOf(animalFoodFormat);
        zoos[index] = newZoo;
        return true;
    }





}
