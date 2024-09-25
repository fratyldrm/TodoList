using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Repository;

namespace TodoList.Models;

public  class Category:Entity
{
    public string Name { get; set; }
}
