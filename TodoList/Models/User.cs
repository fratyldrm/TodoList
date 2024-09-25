

namespace TodoList.Models;

public class User :Entity
{


 
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string SurName { get; set; }
    public int Age { get; set; }
}
