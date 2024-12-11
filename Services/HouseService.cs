using FirstModulRetakeExam_AbdullokhOdilov.Models;

namespace FirstModulRetakeExam_AbdullokhOdilov.Services;

public class HouseService
{
    private List<House> houses;

    public HouseService()
    {
        houses = new List<House>();
    }

    public House Add(House house)
    {
        house.Id = Guid.NewGuid();
        houses.Add(house);
        return house;
    }

    public House GetById(Guid houseId)
    {
        foreach (var house in houses)
        {
            if (house.Id == houseId)
            {
                return house;
            }
        }
        return null;
    }

    public bool Update(House house)
    {
        var houseFromDb = GetById(house.Id);

        if (houseFromDb is null)
        {
            return false;
        }
        
        var index = houses.IndexOf(houseFromDb);
        houses[index] = house;
        return true;
    }

    public bool Delete(House house)
    {
        var houseFromDb = GetById(house.Id);

        if (houseFromDb is null)
        {
            return false;
        }
        
        houses.Remove(houseFromDb); 
        return true;
    }

    public List<House> GetAll()
    {
        return houses;
    }
}