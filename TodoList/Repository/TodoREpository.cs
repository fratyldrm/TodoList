using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository;

public sealed class TodoREpository :BaseRepository, ITodoRepository
{
    public Todo Add(Todo item)
    {
       Todos().Add(item);
        return item;
    }

    public Todo? Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Todo> GetAll()
    {
        return Todos();
      }

    public Todo? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Todo> GetByTitleContains(string title)
    {
        throw new NotImplementedException();
    }

    public Todo? Update(Todo item)
    {
        throw new NotImplementedException();
    }
}
