

using TodoList.Models;

namespace TodoList.Repository;

public   class BaseRepository
{

    List<Todo> todos = new List<Todo>();
    List<User> users = new List<User>();


    public List<User> Users()
    {
        return users;
    }

    public List<Todo> Todos()
    {
        return todos; 
    }


}
