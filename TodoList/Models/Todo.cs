

namespace TodoList.Models;

public  class Todo:Entity
{

   
    public int Title { get; set; }
    public int Description { get; set; }
    public DateTime CreateDate { get; set; }
    public string StartDate { get; set; }
    public string EndtDate { get; set; }
    public string Priority { get; set; }
    public bool IsCompleted { get; set; }
    public string UserId { get; set; }

}
