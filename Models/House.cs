using FirstModulRetakeExam_AbdullokhOdilov.Services;

namespace FirstModulRetakeExam_AbdullokhOdilov.Models;

public class House
{
    public Guid Id { get; set; }
    public string Location { get; set; }
    public string Describtion { get; set; }
    public double Price { get; set; }
    public int QuentityRooms { get; set; }
    
}