#pragma warning disable CS8618
namespace ChefsNDishes.Models;
/****ADD DATE OF BIRTH VALIDATION****/
public class MyViewModel 
    {   
        public Dish Dish {get; set;}
        public List<Chef> ListOfChefs {get; set;} = new List<Chef>();
    }